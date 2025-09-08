using System;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GPLX.COMMON;

public class Utils
{
	public enum FormMode
	{
		Add = 1,
		Edit,
		View
	}

	public enum MessType
	{
		Error,
		Susses,
		Warning
	}

	private struct FormField
	{
		public string FieldName;

		public string ControlType;

		public string ControlName;

		public int DataLength;

		public inputDataType DataType;

		public bool Required;

		public object MaxValue;
	}

	public enum inputDataType
	{
		Text_Data,
		Date_Data,
		Time_Data,
		Integer_Data,
		SignInteger,
		Decimal_Data
	}

	public const string CST_NGAY_THANG_NAM = "dd/MM/yyyy";

	private const string CST_TEXT_BOX = "TextBox";

	private const string CST_CHECK_BOX = "CheckBox";

	private const string CST_COMBO_BOX = "ComboBox";

	private const string CST_RADIO_BUTTON = "RadioButton";

	private const string CST_AUTOCOMPLETE_TEXTBOX = "AutoCompleteTextBox";

	private const string CST_DATETIME_PICKER = "DateTimePicker";

	private const string CST_NUMERIC_TEXTBOX = "NumericTextBox";

	private const string CST_LABEL = "Label";

	private const string CST_MARSKED_TEXT_BOX = "MaskedTextBox";

	private const string CST_MASKED_TEXT_BOX_EXT = "MaskedTextBoxExt";

	private const string CST_DATETIME_PICKER_EXT = "DateTimePickerEx";

	public const string _edit = "EDIT";

	public const string _save = "SAVE";

	public static string GetConstring(string key)
	{
		try
		{
			Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			return configuration.ConnectionStrings.ConnectionStrings[key].ConnectionString;
		}
		catch
		{
			return string.Empty;
		}
	}

