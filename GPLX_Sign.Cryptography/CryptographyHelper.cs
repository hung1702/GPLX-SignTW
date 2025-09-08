using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GPLX_Sign.Cryptography;

public class CryptographyHelper
{
	public static List<X509Certificate2> GetListX509Certificated()
	{
		List<X509Certificate2> list = new List<X509Certificate2>();
		X509Store x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
		x509Store.Open(OpenFlags.ReadOnly);
		X509Certificate2Enumerator enumerator = x509Store.Certificates.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509Certificate2 current = enumerator.Current;
			list.Add(current);
		}
		return list;
	}

	public static List<string> GetX509CertificatedNames()
	{
		List<string> list = new List<string> { "BAN CO YEU CHINH PHU", "BỘ GIAO THÔNG VẬN TẢI", "101-LÁNG HẠ ĐỐNG ĐA-HN", "SỞ GIAO THÔNG VẬN TẢI", "SỞ GIAO THÔNG VẬN TẢI1", "CO QUAN CHUNG THUC SO CHINH PHU", "CO QUAN CHUNG THUC SO CHINH PHU1", "BAN CO YEU CHINH PHU1" };
		List<string> list2 = new List<string>();
		X509Store x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
		x509Store.Open(OpenFlags.ReadOnly);
		X509Certificate2Enumerator enumerator = x509Store.Certificates.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509Certificate2 current = enumerator.Current;
			string text = current.SubjectName.Name.ToString();
			if (text != "" && !text.ToUpper().Contains("(M)") && (text.ToUpper().Contains("BAN CO YEU CHINH PHU") || text.ToUpper().Contains("BỘ GIAO THÔNG VẬN TẢI") || text.ToUpper().Contains("SỞ GIAO THÔNG VẬN TẢI") || text.ToUpper().Contains("SỞ GIAO THÔNG VẬN TẢI") || text.ToUpper().Contains("BỘ CÔNG AN")))
			{
				list2.Add(text);
			}
		}
		return list2;
	}

	public static List<string> GetX509CertificatedNamesAll()
	{
		List<string> list = new List<string>();
		X509Store x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
		x509Store.Open(OpenFlags.ReadOnly);
		X509Certificate2Enumerator enumerator = x509Store.Certificates.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509Certificate2 current = enumerator.Current;
			string item = current.SubjectName.Name.ToString();
			list.Add(item);
		}
		return list;
	}

	public static X509Certificate2 GetStoreX509Certificate2(string name)
	{
		X509Certificate2 result = null;
		X509Store x509Store = new X509Store(StoreName.My, StoreLocation.CurrentUser);
		x509Store.Open(OpenFlags.ReadOnly);
		X509Certificate2Enumerator enumerator = x509Store.Certificates.GetEnumerator();
		while (enumerator.MoveNext())
		{
			X509Certificate2 current = enumerator.Current;
			if (current.SubjectName.Name.ToString() == name)
			{
				result = current;
			}
		}
		return result;
	}

	public static X509Certificate2 GetX509Certificate2(string certificate)
	{
		X509Certificate2 x509Certificate = new X509Certificate2();
		byte[] rawData = Convert.FromBase64String(certificate);
		x509Certificate.Import(rawData);
		return x509Certificate;
	}

	public static HashAlgorithm GetHashAlgorithm(HashAlgorithmName name)
	{
		if (1 == 0)
		{
		}
		HashAlgorithm result = name switch
		{
			HashAlgorithmName.MD5 => new MD5CryptoServiceProvider(), 
			HashAlgorithmName.SHA1 => new SHA1Managed(), 
			_ => throw new Exception("Unknown hash algorithm!"), 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	public static HashAlgorithm GetHashAlgorithm(X509Certificate2 certificate)
	{
		if (certificate.SignatureAlgorithm.FriendlyName.ToUpper().Contains("MD5"))
		{
			return GetHashAlgorithm(HashAlgorithmName.MD5);
		}
		if (certificate.SignatureAlgorithm.FriendlyName.ToUpper().Contains("SHA1"))
		{
			return GetHashAlgorithm(HashAlgorithmName.SHA1);
		}
		throw new Exception("Unknown hash algorithm!");
	}

	public static HashAlgorithm GetHashAlgorithm(string certificate)
	{
		X509Certificate2 x509Certificate = new X509Certificate2();
		x509Certificate.Import(certificate);
		return GetHashAlgorithm(x509Certificate);
	}

	public static string GetHashAlgorithmName(X509Certificate2 certificate)
	{
		if (certificate.SignatureAlgorithm.FriendlyName.ToUpper().Contains("MD5"))
		{
			return HashAlgorithmName.MD5.ToString();
		}
		if (certificate.SignatureAlgorithm.FriendlyName.ToUpper().Contains("SHA1"))
		{
			return HashAlgorithmName.SHA1.ToString();
		}
		throw new Exception("Unknown hash algorithm!");
	}

	public static bool VerifyHash(string data, string sign, X509Certificate2 cert)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(data);
		byte[] sign2 = Convert.FromBase64String(sign);
		return VerifyHash(bytes, sign2, cert);
	}

	public static bool VerifyHash(byte[] data, byte[] sign, X509Certificate2 cert)
	{
		HashAlgorithm hashAlgorithm = GetHashAlgorithm(cert);
		string hashAlgorithmName = GetHashAlgorithmName(cert);
		byte[] rgbHash = hashAlgorithm.ComputeHash(data);
		RSACryptoServiceProvider rSACryptoServiceProvider = cert.PublicKey.Key as RSACryptoServiceProvider;
		return rSACryptoServiceProvider.VerifyHash(rgbHash, CryptoConfig.MapNameToOID(hashAlgorithmName), sign);
	}

	public static string SignHash(string data, HashAlgorithmName algorithmName, X509Certificate2 cert, OutputDataType datatype)
	{
		HashAlgorithm hashAlgorithm = GetHashAlgorithm(algorithmName);
		byte[] bytes = Encoding.UTF8.GetBytes(data);
		byte[] rgbHash = hashAlgorithm.ComputeHash(bytes);
		RSACryptoServiceProvider rSACryptoServiceProvider = (RSACryptoServiceProvider)cert.PrivateKey;
		byte[] array = rSACryptoServiceProvider.SignHash(rgbHash, CryptoConfig.MapNameToOID(algorithmName.ToString()));
		return ToString(array, datatype);
	}

	public static string ToBase64String(byte[] r)
	{
		return Convert.ToBase64String(r);
	}

	public static string ToHexString(byte[] r)
	{
		string text = string.Empty;
		for (int i = 0; i < r.Length; i++)
		{
			text += r[i].ToString("X2");
		}
		return text;
	}

	public static string ToString(byte[] r, OutputDataType type)
	{
		if (1 == 0)
		{
		}
		string result = type switch
		{
			OutputDataType.Base64 => ToBase64String(r), 
			OutputDataType.Hex => ToHexString(r), 
			_ => throw new Exception("Unknown output type!"), 
		};
		if (1 == 0)
		{
		}
		return result;
	}
}
