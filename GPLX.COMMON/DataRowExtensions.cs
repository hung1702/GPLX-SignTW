using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace GPLX.COMMON;

public static class DataRowExtensions
{
	public static T Cast<T>(this DataRow dataRow) where T : new()
	{
		T val = new T();
		IEnumerable<PropertyInfo> source = from x in val.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public)
			where x.CanWrite
			select x;
		foreach (DataColumn column in dataRow.Table.Columns)
		{
			if (dataRow[column] == DBNull.Value)
			{
				continue;
			}
			PropertyInfo propertyInfo = source.FirstOrDefault((PropertyInfo x) => column.ColumnName.Equals(x.Name, StringComparison.OrdinalIgnoreCase));
			if (!(propertyInfo == null))
			{
				try
				{
					Type conversionType = Nullable.GetUnderlyingType(propertyInfo.PropertyType) ?? propertyInfo.PropertyType;
					object value = ((dataRow[column] == null) ? null : Convert.ChangeType(dataRow[column], conversionType));
					propertyInfo.SetValue(val, value, null);
				}
				catch
				{
					throw new Exception($"The value '{dataRow[column]}' cannot be mapped to the property '{propertyInfo.Name}'!");
				}
			}
		}
		return val;
	}
}
