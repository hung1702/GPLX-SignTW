using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;

namespace GPLX.COMMON;

public class CollectionHelper
{
	public static DataTable ConvertTo<T>(IList<T> list)
	{
		DataTable dataTable = CreateTable<T>();
		Type typeFromHandle = typeof(T);
		PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeFromHandle);
		foreach (T item in list)
		{
			DataRow dataRow = dataTable.NewRow();
			foreach (PropertyDescriptor item2 in properties)
			{
				dataRow[item2.Name] = item2.GetValue(item);
			}
			dataTable.Rows.Add(dataRow);
		}
		return dataTable;
	}

	public static IList<T> ConvertTo<T>(IList<DataRow> rows)
	{
		IList<T> list = null;
		if (rows != null)
		{
			list = new List<T>();
			foreach (DataRow row in rows)
			{
				T item = CreateItem<T>(row);
				list.Add(item);
			}
		}
		return list;
	}

	public static IList<T> ConvertTo<T>(DataTable table)
	{
		if (table == null)
		{
			return null;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow row in table.Rows)
		{
			list.Add(row);
		}
		return ConvertTo<T>(list);
	}

	public static T CreateItem<T>(DataRow row)
	{
		T val = default(T);
		if (row != null)
		{
			val = Activator.CreateInstance<T>();
			foreach (DataColumn column in row.Table.Columns)
			{
				PropertyInfo property = val.GetType().GetProperty(column.ColumnName);
				try
				{
					object value = row[column.ColumnName];
					property.SetValue(val, value, null);
				}
				catch
				{
					throw;
				}
			}
		}
		return val;
	}

	public static DataTable CreateTable<T>()
	{
		Type typeFromHandle = typeof(T);
		DataTable dataTable = new DataTable(typeFromHandle.Name);
		PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeFromHandle);
		foreach (PropertyDescriptor item in properties)
		{
			dataTable.Columns.Add(item.Name);
		}
		return dataTable;
	}
}
