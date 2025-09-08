using System;

namespace GPLX_Sign.Cryptography;

public class RevocationItem
{
	public string SerialNumber { get; set; }

	public DateTime RevocationDate { get; set; }
}