	public static bool ChangeConstrings(string strConstring, string key)
	{
		try
		{
			Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
			ConnectionStringsSection connectionStrings = configuration.ConnectionStrings;
			configuration.ConnectionStrings.ConnectionStrings[key].ConnectionString = strConstring;
			configuration.Save(ConfigurationSaveMode.Modified, forceSaveAll: true);
			ConfigurationManager.RefreshSection(configuration.ConnectionStrings.SectionInformation.SectionName);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public static Control FindControlRecursive(Control root, string id)
	{
		if (root.Name == id)
		{
			return root;
		}
		foreach (Control control2 in root.Controls)
		{
			Control control = FindControlRecursive(control2, id);
			if (control != null)
			{
				return control;
			}
		}
		return null;
	}

	public static byte[] Encrypt(string publickey, byte[] encrypted)
	{
		CspParameters cspParameters = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		byte[] array = null;
		try
		{
			cspParameters = new CspParameters();
			cspParameters.ProviderType = 1;
			rSACryptoServiceProvider = new RSACryptoServiceProvider(cspParameters);
			rSACryptoServiceProvider.FromXmlString(publickey);
			return rSACryptoServiceProvider.Encrypt(encrypted, fOAEP: false);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string Encrypt(string password)
	{
		try
		{
			byte[] encrypted = ConvertPasswordToByte(password);
			byte[] inArray = Encrypt("<RSAKeyValue><Modulus>lcDIE9z4TWy3FzL7Ae1Un5pq20Xhp8zoeFooDp3jZud5TMfPXMKyALwS4ctOtyfBAMD/Talj1mTLZzMfaKA5KsQzhNKFAskNrKGGUh8TEiCx/1/ur3esgSF4+whJELMvnyurvogZ1paA0u2dSaO/ov7rLmOp10MNjz5y7SW8wkk=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>", encrypted);
			return Convert.ToBase64String(inArray);
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static string Decrypt(string stringDecrypt)
	{
		try
		{
			byte[] decrypted = Convert.FromBase64String(stringDecrypt);
			byte[] arrByte = Decrypt("<RSAKeyValue><Modulus>lcDIE9z4TWy3FzL7Ae1Un5pq20Xhp8zoeFooDp3jZud5TMfPXMKyALwS4ctOtyfBAMD/Talj1mTLZzMfaKA5KsQzhNKFAskNrKGGUh8TEiCx/1/ur3esgSF4+whJELMvnyurvogZ1paA0u2dSaO/ov7rLmOp10MNjz5y7SW8wkk=</Modulus><Exponent>AQAB</Exponent><P>xpPj7FSsq9nXCtBv2252xIyM+Sr5s+AzAhxrdhOF77d0hBurr6DRtS7weIXHKH/jM+fnZIo47w/QUX197K1ppw==</P><Q>wQ6MuM1Sgq1Q7ntn6LBe6NNgK6xQwIekp2OgDH8BspoxLNvaC/E3vmWAexmFtEpYyorCCZ/T76htST2bAScSjw==</Q><DP>waqCY37BWGkAHP/j17IICvC4nFmZZiCGHszw0RuBSKU28ZC7BHJnk7jPtftinND9GSZWuetEU4KsvI0TPrxxiQ==</DP><DQ>XjYpei3IrDjEG/1hEe6wAlLUxbtLlQkc0wsNGcwJGg2hHdEUMWu/1kxWTLyBwR/fAMiCNIwosvWwj2Ne90sIBQ==</DQ><InverseQ>VxF87dPsDH5Lfy4dhfwm1ooirNHtMssqtMERjznW3spJJ3CP9MEu94/LiyBYNaXg0znMLASjjdEsjboSKKraaA==</InverseQ><D>BvsQmJRxYrKRqlwvBTz59+Kr3oLYbQkJQSr6uQu1IQPjTKf3y5wrzgr2Wl4u0izhO1bDz+v4gnL6ZFomuarWX0y6epVPC0j1wlNRPojk37iEd+MXSRco6Tl1ejzicGs/3bRRmGA4aGCbYknUBCeGIwILnC8RgO7CZ2bZV+QvSK0=</D></RSAKeyValue>", decrypted);
			return ConvertPasswordToString(arrByte);
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static byte[] Decrypt(string privatekey, byte[] decrypted)
	{
		CspParameters cspParameters = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		byte[] array = null;
		try
		{
			cspParameters = new CspParameters();
			cspParameters.ProviderType = 1;
			rSACryptoServiceProvider = new RSACryptoServiceProvider(cspParameters);
			rSACryptoServiceProvider.FromXmlString(privatekey);
			return rSACryptoServiceProvider.Decrypt(decrypted, fOAEP: false);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static byte[] ConvertPasswordToByte(string s)
	{
		try
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			return unicodeEncoding.GetBytes(s);
		}
		catch (Exception)
		{
			return new byte[0];
		}
	}

	public static string ConvertPasswordToString(byte[] arrByte)
	{
		try
		{
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			return unicodeEncoding.GetString(arrByte);
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static int ConvertStringToPageSize(string pagesize)
	{
		try
		{
			return int.Parse(pagesize);
		}
		catch
		{
			return 20;
		}
	}

	public static int ConvertStringToPageIndex(string pageindex)
	{
		try
		{
			return int.Parse(pageindex);
		}
		catch
		{
			return 1;
		}
	}

	public static string ConvertTongSoBanGhiToString(object obj)
	{
		try
		{
			return obj.ToString();
		}
		catch
		{
			return "0";
		}
	}

	public static string[] PageList(int pagesize, int pageTal)
	{
		int num = pageTal % pagesize;
		if (pageTal == 0)
		{
			num = 1;
		}
		if (num != 0)
		{
			num = 1;
		}
		int num2 = pageTal / pagesize + num;
		string[] array = new string[num2];
		for (int i = 0; i < num2; i++)
		{
			array[i] = (i + 1).ToString();
		}
		return array;
	}

	public static string EncodeTo64(string toEncode)
	{
		byte[] bytes = Encoding.Unicode.GetBytes(toEncode);
		return Convert.ToBase64String(bytes);
	}

	public static string DecodeFrom64(string encodedData)
	{
		byte[] bytes = Convert.FromBase64String(encodedData);
		return Encoding.Unicode.GetString(bytes);
	}
}
