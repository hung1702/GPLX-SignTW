using System;

namespace GPLX.COMMON;

public class Null
{
	private const string NULL_DATE = "12:00:00 AM";

	public static DateTime MinDate => DateTime.MinValue;

	public static DateTime MaxDate => DateTime.MaxValue;

	public static byte NullByte => 0;

	public static short NullShort => short.MinValue;

	public static int NullInteger => int.MinValue;

	public static long NullLong => long.MinValue;

	public static float NullSingle => float.MinValue;

	public static double NullDouble => double.MinValue;

	public static decimal NullDecimal => decimal.MinValue;

	public static DateTime NullDate => DateTime.MinValue;

	public static string NullString => "";

	public static bool NullBoolean => false;

	public static Guid NullGuid => Guid.Empty;
}
