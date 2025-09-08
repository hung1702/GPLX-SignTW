using System;
using System.Runtime.InteropServices;
using System.Text;

namespace GPLX_Sign.Cryptography;

public class Win32
{
	public struct CRL_CONTEXT
	{
		public int dwCertEncodingType;

		public IntPtr pbCrlEncoded;

		public int cbCrlEncoded;

		public IntPtr pCrlInfo;

		public IntPtr hCertStore;
	}

	public struct CRL_INFO
	{
		public int dwVersion;

		public CRYPT_ALGORITHM_IDENTIFIER SignatureAlgorithm;

		public CRYPTOAPI_BLOB Issuer;

		public FILETIME ThisUpdate;

		public FILETIME NextUpdate;

		public int cCRLEntry;

		public IntPtr rgCRLEntry;

		public int cExtension;

		public IntPtr rgExtension;
	}

	public struct CRYPT_ALGORITHM_IDENTIFIER
	{
		[MarshalAs(UnmanagedType.LPStr)]
		public string pszObjId;

		public CRYPTOAPI_BLOB Parameters;
	}

	public struct CRYPTOAPI_BLOB
	{
		public int cbData;

		public IntPtr pbData;
	}

	public struct FILETIME
	{
		public int dwLowDateTime;

		public int dwHighDateTime;
	}

	public struct CRL_ENTRY
	{
		public CRYPTOAPI_BLOB SerialNumber;

		public FILETIME RevocationDate;

		public int cExtension;

		public IntPtr rgExtension;
	}

	public struct CERT_EXTENSION
	{
		[MarshalAs(UnmanagedType.LPStr)]
		public string pszObjId;

		public bool fCritical;

		public CRYPTOAPI_BLOB Value;
	}

	public const int CERT_QUERY_OBJECT_FILE = 1;

	public const int CERT_QUERY_CONTENT_CRL = 3;

	public const int CERT_QUERY_CONTENT_FLAG_CRL = 8;

	public const int CERT_QUERY_FORMAT_BINARY = 1;

	public const int CERT_QUERY_FORMAT_BASE64_ENCODED = 2;

	public const int CERT_QUERY_FORMAT_ASN_ASCII_HEX_ENCODED = 3;

	public const int CERT_QUERY_FORMAT_FLAG_BINARY = 2;

	public const int CERT_QUERY_FORMAT_FLAG_BASE64_ENCODED = 4;

	public const int CERT_QUERY_FORMAT_FLAG_ASN_ASCII_HEX_ENCODED = 8;

	public const int CERT_QUERY_FORMAT_FLAG_ALL = 14;

	public const int X509_ASN_ENCODING = 1;

	public const int PKCS_7_ASN_ENCODING = 65536;

	public const int X509_NAME = 7;

	public const int CERT_SIMPLE_NAME_STR = 1;

	public const int CERT_OID_NAME_STR = 2;

	public const int CERT_X500_NAME_STR = 3;

	public const string szOID_CRL_REASON_CODE = "2.5.29.21";

	[DllImport("CRYPT32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CryptQueryObject(int dwObjectType, [MarshalAs(UnmanagedType.LPWStr)] string pvObject, int dwExpectedContentTypeFlags, int dwExpectedFormatTypeFlags, int dwFlags, IntPtr pdwMsgAndCertEncodingType, IntPtr pdwContentType, IntPtr pdwFormatType, IntPtr phCertStore, IntPtr phMsg, ref IntPtr ppvContext);

	[DllImport("CRYPT32.DLL", SetLastError = true)]
	public static extern bool CertFreeCRLContext(IntPtr pCrlContext);

	[DllImport("CRYPT32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int CertNameToStr(int dwCertEncodingType, ref CRYPTOAPI_BLOB pName, int dwStrType, StringBuilder psz, int csz);

	[DllImport("CRYPT32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern IntPtr CertFindExtension([MarshalAs(UnmanagedType.LPStr)] string pszObjId, int cExtensions, IntPtr rgExtensions);

	[DllImport("CRYPT32.DLL", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CryptFormatObject(int dwCertEncodingType, int dwFormatType, int dwFormatStrType, IntPtr pFormatStruct, [MarshalAs(UnmanagedType.LPStr)] string lpszStructType, IntPtr pbEncoded, int cbEncoded, StringBuilder pbFormat, ref int pcbFormat);
}
