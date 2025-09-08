using System;
using System.Security.Cryptography;
using System.Xml;

namespace GPLX_Sign.Cryptography;

public class XmlCryptographyData
{
	private XmlDocument doc = null;

	public string FilePath { get; set; }

	public RSACryptography RSA { get; set; }

	public void Sign()
	{
		try
		{
			doc = new XmlDocument();
			doc.Load(FilePath);
		}
		catch (Exception inner)
		{
			throw new CryptographicException("File dữ liệu không đúng địng dạng hoặc đường dẫn " + FilePath + " không tồn tại.", inner);
		}
		XmlNode signtureNode = GetSigntureNode();
		if (signtureNode != null)
		{
			throw new CryptographicException("Đã tồn tại chữ kí số trong file " + FilePath);
		}
		string innerXml = doc.DocumentElement.InnerXml;
		if (RSA == null)
		{
			throw new CryptographicException("Thông tin kí số RSACryptography chưa được khởi tạo. ");
		}
		string data = RSA.SignHash(innerXml);
		string rawData = RSA.RawData;
		XmlNode newChild = CreateSigntureNode(data, rawData);
		doc.DocumentElement.AppendChild(newChild);
		doc.Save(FilePath);
	}

	public bool Verify()
	{
		try
		{
			doc = new XmlDocument();
			doc.Load(FilePath);
		}
		catch (Exception inner)
		{
			throw new CryptographicException("File dữ liệu không đúng địng dạng hoặc đường dẫn " + FilePath + " không tồn tại.", inner);
		}
		XmlNode signtureNode = GetSigntureNode();
		if (signtureNode == null)
		{
			throw new CryptographicException("Không tìm thấy thông tin chứng thư.");
		}
		string empty = string.Empty;
		string empty2 = string.Empty;
		try
		{
			empty = signtureNode.SelectSingleNode("Data").InnerText;
			empty2 = signtureNode.SelectSingleNode("Cert").InnerText;
		}
		catch (Exception inner2)
		{
			throw new CryptographicException("Thông tin chứng thư không hợp lệ.", inner2);
		}
		doc.DocumentElement.RemoveChild(signtureNode);
		string innerXml = doc.DocumentElement.InnerXml;
		RSA = new RSACryptography(empty2);
		return RSA.VerifyHash(innerXml, empty);
	}

	private XmlNode CreateSigntureNode(string data, string cert)
	{
		string format = "<Signature>\r\n                            <Data>{0}</Data>\r\n                            <Cert>{1}</Cert>\r\n                           </Signature>";
		format = string.Format(format, data, cert);
		XmlDocument xmlDocument = new XmlDocument();
		xmlDocument.LoadXml(format);
		return doc.ImportNode(xmlDocument.DocumentElement, deep: true);
	}

	private XmlNode GetSigntureNode()
	{
		return doc.DocumentElement.SelectSingleNode("./Signature");
	}
}
