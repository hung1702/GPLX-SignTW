using System.Security.Cryptography;

namespace GPLX_Sign.Cryptography;

public class StringCryptography
{
	public RSACryptography RSA { get; set; }

	public string Singed(string data)
	{
		if (RSA == null)
		{
			throw new CryptographicException("Thông tin kí số RSACryptography chưa được khởi tạo. ");
		}
		return RSA.SignHash(data);
	}

	public bool Verify(string data, string signedData)
	{
		if (RSA == null)
		{
			throw new CryptographicException("Thông tin kí số RSACryptography chưa được khởi tạo. ");
		}
		return RSA.VerifyHash(data, signedData);
	}
}
