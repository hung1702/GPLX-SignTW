using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security.Cryptography;

namespace GPLX_Sign.Cryptography;

public class CryptographyData
{
	public object Data { get; set; }

	public List<string> PropertyList { get; set; }

	public RSACryptography RSA { get; set; }

	public void SetData(object data)
	{
		Data = data;
	}

	public void SetPropertyList(params string[] propeties)
	{
		PropertyList = new List<string>();
		foreach (string item in propeties)
		{
			PropertyList.Add(item);
		}
	}

	private string GetValue(string propertyName)
	{
		try
		{
			return Data.GetType().InvokeMember(propertyName, BindingFlags.GetProperty, null, Data, null).ToString();
		}
		catch (Exception inner)
		{
			throw new CryptographicException("Property '" + propertyName + "' không có trong dữ liệu kí.", inner);
		}
	}

	private string GetPresentationText()
	{
		PropertyList.Sort();
		string text = string.Empty;
		foreach (string property in PropertyList)
		{
			text = text + property + ":" + GetValue(property);
		}
		return text;
	}

	public string GetSignedData()
	{
		string presentationText = GetPresentationText();
		if (RSA == null)
		{
			throw new CryptographicException("Thông tin kí số RSACryptography chưa được khởi tạo. ");
		}
		return RSA.SignHash(presentationText);
	}

	public bool Verify(string sign)
	{
		string presentationText = GetPresentationText();
		if (RSA == null)
		{
			throw new CryptographicException("Thông tin kí số RSACryptography chưa được khởi tạo. ");
		}
		return RSA.VerifyHash(presentationText, sign);
	}
}
