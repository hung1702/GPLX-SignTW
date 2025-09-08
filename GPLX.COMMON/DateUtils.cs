using System;
using System.Globalization;
using System.Windows.Forms;

namespace GPLX.COMMON;

public class DateUtils
{
	public static string InitDate(DateTimePicker datetime)
	{
		string text = "";
		if (datetime.Value.Day.ToString().Length < 2)
		{
			if (datetime.Value.Month.ToString().Length < 2)
			{
				return Convert.ToString("0" + datetime.Value.Day + "/0" + datetime.Value.Month + "/" + datetime.Value.Year);
			}
			return Convert.ToString("0" + datetime.Value.Day + "/" + datetime.Value.Month + "/" + datetime.Value.Year);
		}
		if (datetime.Value.Month.ToString().Length < 2)
		{
			return Convert.ToString(datetime.Value.Day + "/0" + datetime.Value.Month + "/" + datetime.Value.Year);
		}
		return Convert.ToString(datetime.Value.Day + "/" + datetime.Value.Month + "/" + datetime.Value.Year);
	}

	public static bool ValidDate(MaskedTextBox inputdate)
	{
		string text = inputdate.Text.Trim();
		string text2 = text.Replace("/", "").Trim();
		switch (text2.Length)
		{
		case 1:
			if (int.Parse(text2) > 3)
			{
				return false;
			}
			break;
		case 2:
			if (int.Parse(text2.Substring(0, 1)) == 3 && int.Parse(text2.Substring(1, 1)) > 1)
			{
				return false;
			}
			break;
		case 3:
			if (int.Parse(text2.Substring(2, 1)) > 1)
			{
				return false;
			}
			break;
		case 4:
			if (int.Parse(text2.Substring(2, 1)) == 1 && int.Parse(text2.Substring(3, 1)) > 2)
			{
				return false;
			}
			if (int.Parse(text2.Substring(0, 1)) == 0 && int.Parse(text2.Substring(3, 1)) > 2)
			{
				return false;
			}
			break;
		case 5:
			if (int.Parse(text2.Substring(4, 1)) < 1)
			{
				return false;
			}
			break;
		case 6:
			if (int.Parse(text2.Substring(4, 1)) == 1 && int.Parse(text2.Substring(5, 1)) < 9)
			{
				return false;
			}
			break;
		}
		if (text2.Length == 4)
		{
			switch (text2.Substring(2, 2))
			{
			case "02":
				if (int.Parse(text2.Substring(0, 2)) > 29)
				{
					return false;
				}
				break;
			case "04":
			case "06":
			case "09":
			case "11":
				if (int.Parse(text2.Substring(0, 2)) > 30)
				{
					return false;
				}
				break;
			}
		}
		if (text.Equals("/  /"))
		{
			return true;
		}
		if (!DateTime.TryParseExact(text, "dd/MM/yyyy", null, DateTimeStyles.None, out var _))
		{
			return false;
		}
		return true;
	}
}
