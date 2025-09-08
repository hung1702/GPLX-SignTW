using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GPLX_Sign.Cryptography;

public class CRLHelper
{
	private string fileName { get; set; }

	public List<RevocationItem> CRL { get; set; }

	public string Issuer { get; set; }

	public DateTime NextUpdate { get; set; }

	public CRLHelper(string fileName)
	{
		CRL = new List<RevocationItem>();
		this.fileName = fileName;
		GetInformation();
	}

	private void GetInformation()
	{
		bool flag = false;
		IntPtr ppvContext = IntPtr.Zero;
		int num = 0;
		StringBuilder stringBuilder = null;
		IntPtr zero = IntPtr.Zero;
		string text = "";
		IntPtr zero2 = IntPtr.Zero;
		byte b = 0;
		IntPtr zero3 = IntPtr.Zero;
		try
		{
			if (!Win32.CryptQueryObject(1, fileName, 8, 2, 0, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, ref ppvContext))
			{
				throw new Exception("CryptQueryObject error #" + Marshal.GetLastWin32Error());
			}
			Win32.CRL_INFO cRL_INFO = (Win32.CRL_INFO)Marshal.PtrToStructure(((Win32.CRL_CONTEXT)Marshal.PtrToStructure(ppvContext, typeof(Win32.CRL_CONTEXT))).pCrlInfo, typeof(Win32.CRL_INFO));
			num = Win32.CertNameToStr(65537, ref cRL_INFO.Issuer, 3, null, 0);
			if (num <= 0)
			{
				throw new Exception("CertNameToStr error #" + Marshal.GetLastWin32Error());
			}
			stringBuilder = new StringBuilder(num);
			num = Win32.CertNameToStr(65537, ref cRL_INFO.Issuer, 3, stringBuilder, num);
			if (num <= 0)
			{
				throw new Exception("CertNameToStr error #" + Marshal.GetLastWin32Error());
			}
			Issuer = stringBuilder.ToString();
			NextUpdate = FileTimeToDateTime(cRL_INFO.NextUpdate);
			zero = cRL_INFO.rgCRLEntry;
			for (int i = 0; i < cRL_INFO.cCRLEntry; i++)
			{
				text = "";
				Win32.CRL_ENTRY cRL_ENTRY = (Win32.CRL_ENTRY)Marshal.PtrToStructure(zero, typeof(Win32.CRL_ENTRY));
				zero2 = cRL_ENTRY.SerialNumber.pbData;
				for (int j = 0; j < cRL_ENTRY.SerialNumber.cbData; j++)
				{
					text = Marshal.ReadByte(zero2).ToString("X").PadLeft(2, '0') + " " + text;
					zero2 = (IntPtr)((int)zero2 + Marshal.SizeOf(typeof(byte)));
				}
				DateTime revocationDate = FileTimeToDateTime(cRL_ENTRY.RevocationDate);
				RevocationItem item = new RevocationItem
				{
					SerialNumber = text.Trim(),
					RevocationDate = revocationDate
				};
				CRL.Add(item);
				zero = (IntPtr)((int)zero + Marshal.SizeOf(typeof(Win32.CRL_ENTRY)));
			}
		}
		finally
		{
			if (!ppvContext.Equals(IntPtr.Zero))
			{
				Win32.CertFreeCRLContext(ppvContext);
			}
		}
	}

	private static DateTime FileTimeToDateTime(Win32.FILETIME fileTime)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(8);
		try
		{
			Marshal.StructureToPtr((object)fileTime, intPtr, fDeleteOld: true);
			return DateTime.FromFileTime(Marshal.ReadInt64(intPtr));
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}
}
