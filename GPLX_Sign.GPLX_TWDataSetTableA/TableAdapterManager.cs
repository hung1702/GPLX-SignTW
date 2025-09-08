#define DEBUG
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;

namespace GPLX_Sign.GPLX_TWDataSetTableAdapters;

[DesignerCategory("code")]
[ToolboxItem(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapterManager")]
public class TableAdapterManager : Component
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public enum UpdateOrderOption
	{
		InsertUpdateDelete,
		UpdateInsertDelete
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private class SelfReferenceComparer : IComparer<DataRow>
	{
		private DataRelation _relation;

		private int _childFirst;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal SelfReferenceComparer(DataRelation relation, bool childFirst)
		{
			_relation = relation;
			if (childFirst)
			{
				_childFirst = -1;
			}
			else
			{
				_childFirst = 1;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private DataRow GetRoot(DataRow row, out int distance)
		{
			Debug.Assert(row != null);
			DataRow result = row;
			distance = 0;
			IDictionary<DataRow, DataRow> dictionary = new Dictionary<DataRow, DataRow>();
			dictionary[row] = row;
			DataRow parentRow = row.GetParentRow(_relation, DataRowVersion.Default);
			while (parentRow != null && !dictionary.ContainsKey(parentRow))
			{
				distance++;
				result = parentRow;
				dictionary[parentRow] = parentRow;
				parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Default);
			}
			if (distance == 0)
			{
				dictionary.Clear();
				dictionary[row] = row;
				parentRow = row.GetParentRow(_relation, DataRowVersion.Original);
				while (parentRow != null && !dictionary.ContainsKey(parentRow))
				{
					distance++;
					result = parentRow;
					dictionary[parentRow] = parentRow;
					parentRow = parentRow.GetParentRow(_relation, DataRowVersion.Original);
				}
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public int Compare(DataRow row1, DataRow row2)
		{
			if (row1 == row2)
			{
				return 0;
			}
			if (row1 == null)
			{
				return -1;
			}
			if (row2 == null)
			{
				return 1;
			}
			int distance = 0;
			DataRow root = GetRoot(row1, out distance);
			int distance2 = 0;
			DataRow root2 = GetRoot(row2, out distance2);
			if (root == root2)
			{
				return _childFirst * distance.CompareTo(distance2);
			}
			Debug.Assert(root.Table != null && root2.Table != null);
			if (root.Table.Rows.IndexOf(root) < root2.Table.Rows.IndexOf(root2))
			{
				return -1;
			}
			return 1;
		}
	}

	private UpdateOrderOption _updateOrder;

	private GPLXTableAdapter _gPLXTableAdapter;

	private DM_DonViGTVTTableAdapter _dM_DonViGTVTTableAdapter;

	private bool _backupDataSetBeforeUpdate;

	private IDbConnection _connection;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public UpdateOrderOption UpdateOrder
	{
		get
		{
			return _updateOrder;
		}
		set
		{
			_updateOrder = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public GPLXTableAdapter GPLXTableAdapter
	{
		get
		{
			return _gPLXTableAdapter;
		}
		set
		{
			_gPLXTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
	public DM_DonViGTVTTableAdapter DM_DonViGTVTTableAdapter
	{
		get
		{
			return _dM_DonViGTVTTableAdapter;
		}
		set
		{
			_dM_DonViGTVTTableAdapter = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public bool BackupDataSetBeforeUpdate
	{
		get
		{
			return _backupDataSetBeforeUpdate;
		}
		set
		{
			_backupDataSetBeforeUpdate = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	public IDbConnection Connection
	{
		get
		{
			if (_connection != null)
			{
				return _connection;
			}
			if (_gPLXTableAdapter != null && _gPLXTableAdapter.Connection != null)
			{
				return _gPLXTableAdapter.Connection;
			}
			if (_dM_DonViGTVTTableAdapter != null && _dM_DonViGTVTTableAdapter.Connection != null)
			{
				return _dM_DonViGTVTTableAdapter.Connection;
			}
			return null;
		}
		set
		{
			_connection = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	public int TableAdapterInstanceCount
	{
		get
		{
			int num = 0;
			if (_gPLXTableAdapter != null)
			{
				num++;
			}
			if (_dM_DonViGTVTTableAdapter != null)
			{
				num++;
			}
			return num;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private int UpdateUpdatedRows(GPLX_TWDataSet dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
	{
		int num = 0;
		if (_gPLXTableAdapter != null)
		{
			DataRow[] updatedRows = dataSet.GPLX.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows = GetRealUpdatedRows(updatedRows, allAddedRows);
			if (updatedRows != null && updatedRows.Length != 0)
			{
				num += _gPLXTableAdapter.Update(updatedRows);
				allChangedRows.AddRange(updatedRows);
			}
		}
		if (_dM_DonViGTVTTableAdapter != null)
		{
			DataRow[] updatedRows2 = dataSet.DM_DonViGTVT.Select(null, null, DataViewRowState.ModifiedCurrent);
			updatedRows2 = GetRealUpdatedRows(updatedRows2, allAddedRows);
			if (updatedRows2 != null && updatedRows2.Length != 0)
			{
				num += _dM_DonViGTVTTableAdapter.Update(updatedRows2);
				allChangedRows.AddRange(updatedRows2);
			}
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private int UpdateInsertedRows(GPLX_TWDataSet dataSet, List<DataRow> allAddedRows)
	{
		int num = 0;
		if (_gPLXTableAdapter != null)
		{
			DataRow[] array = dataSet.GPLX.Select(null, null, DataViewRowState.Added);
			if (array != null && array.Length != 0)
			{
				num += _gPLXTableAdapter.Update(array);
				allAddedRows.AddRange(array);
			}
		}
		if (_dM_DonViGTVTTableAdapter != null)
		{
			DataRow[] array2 = dataSet.DM_DonViGTVT.Select(null, null, DataViewRowState.Added);
			if (array2 != null && array2.Length != 0)
			{
				num += _dM_DonViGTVTTableAdapter.Update(array2);
				allAddedRows.AddRange(array2);
			}
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private int UpdateDeletedRows(GPLX_TWDataSet dataSet, List<DataRow> allChangedRows)
	{
		int num = 0;
		if (_dM_DonViGTVTTableAdapter != null)
		{
			DataRow[] array = dataSet.DM_DonViGTVT.Select(null, null, DataViewRowState.Deleted);
			if (array != null && array.Length != 0)
			{
				num += _dM_DonViGTVTTableAdapter.Update(array);
				allChangedRows.AddRange(array);
			}
		}
		if (_gPLXTableAdapter != null)
		{
			DataRow[] array2 = dataSet.GPLX.Select(null, null, DataViewRowState.Deleted);
			if (array2 != null && array2.Length != 0)
			{
				num += _gPLXTableAdapter.Update(array2);
				allChangedRows.AddRange(array2);
			}
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
	{
		if (updatedRows == null || updatedRows.Length < 1)
		{
			return updatedRows;
		}
		if (allAddedRows == null || allAddedRows.Count < 1)
		{
			return updatedRows;
		}
		List<DataRow> list = new List<DataRow>();
		foreach (DataRow item in updatedRows)
		{
			if (!allAddedRows.Contains(item))
			{
				list.Add(item);
			}
		}
		return list.ToArray();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public virtual int UpdateAll(GPLX_TWDataSet dataSet)
	{
		if (dataSet == null)
		{
			throw new ArgumentNullException("dataSet");
		}
		if (!dataSet.HasChanges())
		{
			return 0;
		}
		if (_gPLXTableAdapter != null && !MatchTableAdapterConnection(_gPLXTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		if (_dM_DonViGTVTTableAdapter != null && !MatchTableAdapterConnection(_dM_DonViGTVTTableAdapter.Connection))
		{
			throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
		}
		IDbConnection connection = Connection;
		if (connection == null)
		{
			throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
		}
		bool flag = false;
		if ((connection.State & ConnectionState.Broken) == ConnectionState.Broken)
		{
			connection.Close();
		}
		if (connection.State == ConnectionState.Closed)
		{
			connection.Open();
			flag = true;
		}
		IDbTransaction dbTransaction = connection.BeginTransaction();
		if (dbTransaction == null)
		{
			throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
		}
		List<DataRow> list = new List<DataRow>();
		List<DataRow> list2 = new List<DataRow>();
		List<DataAdapter> list3 = new List<DataAdapter>();
		Dictionary<object, IDbConnection> dictionary = new Dictionary<object, IDbConnection>();
		int num = 0;
		DataSet dataSet2 = null;
		if (BackupDataSetBeforeUpdate)
		{
			dataSet2 = new DataSet();
			dataSet2.Merge(dataSet);
		}
		try
		{
			if (_gPLXTableAdapter != null)
			{
				dictionary.Add(_gPLXTableAdapter, _gPLXTableAdapter.Connection);
				_gPLXTableAdapter.Connection = (SqlConnection)connection;
				_gPLXTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (_gPLXTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_gPLXTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					list3.Add(_gPLXTableAdapter.Adapter);
				}
			}
			if (_dM_DonViGTVTTableAdapter != null)
			{
				dictionary.Add(_dM_DonViGTVTTableAdapter, _dM_DonViGTVTTableAdapter.Connection);
				_dM_DonViGTVTTableAdapter.Connection = (SqlConnection)connection;
				_dM_DonViGTVTTableAdapter.Transaction = (SqlTransaction)dbTransaction;
				if (_dM_DonViGTVTTableAdapter.Adapter.AcceptChangesDuringUpdate)
				{
					_dM_DonViGTVTTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
					list3.Add(_dM_DonViGTVTTableAdapter.Adapter);
				}
			}
			if (UpdateOrder == UpdateOrderOption.UpdateInsertDelete)
			{
				num += UpdateUpdatedRows(dataSet, list, list2);
				num += UpdateInsertedRows(dataSet, list2);
			}
			else
			{
				num += UpdateInsertedRows(dataSet, list2);
				num += UpdateUpdatedRows(dataSet, list, list2);
			}
			num += UpdateDeletedRows(dataSet, list);
			dbTransaction.Commit();
			if (0 < list2.Count)
			{
				DataRow[] array = new DataRow[list2.Count];
				list2.CopyTo(array);
				foreach (DataRow dataRow in array)
				{
					dataRow.AcceptChanges();
				}
			}
			if (0 < list.Count)
			{
				DataRow[] array2 = new DataRow[list.Count];
				list.CopyTo(array2);
				foreach (DataRow dataRow2 in array2)
				{
					dataRow2.AcceptChanges();
				}
			}
		}
		catch (Exception ex)
		{
			dbTransaction.Rollback();
			if (BackupDataSetBeforeUpdate)
			{
				Debug.Assert(dataSet2 != null);
				dataSet.Clear();
				dataSet.Merge(dataSet2);
			}
			else if (0 < list2.Count)
			{
				DataRow[] array3 = new DataRow[list2.Count];
				list2.CopyTo(array3);
				foreach (DataRow dataRow3 in array3)
				{
					dataRow3.AcceptChanges();
					dataRow3.SetAdded();
				}
			}
			throw ex;
		}
		finally
		{
			if (flag)
			{
				connection.Close();
			}
			if (_gPLXTableAdapter != null)
			{
				_gPLXTableAdapter.Connection = (SqlConnection)dictionary[_gPLXTableAdapter];
				_gPLXTableAdapter.Transaction = null;
			}
			if (_dM_DonViGTVTTableAdapter != null)
			{
				_dM_DonViGTVTTableAdapter.Connection = (SqlConnection)dictionary[_dM_DonViGTVTTableAdapter];
				_dM_DonViGTVTTableAdapter.Transaction = null;
			}
			if (0 < list3.Count)
			{
				DataAdapter[] array4 = new DataAdapter[list3.Count];
				list3.CopyTo(array4);
				foreach (DataAdapter dataAdapter in array4)
				{
					dataAdapter.AcceptChangesDuringUpdate = true;
				}
			}
		}
		return num;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
	{
		Array.Sort(rows, new SelfReferenceComparer(relation, childFirst));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
	{
		if (_connection != null)
		{
			return true;
		}
		if (Connection == null || inputConnection == null)
		{
			return true;
		}
		if (string.Equals(Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal))
		{
			return true;
		}
		return false;
	}
}
