using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace GPLX_Sign.Cryptography;

public class RSACryptography
{
	private X509Certificate2 cert;

	public string SerialNumber
	{
		get
		{
			string text = cert.SerialNumber;
			int length = text.Length;
			for (int num = length / 2 - 1; num > 0; num--)
			{
				text = text.Insert(2 * num, " ");
			}
			return text;
		}
	}

	public string Issuer => cert.Issuer;

	public DateTime NotAfter => cert.NotAfter;

	public DateTime NotBefore => cert.NotBefore;

	public string RawData => Convert.ToBase64String(cert.RawData);

	public RSACryptography(string certificated)
	{
		if (string.IsNullOrEmpty(certificated))
		{
			throw new CryptographicException("Thông tư chứng thư cần khác empty và null.");
		}
		byte[] rawData = Convert.FromBase64String(certificated);
		cert = new X509Certificate2();
		cert.Import(rawData);
		ValidateCert();
	}

	public RSACryptography(X509Certificate2 certificated)
	{
		if (certificated == null)
		{
			throw new CryptographicException("Thông tư chứng thư cần khác empty và null.");
		}
		cert = certificated;
		ValidateCert();
	}

	public RSACryptography(byte[] certificated)
	{
		if (certificated == null)
		{
			throw new CryptographicException("Thông tư chứng thư cần khác empty và null.");
		}
		cert = new X509Certificate2();
		cert.Import(certificated);
		ValidateCert();
	}

	private string GetHashAlgorithmName()
	{
		if (cert.SignatureAlgorithm.FriendlyName.ToUpper().Contains("MD5"))
		{
			return HashAlgorithmName.MD5.ToString();
		}
		if (cert.SignatureAlgorithm.FriendlyName.ToUpper().Contains("SHA1"))
		{
			return HashAlgorithmName.SHA1.ToString();
		}
		if (cert.SignatureAlgorithm.FriendlyName.ToUpper().Contains("SHA256RSA"))
		{
			return HashAlgorithmName.SHA256.ToString();
		}
		return string.Empty;
	}

	private HashAlgorithm GetHashAlgorithm(HashAlgorithmName name)
	{
		if (1 == 0)
		{
		}
		HashAlgorithm result = name switch
		{
			HashAlgorithmName.MD5 => new MD5CryptoServiceProvider(), 
			HashAlgorithmName.SHA1 => new SHA1Managed(), 
			HashAlgorithmName.SHA256 => new SHA256Managed(), 
			HashAlgorithmName.SHA384 => new SHA384Managed(), 
			HashAlgorithmName.SHA512 => new SHA512Managed(), 
			_ => throw new CryptographicException("Unknown hash algorithm!"), 
		};
		if (1 == 0)
		{
		}
		return result;
	}

	private HashAlgorithm GetHashAlgorithm()
	{
		if (cert.SignatureAlgorithm.FriendlyName.ToUpper().Contains("MD5"))
		{
			return GetHashAlgorithm(HashAlgorithmName.MD5);
		}
		if (cert.SignatureAlgorithm.FriendlyName.ToUpper().Contains("SHA1"))
		{
			return GetHashAlgorithm(HashAlgorithmName.SHA1);
		}
		if (cert.SignatureAlgorithm.FriendlyName.ToUpper().Contains("SHA256"))
		{
			return GetHashAlgorithm(HashAlgorithmName.SHA256);
		}
		if (cert.SignatureAlgorithm.FriendlyName.ToUpper().Contains("SHA256"))
		{
			return GetHashAlgorithm(HashAlgorithmName.SHA384);
		}
		if (cert.SignatureAlgorithm.FriendlyName.ToUpper().Contains("SHA256"))
		{
			return GetHashAlgorithm(HashAlgorithmName.SHA512);
		}
		throw new CryptographicException("Unknown hash algorithm!");
	}

	public string SignHash(string data)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(data);
		HashAlgorithm hashAlgorithm = GetHashAlgorithm();
		byte[] inArray = SignHash(hashAlgorithm.ComputeHash(bytes));
		return Convert.ToBase64String(inArray);
	}

	public byte[] SignHash(byte[] data)
	{
		if (!cert.HasPrivateKey)
		{
			throw new CryptographicException("Không có khóa bí mật trong Certificate!");
		}
		RSACryptoServiceProvider rSACryptoServiceProvider = cert.PrivateKey as RSACryptoServiceProvider;
		return rSACryptoServiceProvider.SignHash(data, CryptoConfig.MapNameToOID(GetHashAlgorithmName()));
	}

	public bool VerifyHash(byte[] data, byte[] sign)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = cert.PublicKey.Key as RSACryptoServiceProvider;
		return rSACryptoServiceProvider.VerifyHash(data, CryptoConfig.MapNameToOID(GetHashAlgorithmName()), sign);
	}

	public bool VerifyHash(string data, string sign)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(data);
		HashAlgorithm hashAlgorithm = GetHashAlgorithm();
		byte[] array = null;
		try
		{
			array = Convert.FromBase64String(sign);
		}
		catch (Exception inner)
		{
			throw new CryptographicException("Dữ liệu chữ kí không đúng định dạng. Có thể chứ kí đã bị thay đổi.", inner);
		}
		return VerifyHash(hashAlgorithm.ComputeHash(bytes), array);
	}

	public string Encrypt(string data)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(data);
		byte[] inArray = Encrypt(bytes);
		return Convert.ToBase64String(inArray);
	}

	public byte[] Encrypt(byte[] data)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = cert.PublicKey.Key as RSACryptoServiceProvider;
		return rSACryptoServiceProvider.Encrypt(data, fOAEP: false);
	}

	public string Decrypt(string data)
	{
		if (!cert.HasPrivateKey)
		{
			throw new CryptographicException("Không có khóa bí mật trong Certificate!");
		}
		byte[] array = null;
		try
		{
			array = Convert.FromBase64String(data);
		}
		catch (Exception inner)
		{
			throw new CryptographicException("Dữ liệu chữ kí không đúng định dạng. Có thể chứ kí đã bị thay đổi.", inner);
		}
		byte[] bytes = Decrypt(array);
		return Encoding.UTF8.GetString(bytes);
	}

	public byte[] Decrypt(byte[] data)
	{
		RSACryptoServiceProvider rSACryptoServiceProvider = cert.PrivateKey as RSACryptoServiceProvider;
		return rSACryptoServiceProvider.Decrypt(data, fOAEP: false);
	}

	private void ValidateCert()
	{
		DateTime now = DateTime.Now;
		if (now > NotAfter || now < NotBefore)
		{
			throw new CryptographicException("Certificate không còn giá trị để sử dụng");
		}
	}
}
