using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using GPLX_Sign.Properties;

namespace GPLX_Sign.GPLX_TWDataSetTableAdapters;

[DesignerCategory("code")]
[ToolboxItem(true)]
[DataObject(true)]
[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
[HelpKeyword("vs.data.TableAdapter")]
public class DM_DonViGTVTTableAdapter : Component
{
	private SqlDataAdapter _adapter;

	private SqlConnection _connection;

	private SqlTransaction _transaction;

	private SqlCommand[] _commandCollection;

	private bool _clearBeforeFill;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected internal SqlDataAdapter Adapter
	{
		get
		{
			if (_adapter == null)
			{
				InitAdapter();
			}
			return _adapter;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	internal SqlConnection Connection
	{
		get
		{
			if (_connection == null)
			{
				InitConnection();
			}
			return _connection;
		}
		set
		{
			_connection = value;
			if (Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Connection = value;
			}
			if (Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Connection = value;
			}
			if (Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Connection = value;
			}
			for (int i = 0; i < CommandCollection.Length; i++)
			{
				if (CommandCollection[i] != null)
				{
					CommandCollection[i].Connection = value;
				}
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	internal SqlTransaction Transaction
	{
		get
		{
			return _transaction;
		}
		set
		{
			_transaction = value;
			for (int i = 0; i < CommandCollection.Length; i++)
			{
				CommandCollection[i].Transaction = _transaction;
			}
			if (Adapter != null && Adapter.DeleteCommand != null)
			{
				Adapter.DeleteCommand.Transaction = _transaction;
			}
			if (Adapter != null && Adapter.InsertCommand != null)
			{
				Adapter.InsertCommand.Transaction = _transaction;
			}
			if (Adapter != null && Adapter.UpdateCommand != null)
			{
				Adapter.UpdateCommand.Transaction = _transaction;
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected SqlCommand[] CommandCollection
	{
		get
		{
			if (_commandCollection == null)
			{
				InitCommandCollection();
			}
			return _commandCollection;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public bool ClearBeforeFill
	{
		get
		{
			return _clearBeforeFill;
		}
		set
		{
			_clearBeforeFill = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public DM_DonViGTVTTableAdapter()
	{
		ClearBeforeFill = true;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void InitAdapter()
	{
		_adapter = new SqlDataAdapter();
		DataTableMapping dataTableMapping = new DataTableMapping();
		dataTableMapping.SourceTable = "Table";
		dataTableMapping.DataSetTable = "DM_DonViGTVT";
		dataTableMapping.ColumnMappings.Add("MaDV", "MaDV");
		dataTableMapping.ColumnMappings.Add("LoaiDV", "LoaiDV");
		dataTableMapping.ColumnMappings.Add("TenDV", "TenDV");
		_adapter.TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[DM_DonViGTVT] WHERE (([MaDV] = @Original_MaDV) AND ([LoaiDV] = @Original_LoaiDV) AND ((@IsNull_TenDV = 1 AND [TenDV] IS NULL) OR ([TenDV] = @Original_TenDV)))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MaDV", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaDV", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_LoaiDV", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "LoaiDV", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@IsNull_TenDV", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "TenDV", DataRowVersion.Original, sourceColumnNullMapping: true, null, "", "", ""));
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TenDV", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "TenDV", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [dbo].[DM_DonViGTVT] SET [MaDV] = @MaDV, [LoaiDV] = @LoaiDV, [TenDV] = @TenDV WHERE (([MaDV] = @Original_MaDV) AND ([LoaiDV] = @Original_LoaiDV) AND ((@IsNull_TenDV = 1 AND [TenDV] IS NULL) OR ([TenDV] = @Original_TenDV)));\r\nSELECT MaDV, LoaiDV, TenDV FROM DM_DonViGTVT WHERE (MaDV = @MaDV)";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MaDV", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaDV", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@LoaiDV", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "LoaiDV", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TenDV", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "TenDV", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MaDV", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaDV", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_LoaiDV", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "LoaiDV", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@IsNull_TenDV", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "TenDV", DataRowVersion.Original, sourceColumnNullMapping: true, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TenDV", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "TenDV", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void InitConnection()
	{
		_connection = new SqlConnection();
		_connection.ConnectionString = Settings.Default.GPLX_TWConnectionString;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void InitCommandCollection()
	{
		_commandCollection = new SqlCommand[1];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT MaDV, LoaiDV, TenDV FROM dbo.DM_DonViGTVT WHERE LoaiDV = 'SO'";
		_commandCollection[0].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(GPLX_TWDataSet.DM_DonViGTVTDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[0];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, true)]
	public virtual GPLX_TWDataSet.DM_DonViGTVTDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		GPLX_TWDataSet.DM_DonViGTVTDataTable dM_DonViGTVTDataTable = new GPLX_TWDataSet.DM_DonViGTVTDataTable();
		Adapter.Fill(dM_DonViGTVTDataTable);
		return dM_DonViGTVTDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(GPLX_TWDataSet.DM_DonViGTVTDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(GPLX_TWDataSet dataSet)
	{
		return Adapter.Update(dataSet, "DM_DonViGTVT");
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataRow dataRow)
	{
		return Adapter.Update(new DataRow[1] { dataRow });
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(DataRow[] dataRows)
	{
		return Adapter.Update(dataRows);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Delete, true)]
	public virtual int Delete(string Original_MaDV, string Original_LoaiDV, string Original_TenDV)
	{
		if (Original_MaDV == null)
		{
			throw new ArgumentNullException("Original_MaDV");
		}
		Adapter.DeleteCommand.Parameters[0].Value = Original_MaDV;
		if (Original_LoaiDV == null)
		{
			throw new ArgumentNullException("Original_LoaiDV");
		}
		Adapter.DeleteCommand.Parameters[1].Value = Original_LoaiDV;
		if (Original_TenDV == null)
		{
			Adapter.DeleteCommand.Parameters[2].Value = 1;
			Adapter.DeleteCommand.Parameters[3].Value = DBNull.Value;
		}
		else
		{
			Adapter.DeleteCommand.Parameters[2].Value = 0;
			Adapter.DeleteCommand.Parameters[3].Value = Original_TenDV;
		}
		ConnectionState state = Adapter.DeleteCommand.Connection.State;
		if ((Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.DeleteCommand.Connection.Open();
		}
		try
		{
			return Adapter.DeleteCommand.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.DeleteCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(string MaDV, string LoaiDV, string TenDV, string Original_MaDV, string Original_LoaiDV, string Original_TenDV)
	{
		if (MaDV == null)
		{
			throw new ArgumentNullException("MaDV");
		}
		Adapter.UpdateCommand.Parameters[0].Value = MaDV;
		if (LoaiDV == null)
		{
			throw new ArgumentNullException("LoaiDV");
		}
		Adapter.UpdateCommand.Parameters[1].Value = LoaiDV;
		if (TenDV == null)
		{
			Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[2].Value = TenDV;
		}
		if (Original_MaDV == null)
		{
			throw new ArgumentNullException("Original_MaDV");
		}
		Adapter.UpdateCommand.Parameters[3].Value = Original_MaDV;
		if (Original_LoaiDV == null)
		{
			throw new ArgumentNullException("Original_LoaiDV");
		}
		Adapter.UpdateCommand.Parameters[4].Value = Original_LoaiDV;
		if (Original_TenDV == null)
		{
			Adapter.UpdateCommand.Parameters[5].Value = 1;
			Adapter.UpdateCommand.Parameters[6].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[5].Value = 0;
			Adapter.UpdateCommand.Parameters[6].Value = Original_TenDV;
		}
		ConnectionState state = Adapter.UpdateCommand.Connection.State;
		if ((Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.UpdateCommand.Connection.Open();
		}
		try
		{
			return Adapter.UpdateCommand.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.UpdateCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(string LoaiDV, string TenDV, string Original_MaDV, string Original_LoaiDV, string Original_TenDV)
	{
		return Update(Original_MaDV, LoaiDV, TenDV, Original_MaDV, Original_LoaiDV, Original_TenDV);
	}
}
