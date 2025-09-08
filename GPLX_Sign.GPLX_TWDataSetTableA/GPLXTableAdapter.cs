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
public class GPLXTableAdapter : Component
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
	public GPLXTableAdapter()
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
		dataTableMapping.DataSetTable = "GPLX";
		dataTableMapping.ColumnMappings.Add("MaDangKy", "MaDangKy");
		dataTableMapping.ColumnMappings.Add("SoGPLX", "SoGPLX");
		dataTableMapping.ColumnMappings.Add("HangGPLX", "HangGPLX");
		dataTableMapping.ColumnMappings.Add("SoHoSo", "SoHoSo");
		dataTableMapping.ColumnMappings.Add("SoGPLXCu", "SoGPLXCu");
		dataTableMapping.ColumnMappings.Add("NoiCapGPLX", "NoiCapGPLX");
		dataTableMapping.ColumnMappings.Add("NgayCapGPLX", "NgayCapGPLX");
		dataTableMapping.ColumnMappings.Add("CoQuanQLGPLX", "CoQuanQLGPLX");
		dataTableMapping.ColumnMappings.Add("NgayHHGPLX", "NgayHHGPLX");
		dataTableMapping.ColumnMappings.Add("NgayTTGPLX", "NgayTTGPLX");
		dataTableMapping.ColumnMappings.Add("MoTaVN", "MoTaVN");
		dataTableMapping.ColumnMappings.Add("MoTaEN", "MoTaEN");
		dataTableMapping.ColumnMappings.Add("NguoiKy", "NguoiKy");
		dataTableMapping.ColumnMappings.Add("MaHTCap", "MaHTCap");
		dataTableMapping.ColumnMappings.Add("NoiHocGPLX", "NoiHocGPLX");
		dataTableMapping.ColumnMappings.Add("NamHocGPLX", "NamHocGPLX");
		dataTableMapping.ColumnMappings.Add("DuongDanAnh", "DuongDanAnh");
		dataTableMapping.ColumnMappings.Add("HoTenDem", "HoTenDem");
		dataTableMapping.ColumnMappings.Add("TenNLX", "TenNLX");
		dataTableMapping.ColumnMappings.Add("HoVaTen", "HoVaTen");
		dataTableMapping.ColumnMappings.Add("NgaySinh", "NgaySinh");
		dataTableMapping.ColumnMappings.Add("MaQuocTich", "MaQuocTich");
		dataTableMapping.ColumnMappings.Add("NoiCT", "NoiCT");
		dataTableMapping.ColumnMappings.Add("NoiCT_MaDVHC", "NoiCT_MaDVHC");
		dataTableMapping.ColumnMappings.Add("NoiCT_MaDVQL", "NoiCT_MaDVQL");
		dataTableMapping.ColumnMappings.Add("SoCMT", "SoCMT");
		dataTableMapping.ColumnMappings.Add("NgayCapCMT", "NgayCapCMT");
		dataTableMapping.ColumnMappings.Add("NoiCapCMT", "NoiCapCMT");
		dataTableMapping.ColumnMappings.Add("MaViPham", "MaViPham");
		dataTableMapping.ColumnMappings.Add("NgayHHViPham", "NgayHHViPham");
		dataTableMapping.ColumnMappings.Add("NgayBDViPham", "NgayBDViPham");
		dataTableMapping.ColumnMappings.Add("GhiChu", "GhiChu");
		dataTableMapping.ColumnMappings.Add("NguoiTao", "NguoiTao");
		dataTableMapping.ColumnMappings.Add("NguoiSua", "NguoiSua");
		dataTableMapping.ColumnMappings.Add("NgayTao", "NgayTao");
		dataTableMapping.ColumnMappings.Add("NgaySua", "NgaySua");
		dataTableMapping.ColumnMappings.Add("GioiTinh", "GioiTinh");
		dataTableMapping.ColumnMappings.Add("SoSeri", "SoSeri");
		dataTableMapping.ColumnMappings.Add("NgayTT_A1", "NgayTT_A1");
		dataTableMapping.ColumnMappings.Add("NgayTT_A2", "NgayTT_A2");
		dataTableMapping.ColumnMappings.Add("NgayTT_A3", "NgayTT_A3");
		dataTableMapping.ColumnMappings.Add("NgayTT_A4", "NgayTT_A4");
		dataTableMapping.ColumnMappings.Add("NgayTT_B1", "NgayTT_B1");
		dataTableMapping.ColumnMappings.Add("NgayTT_B2", "NgayTT_B2");
		dataTableMapping.ColumnMappings.Add("NgayTT_C", "NgayTT_C");
		dataTableMapping.ColumnMappings.Add("NgayTT_D", "NgayTT_D");
		dataTableMapping.ColumnMappings.Add("NgayTT_E", "NgayTT_E");
		dataTableMapping.ColumnMappings.Add("NgayTT_F", "NgayTT_F");
		dataTableMapping.ColumnMappings.Add("NgayTT_FB2", "NgayTT_FB2");
		dataTableMapping.ColumnMappings.Add("NgayTT_FC", "NgayTT_FC");
		dataTableMapping.ColumnMappings.Add("NgayTT_FD", "NgayTT_FD");
		dataTableMapping.ColumnMappings.Add("NgayTT_FE", "NgayTT_FE");
		dataTableMapping.ColumnMappings.Add("MaLo", "MaLo");
		dataTableMapping.ColumnMappings.Add("SignedData", "SignedData");
		dataTableMapping.ColumnMappings.Add("VerifyKey", "VerifyKey");
		dataTableMapping.ColumnMappings.Add("HangGplxIn", "HangGplxIn");
		dataTableMapping.ColumnMappings.Add("NgayTTIn", "NgayTTIn");
		dataTableMapping.ColumnMappings.Add("ErrorMsg", "ErrorMsg");
		dataTableMapping.ColumnMappings.Add("DateError", "DateError");
		dataTableMapping.ColumnMappings.Add("MaLoaiHoso", "MaLoaiHoso");
		dataTableMapping.ColumnMappings.Add("TinhTP", "TinhTP");
		dataTableMapping.ColumnMappings.Add("NgayTT_B11", "NgayTT_B11");
		dataTableMapping.ColumnMappings.Add("ROW_VERSION", "ROW_VERSION");
		dataTableMapping.ColumnMappings.Add("NgayTT_B12", "NgayTT_B12");
		dataTableMapping.ColumnMappings.Add("NgayTT_B13", "NgayTT_B13");
		dataTableMapping.ColumnMappings.Add("NgayTT_A11", "NgayTT_A11");
		dataTableMapping.ColumnMappings.Add("NgayTT_A12", "NgayTT_A12");
		dataTableMapping.ColumnMappings.Add("SO_CMND_CU", "SO_CMND_CU");
		dataTableMapping.ColumnMappings.Add("NgayTT_B14", "NgayTT_B14");
		dataTableMapping.ColumnMappings.Add("NgayTT_B15", "NgayTT_B15");
		dataTableMapping.ColumnMappings.Add("HoVaTenIn", "HoVaTenIn");
		dataTableMapping.ColumnMappings.Add("NoiTT", "NoiTT");
		dataTableMapping.ColumnMappings.Add("NoiTT_MaDVHC", "NoiTT_MaDVHC");
		dataTableMapping.ColumnMappings.Add("NoiTT_MaDVQL", "NoiTT_MaDVQL");
		_adapter.TableMappings.Add(dataTableMapping);
		_adapter.DeleteCommand = new SqlCommand();
		_adapter.DeleteCommand.Connection = Connection;
		_adapter.DeleteCommand.CommandText = "DELETE FROM [dbo].[GPLX] WHERE (([MaDangKy] = @Original_MaDangKy) AND ([TinhTP] = @Original_TinhTP) AND ([ROW_VERSION] = @Original_ROW_VERSION))";
		_adapter.DeleteCommand.CommandType = CommandType.Text;
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_MaDangKy", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaDangKy", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_TinhTP", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "TinhTP", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.DeleteCommand.Parameters.Add(new SqlParameter("@Original_ROW_VERSION", SqlDbType.Timestamp, 0, ParameterDirection.Input, 0, 0, "ROW_VERSION", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand = new SqlCommand();
		_adapter.InsertCommand.Connection = Connection;
		_adapter.InsertCommand.CommandText = "INSERT INTO [dbo].[GPLX] ([MaDangKy], [SoGPLX], [HangGPLX], [SoHoSo], [SoGPLXCu], [NoiCapGPLX], [NgayCapGPLX], [CoQuanQLGPLX], [NgayHHGPLX], [NgayTTGPLX], [MoTaVN], [MoTaEN], [NguoiKy], [MaHTCap], [NoiHocGPLX], [NamHocGPLX], [DuongDanAnh], [HoTenDem], [TenNLX], [HoVaTen], [NgaySinh], [MaQuocTich], [NoiCT], [NoiCT_MaDVHC], [NoiCT_MaDVQL], [SoCMT], [NgayCapCMT], [NoiCapCMT], [MaViPham], [NgayHHViPham], [NgayBDViPham], [GhiChu], [NguoiTao], [NguoiSua], [NgayTao], [NgaySua], [GioiTinh], [SoSeri], [NgayTT_A1], [NgayTT_A2], [NgayTT_A3], [NgayTT_A4], [NgayTT_B1], [NgayTT_B2], [NgayTT_C], [NgayTT_D], [NgayTT_E], [NgayTT_F], [NgayTT_FB2], [NgayTT_FC], [NgayTT_FD], [NgayTT_FE], [MaLo], [SignedData], [VerifyKey], [HangGplxIn], [NgayTTIn], [ErrorMsg], [DateError], [MaLoaiHoso], [TinhTP], [NgayTT_B11], [NgayTT_B12], [NgayTT_B13], [NgayTT_A11], [NgayTT_A12], [SO_CMND_CU], [NgayTT_B14], [NgayTT_B15], [HoVaTenIn], [NoiTT], [NoiTT_MaDVHC], [NoiTT_MaDVQL]) VALUES (@MaDangKy, @SoGPLX, @HangGPLX, @SoHoSo, @SoGPLXCu, @NoiCapGPLX, @NgayCapGPLX, @CoQuanQLGPLX, @NgayHHGPLX, @NgayTTGPLX, @MoTaVN, @MoTaEN, @NguoiKy, @MaHTCap, @NoiHocGPLX, @NamHocGPLX, @DuongDanAnh, @HoTenDem, @TenNLX, @HoVaTen, @NgaySinh, @MaQuocTich, @NoiCT, @NoiCT_MaDVHC, @NoiCT_MaDVQL, @SoCMT, @NgayCapCMT, @NoiCapCMT, @MaViPham, @NgayHHViPham, @NgayBDViPham, @GhiChu, @NguoiTao, @NguoiSua, @NgayTao, @NgaySua, @GioiTinh, @SoSeri, @NgayTT_A1, @NgayTT_A2, @NgayTT_A3, @NgayTT_A4, @NgayTT_B1, @NgayTT_B2, @NgayTT_C, @NgayTT_D, @NgayTT_E, @NgayTT_F, @NgayTT_FB2, @NgayTT_FC, @NgayTT_FD, @NgayTT_FE, @MaLo, @SignedData, @VerifyKey, @HangGplxIn, @NgayTTIn, @ErrorMsg, @DateError, @MaLoaiHoso, @TinhTP, @NgayTT_B11, @NgayTT_B12, @NgayTT_B13, @NgayTT_A11, @NgayTT_A12, @SO_CMND_CU, @NgayTT_B14, @NgayTT_B15, @HoVaTenIn, @NoiTT, @NoiTT_MaDVHC, @NoiTT_MaDVQL);\r\nSELECT MaDangKy, SoGPLX, HangGPLX, SoHoSo, SoGPLXCu, NoiCapGPLX, NgayCapGPLX, CoQuanQLGPLX, NgayHHGPLX, NgayTTGPLX, MoTaVN, MoTaEN, NguoiKy, MaHTCap, NoiHocGPLX, NamHocGPLX, DuongDanAnh, HoTenDem, TenNLX, HoVaTen, NgaySinh, MaQuocTich, NoiCT, NoiCT_MaDVHC, NoiCT_MaDVQL, SoCMT, NgayCapCMT, NoiCapCMT, MaViPham, NgayHHViPham, NgayBDViPham, GhiChu, NguoiTao, NguoiSua, NgayTao, NgaySua, GioiTinh, SoSeri, NgayTT_A1, NgayTT_A2, NgayTT_A3, NgayTT_A4, NgayTT_B1, NgayTT_B2, NgayTT_C, NgayTT_D, NgayTT_E, NgayTT_F, NgayTT_FB2, NgayTT_FC, NgayTT_FD, NgayTT_FE, MaLo, SignedData, VerifyKey, HangGplxIn, NgayTTIn, ErrorMsg, DateError, MaLoaiHoso, TinhTP, NgayTT_B11, ROW_VERSION, NgayTT_B12, NgayTT_B13, NgayTT_A11, NgayTT_A12, SO_CMND_CU, NgayTT_B14, NgayTT_B15, HoVaTenIn, NoiTT, NoiTT_MaDVHC, NoiTT_MaDVQL FROM GPLX WHERE (MaDangKy = @MaDangKy) AND (TinhTP = @TinhTP)";
		_adapter.InsertCommand.CommandType = CommandType.Text;
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MaDangKy", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaDangKy", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SoGPLX", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SoGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@HangGPLX", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "HangGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SoHoSo", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SoHoSo", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SoGPLXCu", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SoGPLXCu", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoiCapGPLX", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NoiCapGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayCapGPLX", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayCapGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@CoQuanQLGPLX", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "CoQuanQLGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayHHGPLX", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayHHGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTTGPLX", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTTGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MoTaVN", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "MoTaVN", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MoTaEN", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "MoTaEN", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NguoiKy", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NguoiKy", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MaHTCap", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaHTCap", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoiHocGPLX", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NoiHocGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NamHocGPLX", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "NamHocGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DuongDanAnh", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "DuongDanAnh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@HoTenDem", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "HoTenDem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@TenNLX", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "TenNLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@HoVaTen", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "HoVaTen", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NgaySinh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MaQuocTich", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaQuocTich", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoiCT", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoiCT", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoiCT_MaDVHC", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NoiCT_MaDVHC", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoiCT_MaDVQL", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NoiCT_MaDVQL", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SoCMT", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SoCMT", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayCapCMT", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayCapCMT", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoiCapCMT", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoiCapCMT", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MaViPham", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "MaViPham", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayHHViPham", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayHHViPham", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayBDViPham", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayBDViPham", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@GhiChu", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "GhiChu", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NguoiTao", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NguoiTao", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NguoiSua", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NguoiSua", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTao", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTao", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgaySua", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgaySua", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@GioiTinh", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "GioiTinh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SoSeri", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SoSeri", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_A1", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A1", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_A2", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A2", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_A3", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A3", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_A4", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A4", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_B1", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B1", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_B2", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B2", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_C", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_C", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_D", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_D", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_E", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_E", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_F", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_F", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_FB2", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_FB2", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_FC", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_FC", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_FD", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_FD", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_FE", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_FE", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MaLo", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaLo", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SignedData", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SignedData", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@VerifyKey", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "VerifyKey", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@HangGplxIn", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "HangGplxIn", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTTIn", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NgayTTIn", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@ErrorMsg", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ErrorMsg", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@DateError", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "DateError", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@MaLoaiHoso", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "MaLoaiHoso", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@TinhTP", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "TinhTP", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_B11", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B11", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_B12", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B12", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_B13", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B13", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_A11", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A11", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_A12", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A12", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@SO_CMND_CU", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SO_CMND_CU", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_B14", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B14", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NgayTT_B15", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B15", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@HoVaTenIn", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "HoVaTenIn", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoiTT", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoiTT", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoiTT_MaDVHC", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoiTT_MaDVHC", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.InsertCommand.Parameters.Add(new SqlParameter("@NoiTT_MaDVQL", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NoiTT_MaDVQL", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand = new SqlCommand();
		_adapter.UpdateCommand.Connection = Connection;
		_adapter.UpdateCommand.CommandText = "UPDATE [dbo].[GPLX] SET [MaDangKy] = @MaDangKy, [SoGPLX] = @SoGPLX, [HangGPLX] = @HangGPLX, [SoHoSo] = @SoHoSo, [SoGPLXCu] = @SoGPLXCu, [NoiCapGPLX] = @NoiCapGPLX, [NgayCapGPLX] = @NgayCapGPLX, [CoQuanQLGPLX] = @CoQuanQLGPLX, [NgayHHGPLX] = @NgayHHGPLX, [NgayTTGPLX] = @NgayTTGPLX, [MoTaVN] = @MoTaVN, [MoTaEN] = @MoTaEN, [NguoiKy] = @NguoiKy, [MaHTCap] = @MaHTCap, [NoiHocGPLX] = @NoiHocGPLX, [NamHocGPLX] = @NamHocGPLX, [DuongDanAnh] = @DuongDanAnh, [HoTenDem] = @HoTenDem, [TenNLX] = @TenNLX, [HoVaTen] = @HoVaTen, [NgaySinh] = @NgaySinh, [MaQuocTich] = @MaQuocTich, [NoiCT] = @NoiCT, [NoiCT_MaDVHC] = @NoiCT_MaDVHC, [NoiCT_MaDVQL] = @NoiCT_MaDVQL, [SoCMT] = @SoCMT, [NgayCapCMT] = @NgayCapCMT, [NoiCapCMT] = @NoiCapCMT, [MaViPham] = @MaViPham, [NgayHHViPham] = @NgayHHViPham, [NgayBDViPham] = @NgayBDViPham, [GhiChu] = @GhiChu, [NguoiTao] = @NguoiTao, [NguoiSua] = @NguoiSua, [NgayTao] = @NgayTao, [NgaySua] = @NgaySua, [GioiTinh] = @GioiTinh, [SoSeri] = @SoSeri, [NgayTT_A1] = @NgayTT_A1, [NgayTT_A2] = @NgayTT_A2, [NgayTT_A3] = @NgayTT_A3, [NgayTT_A4] = @NgayTT_A4, [NgayTT_B1] = @NgayTT_B1, [NgayTT_B2] = @NgayTT_B2, [NgayTT_C] = @NgayTT_C, [NgayTT_D] = @NgayTT_D, [NgayTT_E] = @NgayTT_E, [NgayTT_F] = @NgayTT_F, [NgayTT_FB2] = @NgayTT_FB2, [NgayTT_FC] = @NgayTT_FC, [NgayTT_FD] = @NgayTT_FD, [NgayTT_FE] = @NgayTT_FE, [MaLo] = @MaLo, [SignedData] = @SignedData, [VerifyKey] = @VerifyKey, [HangGplxIn] = @HangGplxIn, [NgayTTIn] = @NgayTTIn, [ErrorMsg] = @ErrorMsg, [DateError] = @DateError, [MaLoaiHoso] = @MaLoaiHoso, [TinhTP] = @TinhTP, [NgayTT_B11] = @NgayTT_B11, [NgayTT_B12] = @NgayTT_B12, [NgayTT_B13] = @NgayTT_B13, [NgayTT_A11] = @NgayTT_A11, [NgayTT_A12] = @NgayTT_A12, [SO_CMND_CU] = @SO_CMND_CU, [NgayTT_B14] = @NgayTT_B14, [NgayTT_B15] = @NgayTT_B15, [HoVaTenIn] = @HoVaTenIn, [NoiTT] = @NoiTT, [NoiTT_MaDVHC] = @NoiTT_MaDVHC, [NoiTT_MaDVQL] = @NoiTT_MaDVQL WHERE (([MaDangKy] = @Original_MaDangKy) AND ([TinhTP] = @Original_TinhTP) AND ([ROW_VERSION] = @Original_ROW_VERSION));\r\nSELECT MaDangKy, SoGPLX, HangGPLX, SoHoSo, SoGPLXCu, NoiCapGPLX, NgayCapGPLX, CoQuanQLGPLX, NgayHHGPLX, NgayTTGPLX, MoTaVN, MoTaEN, NguoiKy, MaHTCap, NoiHocGPLX, NamHocGPLX, DuongDanAnh, HoTenDem, TenNLX, HoVaTen, NgaySinh, MaQuocTich, NoiCT, NoiCT_MaDVHC, NoiCT_MaDVQL, SoCMT, NgayCapCMT, NoiCapCMT, MaViPham, NgayHHViPham, NgayBDViPham, GhiChu, NguoiTao, NguoiSua, NgayTao, NgaySua, GioiTinh, SoSeri, NgayTT_A1, NgayTT_A2, NgayTT_A3, NgayTT_A4, NgayTT_B1, NgayTT_B2, NgayTT_C, NgayTT_D, NgayTT_E, NgayTT_F, NgayTT_FB2, NgayTT_FC, NgayTT_FD, NgayTT_FE, MaLo, SignedData, VerifyKey, HangGplxIn, NgayTTIn, ErrorMsg, DateError, MaLoaiHoso, TinhTP, NgayTT_B11, ROW_VERSION, NgayTT_B12, NgayTT_B13, NgayTT_A11, NgayTT_A12, SO_CMND_CU, NgayTT_B14, NgayTT_B15, HoVaTenIn, NoiTT, NoiTT_MaDVHC, NoiTT_MaDVQL FROM GPLX WHERE (MaDangKy = @MaDangKy) AND (TinhTP = @TinhTP)";
		_adapter.UpdateCommand.CommandType = CommandType.Text;
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MaDangKy", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaDangKy", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SoGPLX", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SoGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HangGPLX", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "HangGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SoHoSo", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SoHoSo", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SoGPLXCu", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SoGPLXCu", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoiCapGPLX", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NoiCapGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayCapGPLX", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayCapGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@CoQuanQLGPLX", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "CoQuanQLGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayHHGPLX", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayHHGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTTGPLX", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTTGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MoTaVN", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "MoTaVN", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MoTaEN", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "MoTaEN", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NguoiKy", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NguoiKy", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MaHTCap", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaHTCap", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoiHocGPLX", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NoiHocGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NamHocGPLX", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "NamHocGPLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DuongDanAnh", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "DuongDanAnh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HoTenDem", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "HoTenDem", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TenNLX", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "TenNLX", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HoVaTen", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "HoVaTen", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgaySinh", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NgaySinh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MaQuocTich", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaQuocTich", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoiCT", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoiCT", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoiCT_MaDVHC", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NoiCT_MaDVHC", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoiCT_MaDVQL", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NoiCT_MaDVQL", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SoCMT", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SoCMT", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayCapCMT", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayCapCMT", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoiCapCMT", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoiCapCMT", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MaViPham", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "MaViPham", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayHHViPham", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayHHViPham", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayBDViPham", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayBDViPham", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GhiChu", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "GhiChu", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NguoiTao", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NguoiTao", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NguoiSua", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NguoiSua", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTao", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTao", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgaySua", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgaySua", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@GioiTinh", SqlDbType.Char, 0, ParameterDirection.Input, 0, 0, "GioiTinh", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SoSeri", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SoSeri", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_A1", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A1", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_A2", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A2", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_A3", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A3", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_A4", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A4", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_B1", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B1", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_B2", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B2", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_C", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_C", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_D", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_D", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_E", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_E", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_F", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_F", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_FB2", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_FB2", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_FC", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_FC", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_FD", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_FD", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_FE", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_FE", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MaLo", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaLo", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SignedData", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SignedData", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@VerifyKey", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "VerifyKey", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HangGplxIn", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "HangGplxIn", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTTIn", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NgayTTIn", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@ErrorMsg", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "ErrorMsg", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@DateError", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "DateError", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@MaLoaiHoso", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "MaLoaiHoso", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@TinhTP", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "TinhTP", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_B11", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B11", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_B12", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B12", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_B13", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B13", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_A11", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A11", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_A12", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_A12", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@SO_CMND_CU", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "SO_CMND_CU", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_B14", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B14", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NgayTT_B15", SqlDbType.DateTime, 0, ParameterDirection.Input, 0, 0, "NgayTT_B15", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@HoVaTenIn", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "HoVaTenIn", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoiTT", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoiTT", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoiTT_MaDVHC", SqlDbType.NVarChar, 0, ParameterDirection.Input, 0, 0, "NoiTT_MaDVHC", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@NoiTT_MaDVQL", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "NoiTT_MaDVQL", DataRowVersion.Current, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_MaDangKy", SqlDbType.VarChar, 0, ParameterDirection.Input, 0, 0, "MaDangKy", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_TinhTP", SqlDbType.Int, 0, ParameterDirection.Input, 0, 0, "TinhTP", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
		_adapter.UpdateCommand.Parameters.Add(new SqlParameter("@Original_ROW_VERSION", SqlDbType.Timestamp, 0, ParameterDirection.Input, 0, 0, "ROW_VERSION", DataRowVersion.Original, sourceColumnNullMapping: false, null, "", "", ""));
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
		_commandCollection = new SqlCommand[2];
		_commandCollection[0] = new SqlCommand();
		_commandCollection[0].Connection = Connection;
		_commandCollection[0].CommandText = "SELECT MaDangKy, SoGPLX, HangGPLX, SoHoSo, SoGPLXCu, NoiCapGPLX, NgayCapGPLX, CoQuanQLGPLX, NgayHHGPLX, NgayTTGPLX, MoTaVN, MoTaEN, NguoiKy, MaHTCap, NoiHocGPLX, NamHocGPLX, DuongDanAnh, HoTenDem, TenNLX, HoVaTen, NgaySinh, MaQuocTich, NoiCT, NoiCT_MaDVHC, NoiCT_MaDVQL, SoCMT, NgayCapCMT, NoiCapCMT, MaViPham, NgayHHViPham, NgayBDViPham, GhiChu, NguoiTao, NguoiSua, NgayTao, NgaySua, GioiTinh, SoSeri, NgayTT_A1, NgayTT_A2, NgayTT_A3, NgayTT_A4, NgayTT_B1, NgayTT_B2, NgayTT_C, NgayTT_D, NgayTT_E, NgayTT_F, NgayTT_FB2, NgayTT_FC, NgayTT_FD, NgayTT_FE, MaLo, SignedData, VerifyKey, HangGplxIn, NgayTTIn, ErrorMsg, DateError, MaLoaiHoso, TinhTP, NgayTT_B11, ROW_VERSION, NgayTT_B12, NgayTT_B13, NgayTT_A11, NgayTT_A12, SO_CMND_CU, NgayTT_B14, NgayTT_B15, HoVaTenIn, NoiTT, NoiTT_MaDVHC, NoiTT_MaDVQL FROM dbo.GPLX";
		_commandCollection[0].CommandType = CommandType.Text;
		_commandCollection[1] = new SqlCommand();
		_commandCollection[1].Connection = Connection;
		_commandCollection[1].CommandText = "SELECT MaDangKy, SoGPLX, HangGPLX, SoHoSo, SoGPLXCu, NoiCapGPLX, NgayCapGPLX, CoQuanQLGPLX, NgayHHGPLX, NgayTTGPLX, MoTaVN, MoTaEN, NguoiKy, MaHTCap, NoiHocGPLX, NamHocGPLX, DuongDanAnh, HoTenDem, TenNLX, HoVaTen, NgaySinh, MaQuocTich, NoiCT, NoiCT_MaDVHC, NoiCT_MaDVQL, SoCMT, NgayCapCMT, NoiCapCMT, MaViPham, NgayHHViPham, NgayBDViPham, GhiChu, NguoiTao, NguoiSua, NgayTao, NgaySua, GioiTinh, SoSeri, NgayTT_A1, NgayTT_A2, NgayTT_A3, NgayTT_A4, NgayTT_B1, NgayTT_B2, NgayTT_C, NgayTT_D, NgayTT_E, NgayTT_F, NgayTT_FB2, NgayTT_FC, NgayTT_FD, NgayTT_FE, MaLo, SignedData, VerifyKey, HangGplxIn, NgayTTIn, ErrorMsg, DateError, MaLoaiHoso, TinhTP, NgayTT_B11, ROW_VERSION, NgayTT_B12, NgayTT_B13, NgayTT_A11, NgayTT_A12, SO_CMND_CU, NgayTT_B14, NgayTT_B15, HoVaTenIn, NoiTT, NoiTT_MaDVHC, NoiTT_MaDVQL FROM dbo.GPLX\r\nWHERE SignedData IS NULL AND VerifyKey IS NULL AND NgayTao >= '2025-03-01 00:00:00.000'";
		_commandCollection[1].CommandType = CommandType.Text;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, true)]
	public virtual int Fill(GPLX_TWDataSet.GPLXDataTable dataTable)
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
	public virtual GPLX_TWDataSet.GPLXDataTable GetData()
	{
		Adapter.SelectCommand = CommandCollection[0];
		GPLX_TWDataSet.GPLXDataTable gPLXDataTable = new GPLX_TWDataSet.GPLXDataTable();
		Adapter.Fill(gPLXDataTable);
		return gPLXDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Fill, false)]
	public virtual int FillBy(GPLX_TWDataSet.GPLXDataTable dataTable)
	{
		Adapter.SelectCommand = CommandCollection[1];
		if (ClearBeforeFill)
		{
			dataTable.Clear();
		}
		return Adapter.Fill(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Select, false)]
	public virtual GPLX_TWDataSet.GPLXDataTable GetDataBy()
	{
		Adapter.SelectCommand = CommandCollection[1];
		GPLX_TWDataSet.GPLXDataTable gPLXDataTable = new GPLX_TWDataSet.GPLXDataTable();
		Adapter.Fill(gPLXDataTable);
		return gPLXDataTable;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(GPLX_TWDataSet.GPLXDataTable dataTable)
	{
		return Adapter.Update(dataTable);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	public virtual int Update(GPLX_TWDataSet dataSet)
	{
		return Adapter.Update(dataSet, "GPLX");
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
	public virtual int Delete(string Original_MaDangKy, int Original_TinhTP, byte[] Original_ROW_VERSION)
	{
		if (Original_MaDangKy == null)
		{
			throw new ArgumentNullException("Original_MaDangKy");
		}
		Adapter.DeleteCommand.Parameters[0].Value = Original_MaDangKy;
		Adapter.DeleteCommand.Parameters[1].Value = Original_TinhTP;
		if (Original_ROW_VERSION == null)
		{
			throw new ArgumentNullException("Original_ROW_VERSION");
		}
		Adapter.DeleteCommand.Parameters[2].Value = Original_ROW_VERSION;
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
	[DataObjectMethod(DataObjectMethodType.Insert, true)]
	public virtual int Insert(string MaDangKy, string SoGPLX, string HangGPLX, string SoHoSo, string SoGPLXCu, string NoiCapGPLX, DateTime NgayCapGPLX, string CoQuanQLGPLX, DateTime? NgayHHGPLX, DateTime NgayTTGPLX, string MoTaVN, string MoTaEN, string NguoiKy, string MaHTCap, string NoiHocGPLX, int? NamHocGPLX, string DuongDanAnh, string HoTenDem, string TenNLX, string HoVaTen, string NgaySinh, string MaQuocTich, string NoiCT, string NoiCT_MaDVHC, string NoiCT_MaDVQL, string SoCMT, DateTime? NgayCapCMT, string NoiCapCMT, int? MaViPham, DateTime? NgayHHViPham, DateTime? NgayBDViPham, string GhiChu, string NguoiTao, string NguoiSua, DateTime NgayTao, DateTime NgaySua, string GioiTinh, string SoSeri, DateTime? NgayTT_A1, DateTime? NgayTT_A2, DateTime? NgayTT_A3, DateTime? NgayTT_A4, DateTime? NgayTT_B1, DateTime? NgayTT_B2, DateTime? NgayTT_C, DateTime? NgayTT_D, DateTime? NgayTT_E, DateTime? NgayTT_F, DateTime? NgayTT_FB2, DateTime? NgayTT_FC, DateTime? NgayTT_FD, DateTime? NgayTT_FE, string MaLo, string SignedData, string VerifyKey, string HangGplxIn, string NgayTTIn, string ErrorMsg, DateTime? DateError, string MaLoaiHoso, int TinhTP, DateTime? NgayTT_B11, DateTime? NgayTT_B12, DateTime? NgayTT_B13, DateTime? NgayTT_A11, DateTime? NgayTT_A12, string SO_CMND_CU, DateTime? NgayTT_B14, DateTime? NgayTT_B15, string HoVaTenIn, string NoiTT, string NoiTT_MaDVHC, string NoiTT_MaDVQL)
	{
		if (MaDangKy == null)
		{
			throw new ArgumentNullException("MaDangKy");
		}
		Adapter.InsertCommand.Parameters[0].Value = MaDangKy;
		if (SoGPLX == null)
		{
			throw new ArgumentNullException("SoGPLX");
		}
		Adapter.InsertCommand.Parameters[1].Value = SoGPLX;
		if (HangGPLX == null)
		{
			throw new ArgumentNullException("HangGPLX");
		}
		Adapter.InsertCommand.Parameters[2].Value = HangGPLX;
		if (SoHoSo == null)
		{
			throw new ArgumentNullException("SoHoSo");
		}
		Adapter.InsertCommand.Parameters[3].Value = SoHoSo;
		if (SoGPLXCu == null)
		{
			Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[4].Value = SoGPLXCu;
		}
		if (NoiCapGPLX == null)
		{
			throw new ArgumentNullException("NoiCapGPLX");
		}
		Adapter.InsertCommand.Parameters[5].Value = NoiCapGPLX;
		Adapter.InsertCommand.Parameters[6].Value = NgayCapGPLX;
		if (CoQuanQLGPLX == null)
		{
			throw new ArgumentNullException("CoQuanQLGPLX");
		}
		Adapter.InsertCommand.Parameters[7].Value = CoQuanQLGPLX;
		if (NgayHHGPLX.HasValue)
		{
			Adapter.InsertCommand.Parameters[8].Value = NgayHHGPLX.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
		}
		Adapter.InsertCommand.Parameters[9].Value = NgayTTGPLX;
		if (MoTaVN == null)
		{
			throw new ArgumentNullException("MoTaVN");
		}
		Adapter.InsertCommand.Parameters[10].Value = MoTaVN;
		if (MoTaEN == null)
		{
			throw new ArgumentNullException("MoTaEN");
		}
		Adapter.InsertCommand.Parameters[11].Value = MoTaEN;
		if (NguoiKy == null)
		{
			Adapter.InsertCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[12].Value = NguoiKy;
		}
		if (MaHTCap == null)
		{
			throw new ArgumentNullException("MaHTCap");
		}
		Adapter.InsertCommand.Parameters[13].Value = MaHTCap;
		if (NoiHocGPLX == null)
		{
			Adapter.InsertCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[14].Value = NoiHocGPLX;
		}
		if (NamHocGPLX.HasValue)
		{
			Adapter.InsertCommand.Parameters[15].Value = NamHocGPLX.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[15].Value = DBNull.Value;
		}
		if (DuongDanAnh == null)
		{
			Adapter.InsertCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[16].Value = DuongDanAnh;
		}
		if (HoTenDem == null)
		{
			throw new ArgumentNullException("HoTenDem");
		}
		Adapter.InsertCommand.Parameters[17].Value = HoTenDem;
		if (TenNLX == null)
		{
			throw new ArgumentNullException("TenNLX");
		}
		Adapter.InsertCommand.Parameters[18].Value = TenNLX;
		if (HoVaTen == null)
		{
			throw new ArgumentNullException("HoVaTen");
		}
		Adapter.InsertCommand.Parameters[19].Value = HoVaTen;
		if (NgaySinh == null)
		{
			throw new ArgumentNullException("NgaySinh");
		}
		Adapter.InsertCommand.Parameters[20].Value = NgaySinh;
		if (MaQuocTich == null)
		{
			throw new ArgumentNullException("MaQuocTich");
		}
		Adapter.InsertCommand.Parameters[21].Value = MaQuocTich;
		if (NoiCT == null)
		{
			Adapter.InsertCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[22].Value = NoiCT;
		}
		if (NoiCT_MaDVHC == null)
		{
			Adapter.InsertCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[23].Value = NoiCT_MaDVHC;
		}
		if (NoiCT_MaDVQL == null)
		{
			Adapter.InsertCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[24].Value = NoiCT_MaDVQL;
		}
		if (SoCMT == null)
		{
			throw new ArgumentNullException("SoCMT");
		}
		Adapter.InsertCommand.Parameters[25].Value = SoCMT;
		if (NgayCapCMT.HasValue)
		{
			Adapter.InsertCommand.Parameters[26].Value = NgayCapCMT.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[26].Value = DBNull.Value;
		}
		if (NoiCapCMT == null)
		{
			Adapter.InsertCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[27].Value = NoiCapCMT;
		}
		if (MaViPham.HasValue)
		{
			Adapter.InsertCommand.Parameters[28].Value = MaViPham.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[28].Value = DBNull.Value;
		}
		if (NgayHHViPham.HasValue)
		{
			Adapter.InsertCommand.Parameters[29].Value = NgayHHViPham.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[29].Value = DBNull.Value;
		}
		if (NgayBDViPham.HasValue)
		{
			Adapter.InsertCommand.Parameters[30].Value = NgayBDViPham.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[30].Value = DBNull.Value;
		}
		if (GhiChu == null)
		{
			Adapter.InsertCommand.Parameters[31].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[31].Value = GhiChu;
		}
		if (NguoiTao == null)
		{
			Adapter.InsertCommand.Parameters[32].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[32].Value = NguoiTao;
		}
		if (NguoiSua == null)
		{
			Adapter.InsertCommand.Parameters[33].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[33].Value = NguoiSua;
		}
		Adapter.InsertCommand.Parameters[34].Value = NgayTao;
		Adapter.InsertCommand.Parameters[35].Value = NgaySua;
		if (GioiTinh == null)
		{
			Adapter.InsertCommand.Parameters[36].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[36].Value = GioiTinh;
		}
		if (SoSeri == null)
		{
			Adapter.InsertCommand.Parameters[37].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[37].Value = SoSeri;
		}
		if (NgayTT_A1.HasValue)
		{
			Adapter.InsertCommand.Parameters[38].Value = NgayTT_A1.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[38].Value = DBNull.Value;
		}
		if (NgayTT_A2.HasValue)
		{
			Adapter.InsertCommand.Parameters[39].Value = NgayTT_A2.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[39].Value = DBNull.Value;
		}
		if (NgayTT_A3.HasValue)
		{
			Adapter.InsertCommand.Parameters[40].Value = NgayTT_A3.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[40].Value = DBNull.Value;
		}
		if (NgayTT_A4.HasValue)
		{
			Adapter.InsertCommand.Parameters[41].Value = NgayTT_A4.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[41].Value = DBNull.Value;
		}
		if (NgayTT_B1.HasValue)
		{
			Adapter.InsertCommand.Parameters[42].Value = NgayTT_B1.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[42].Value = DBNull.Value;
		}
		if (NgayTT_B2.HasValue)
		{
			Adapter.InsertCommand.Parameters[43].Value = NgayTT_B2.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[43].Value = DBNull.Value;
		}
		if (NgayTT_C.HasValue)
		{
			Adapter.InsertCommand.Parameters[44].Value = NgayTT_C.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[44].Value = DBNull.Value;
		}
		if (NgayTT_D.HasValue)
		{
			Adapter.InsertCommand.Parameters[45].Value = NgayTT_D.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[45].Value = DBNull.Value;
		}
		if (NgayTT_E.HasValue)
		{
			Adapter.InsertCommand.Parameters[46].Value = NgayTT_E.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[46].Value = DBNull.Value;
		}
		if (NgayTT_F.HasValue)
		{
			Adapter.InsertCommand.Parameters[47].Value = NgayTT_F.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[47].Value = DBNull.Value;
		}
		if (NgayTT_FB2.HasValue)
		{
			Adapter.InsertCommand.Parameters[48].Value = NgayTT_FB2.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[48].Value = DBNull.Value;
		}
		if (NgayTT_FC.HasValue)
		{
			Adapter.InsertCommand.Parameters[49].Value = NgayTT_FC.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[49].Value = DBNull.Value;
		}
		if (NgayTT_FD.HasValue)
		{
			Adapter.InsertCommand.Parameters[50].Value = NgayTT_FD.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[50].Value = DBNull.Value;
		}
		if (NgayTT_FE.HasValue)
		{
			Adapter.InsertCommand.Parameters[51].Value = NgayTT_FE.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[51].Value = DBNull.Value;
		}
		if (MaLo == null)
		{
			Adapter.InsertCommand.Parameters[52].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[52].Value = MaLo;
		}
		if (SignedData == null)
		{
			Adapter.InsertCommand.Parameters[53].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[53].Value = SignedData;
		}
		if (VerifyKey == null)
		{
			Adapter.InsertCommand.Parameters[54].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[54].Value = VerifyKey;
		}
		if (HangGplxIn == null)
		{
			Adapter.InsertCommand.Parameters[55].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[55].Value = HangGplxIn;
		}
		if (NgayTTIn == null)
		{
			Adapter.InsertCommand.Parameters[56].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[56].Value = NgayTTIn;
		}
		if (ErrorMsg == null)
		{
			Adapter.InsertCommand.Parameters[57].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[57].Value = ErrorMsg;
		}
		if (DateError.HasValue)
		{
			Adapter.InsertCommand.Parameters[58].Value = DateError.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[58].Value = DBNull.Value;
		}
		if (MaLoaiHoso == null)
		{
			Adapter.InsertCommand.Parameters[59].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[59].Value = MaLoaiHoso;
		}
		Adapter.InsertCommand.Parameters[60].Value = TinhTP;
		if (NgayTT_B11.HasValue)
		{
			Adapter.InsertCommand.Parameters[61].Value = NgayTT_B11.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[61].Value = DBNull.Value;
		}
		if (NgayTT_B12.HasValue)
		{
			Adapter.InsertCommand.Parameters[62].Value = NgayTT_B12.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[62].Value = DBNull.Value;
		}
		if (NgayTT_B13.HasValue)
		{
			Adapter.InsertCommand.Parameters[63].Value = NgayTT_B13.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[63].Value = DBNull.Value;
		}
		if (NgayTT_A11.HasValue)
		{
			Adapter.InsertCommand.Parameters[64].Value = NgayTT_A11.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[64].Value = DBNull.Value;
		}
		if (NgayTT_A12.HasValue)
		{
			Adapter.InsertCommand.Parameters[65].Value = NgayTT_A12.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[65].Value = DBNull.Value;
		}
		if (SO_CMND_CU == null)
		{
			Adapter.InsertCommand.Parameters[66].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[66].Value = SO_CMND_CU;
		}
		if (NgayTT_B14.HasValue)
		{
			Adapter.InsertCommand.Parameters[67].Value = NgayTT_B14.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[67].Value = DBNull.Value;
		}
		if (NgayTT_B15.HasValue)
		{
			Adapter.InsertCommand.Parameters[68].Value = NgayTT_B15.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[68].Value = DBNull.Value;
		}
		if (HoVaTenIn == null)
		{
			Adapter.InsertCommand.Parameters[69].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[69].Value = HoVaTenIn;
		}
		if (NoiTT == null)
		{
			Adapter.InsertCommand.Parameters[70].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[70].Value = NoiTT;
		}
		if (NoiTT_MaDVHC == null)
		{
			Adapter.InsertCommand.Parameters[71].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[71].Value = NoiTT_MaDVHC;
		}
		if (NoiTT_MaDVQL == null)
		{
			Adapter.InsertCommand.Parameters[72].Value = DBNull.Value;
		}
		else
		{
			Adapter.InsertCommand.Parameters[72].Value = NoiTT_MaDVQL;
		}
		ConnectionState state = Adapter.InsertCommand.Connection.State;
		if ((Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
		{
			Adapter.InsertCommand.Connection.Open();
		}
		try
		{
			return Adapter.InsertCommand.ExecuteNonQuery();
		}
		finally
		{
			if (state == ConnectionState.Closed)
			{
				Adapter.InsertCommand.Connection.Close();
			}
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[HelpKeyword("vs.data.TableAdapter")]
	[DataObjectMethod(DataObjectMethodType.Update, true)]
	public virtual int Update(string MaDangKy, string SoGPLX, string HangGPLX, string SoHoSo, string SoGPLXCu, string NoiCapGPLX, DateTime NgayCapGPLX, string CoQuanQLGPLX, DateTime? NgayHHGPLX, DateTime NgayTTGPLX, string MoTaVN, string MoTaEN, string NguoiKy, string MaHTCap, string NoiHocGPLX, int? NamHocGPLX, string DuongDanAnh, string HoTenDem, string TenNLX, string HoVaTen, string NgaySinh, string MaQuocTich, string NoiCT, string NoiCT_MaDVHC, string NoiCT_MaDVQL, string SoCMT, DateTime? NgayCapCMT, string NoiCapCMT, int? MaViPham, DateTime? NgayHHViPham, DateTime? NgayBDViPham, string GhiChu, string NguoiTao, string NguoiSua, DateTime NgayTao, DateTime NgaySua, string GioiTinh, string SoSeri, DateTime? NgayTT_A1, DateTime? NgayTT_A2, DateTime? NgayTT_A3, DateTime? NgayTT_A4, DateTime? NgayTT_B1, DateTime? NgayTT_B2, DateTime? NgayTT_C, DateTime? NgayTT_D, DateTime? NgayTT_E, DateTime? NgayTT_F, DateTime? NgayTT_FB2, DateTime? NgayTT_FC, DateTime? NgayTT_FD, DateTime? NgayTT_FE, string MaLo, string SignedData, string VerifyKey, string HangGplxIn, string NgayTTIn, string ErrorMsg, DateTime? DateError, string MaLoaiHoso, int TinhTP, DateTime? NgayTT_B11, DateTime? NgayTT_B12, DateTime? NgayTT_B13, DateTime? NgayTT_A11, DateTime? NgayTT_A12, string SO_CMND_CU, DateTime? NgayTT_B14, DateTime? NgayTT_B15, string HoVaTenIn, string NoiTT, string NoiTT_MaDVHC, string NoiTT_MaDVQL, string Original_MaDangKy, int Original_TinhTP, byte[] Original_ROW_VERSION)
	{
		if (MaDangKy == null)
		{
			throw new ArgumentNullException("MaDangKy");
		}
		Adapter.UpdateCommand.Parameters[0].Value = MaDangKy;
		if (SoGPLX == null)
		{
			throw new ArgumentNullException("SoGPLX");
		}
		Adapter.UpdateCommand.Parameters[1].Value = SoGPLX;
		if (HangGPLX == null)
		{
			throw new ArgumentNullException("HangGPLX");
		}
		Adapter.UpdateCommand.Parameters[2].Value = HangGPLX;
		if (SoHoSo == null)
		{
			throw new ArgumentNullException("SoHoSo");
		}
		Adapter.UpdateCommand.Parameters[3].Value = SoHoSo;
		if (SoGPLXCu == null)
		{
			Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[4].Value = SoGPLXCu;
		}
		if (NoiCapGPLX == null)
		{
			throw new ArgumentNullException("NoiCapGPLX");
		}
		Adapter.UpdateCommand.Parameters[5].Value = NoiCapGPLX;
		Adapter.UpdateCommand.Parameters[6].Value = NgayCapGPLX;
		if (CoQuanQLGPLX == null)
		{
			throw new ArgumentNullException("CoQuanQLGPLX");
		}
		Adapter.UpdateCommand.Parameters[7].Value = CoQuanQLGPLX;
		if (NgayHHGPLX.HasValue)
		{
			Adapter.UpdateCommand.Parameters[8].Value = NgayHHGPLX.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
		}
		Adapter.UpdateCommand.Parameters[9].Value = NgayTTGPLX;
		if (MoTaVN == null)
		{
			throw new ArgumentNullException("MoTaVN");
		}
		Adapter.UpdateCommand.Parameters[10].Value = MoTaVN;
		if (MoTaEN == null)
		{
			throw new ArgumentNullException("MoTaEN");
		}
		Adapter.UpdateCommand.Parameters[11].Value = MoTaEN;
		if (NguoiKy == null)
		{
			Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[12].Value = NguoiKy;
		}
		if (MaHTCap == null)
		{
			throw new ArgumentNullException("MaHTCap");
		}
		Adapter.UpdateCommand.Parameters[13].Value = MaHTCap;
		if (NoiHocGPLX == null)
		{
			Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[14].Value = NoiHocGPLX;
		}
		if (NamHocGPLX.HasValue)
		{
			Adapter.UpdateCommand.Parameters[15].Value = NamHocGPLX.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[15].Value = DBNull.Value;
		}
		if (DuongDanAnh == null)
		{
			Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[16].Value = DuongDanAnh;
		}
		if (HoTenDem == null)
		{
			throw new ArgumentNullException("HoTenDem");
		}
		Adapter.UpdateCommand.Parameters[17].Value = HoTenDem;
		if (TenNLX == null)
		{
			throw new ArgumentNullException("TenNLX");
		}
		Adapter.UpdateCommand.Parameters[18].Value = TenNLX;
		if (HoVaTen == null)
		{
			throw new ArgumentNullException("HoVaTen");
		}
		Adapter.UpdateCommand.Parameters[19].Value = HoVaTen;
		if (NgaySinh == null)
		{
			throw new ArgumentNullException("NgaySinh");
		}
		Adapter.UpdateCommand.Parameters[20].Value = NgaySinh;
		if (MaQuocTich == null)
		{
			throw new ArgumentNullException("MaQuocTich");
		}
		Adapter.UpdateCommand.Parameters[21].Value = MaQuocTich;
		if (NoiCT == null)
		{
			Adapter.UpdateCommand.Parameters[22].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[22].Value = NoiCT;
		}
		if (NoiCT_MaDVHC == null)
		{
			Adapter.UpdateCommand.Parameters[23].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[23].Value = NoiCT_MaDVHC;
		}
		if (NoiCT_MaDVQL == null)
		{
			Adapter.UpdateCommand.Parameters[24].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[24].Value = NoiCT_MaDVQL;
		}
		if (SoCMT == null)
		{
			throw new ArgumentNullException("SoCMT");
		}
		Adapter.UpdateCommand.Parameters[25].Value = SoCMT;
		if (NgayCapCMT.HasValue)
		{
			Adapter.UpdateCommand.Parameters[26].Value = NgayCapCMT.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[26].Value = DBNull.Value;
		}
		if (NoiCapCMT == null)
		{
			Adapter.UpdateCommand.Parameters[27].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[27].Value = NoiCapCMT;
		}
		if (MaViPham.HasValue)
		{
			Adapter.UpdateCommand.Parameters[28].Value = MaViPham.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[28].Value = DBNull.Value;
		}
		if (NgayHHViPham.HasValue)
		{
			Adapter.UpdateCommand.Parameters[29].Value = NgayHHViPham.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[29].Value = DBNull.Value;
		}
		if (NgayBDViPham.HasValue)
		{
			Adapter.UpdateCommand.Parameters[30].Value = NgayBDViPham.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[30].Value = DBNull.Value;
		}
		if (GhiChu == null)
		{
			Adapter.UpdateCommand.Parameters[31].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[31].Value = GhiChu;
		}
		if (NguoiTao == null)
		{
			Adapter.UpdateCommand.Parameters[32].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[32].Value = NguoiTao;
		}
		if (NguoiSua == null)
		{
			Adapter.UpdateCommand.Parameters[33].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[33].Value = NguoiSua;
		}
		Adapter.UpdateCommand.Parameters[34].Value = NgayTao;
		Adapter.UpdateCommand.Parameters[35].Value = NgaySua;
		if (GioiTinh == null)
		{
			Adapter.UpdateCommand.Parameters[36].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[36].Value = GioiTinh;
		}
		if (SoSeri == null)
		{
			Adapter.UpdateCommand.Parameters[37].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[37].Value = SoSeri;
		}
		if (NgayTT_A1.HasValue)
		{
			Adapter.UpdateCommand.Parameters[38].Value = NgayTT_A1.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[38].Value = DBNull.Value;
		}
		if (NgayTT_A2.HasValue)
		{
			Adapter.UpdateCommand.Parameters[39].Value = NgayTT_A2.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[39].Value = DBNull.Value;
		}
		if (NgayTT_A3.HasValue)
		{
			Adapter.UpdateCommand.Parameters[40].Value = NgayTT_A3.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[40].Value = DBNull.Value;
		}
		if (NgayTT_A4.HasValue)
		{
			Adapter.UpdateCommand.Parameters[41].Value = NgayTT_A4.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[41].Value = DBNull.Value;
		}
		if (NgayTT_B1.HasValue)
		{
			Adapter.UpdateCommand.Parameters[42].Value = NgayTT_B1.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[42].Value = DBNull.Value;
		}
		if (NgayTT_B2.HasValue)
		{
			Adapter.UpdateCommand.Parameters[43].Value = NgayTT_B2.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[43].Value = DBNull.Value;
		}
		if (NgayTT_C.HasValue)
		{
			Adapter.UpdateCommand.Parameters[44].Value = NgayTT_C.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[44].Value = DBNull.Value;
		}
		if (NgayTT_D.HasValue)
		{
			Adapter.UpdateCommand.Parameters[45].Value = NgayTT_D.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[45].Value = DBNull.Value;
		}
		if (NgayTT_E.HasValue)
		{
			Adapter.UpdateCommand.Parameters[46].Value = NgayTT_E.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[46].Value = DBNull.Value;
		}
		if (NgayTT_F.HasValue)
		{
			Adapter.UpdateCommand.Parameters[47].Value = NgayTT_F.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[47].Value = DBNull.Value;
		}
		if (NgayTT_FB2.HasValue)
		{
			Adapter.UpdateCommand.Parameters[48].Value = NgayTT_FB2.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[48].Value = DBNull.Value;
		}
		if (NgayTT_FC.HasValue)
		{
			Adapter.UpdateCommand.Parameters[49].Value = NgayTT_FC.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[49].Value = DBNull.Value;
		}
		if (NgayTT_FD.HasValue)
		{
			Adapter.UpdateCommand.Parameters[50].Value = NgayTT_FD.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[50].Value = DBNull.Value;
		}
		if (NgayTT_FE.HasValue)
		{
			Adapter.UpdateCommand.Parameters[51].Value = NgayTT_FE.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[51].Value = DBNull.Value;
		}
		if (MaLo == null)
		{
			Adapter.UpdateCommand.Parameters[52].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[52].Value = MaLo;
		}
		if (SignedData == null)
		{
			Adapter.UpdateCommand.Parameters[53].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[53].Value = SignedData;
		}
		if (VerifyKey == null)
		{
			Adapter.UpdateCommand.Parameters[54].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[54].Value = VerifyKey;
		}
		if (HangGplxIn == null)
		{
			Adapter.UpdateCommand.Parameters[55].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[55].Value = HangGplxIn;
		}
		if (NgayTTIn == null)
		{
			Adapter.UpdateCommand.Parameters[56].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[56].Value = NgayTTIn;
		}
		if (ErrorMsg == null)
		{
			Adapter.UpdateCommand.Parameters[57].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[57].Value = ErrorMsg;
		}
		if (DateError.HasValue)
		{
			Adapter.UpdateCommand.Parameters[58].Value = DateError.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[58].Value = DBNull.Value;
		}
		if (MaLoaiHoso == null)
		{
			Adapter.UpdateCommand.Parameters[59].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[59].Value = MaLoaiHoso;
		}
		Adapter.UpdateCommand.Parameters[60].Value = TinhTP;
		if (NgayTT_B11.HasValue)
		{
			Adapter.UpdateCommand.Parameters[61].Value = NgayTT_B11.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[61].Value = DBNull.Value;
		}
		if (NgayTT_B12.HasValue)
		{
			Adapter.UpdateCommand.Parameters[62].Value = NgayTT_B12.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[62].Value = DBNull.Value;
		}
		if (NgayTT_B13.HasValue)
		{
			Adapter.UpdateCommand.Parameters[63].Value = NgayTT_B13.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[63].Value = DBNull.Value;
		}
		if (NgayTT_A11.HasValue)
		{
			Adapter.UpdateCommand.Parameters[64].Value = NgayTT_A11.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[64].Value = DBNull.Value;
		}
		if (NgayTT_A12.HasValue)
		{
			Adapter.UpdateCommand.Parameters[65].Value = NgayTT_A12.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[65].Value = DBNull.Value;
		}
		if (SO_CMND_CU == null)
		{
			Adapter.UpdateCommand.Parameters[66].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[66].Value = SO_CMND_CU;
		}
		if (NgayTT_B14.HasValue)
		{
			Adapter.UpdateCommand.Parameters[67].Value = NgayTT_B14.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[67].Value = DBNull.Value;
		}
		if (NgayTT_B15.HasValue)
		{
			Adapter.UpdateCommand.Parameters[68].Value = NgayTT_B15.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[68].Value = DBNull.Value;
		}
		if (HoVaTenIn == null)
		{
			Adapter.UpdateCommand.Parameters[69].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[69].Value = HoVaTenIn;
		}
		if (NoiTT == null)
		{
			Adapter.UpdateCommand.Parameters[70].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[70].Value = NoiTT;
		}
		if (NoiTT_MaDVHC == null)
		{
			Adapter.UpdateCommand.Parameters[71].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[71].Value = NoiTT_MaDVHC;
		}
		if (NoiTT_MaDVQL == null)
		{
			Adapter.UpdateCommand.Parameters[72].Value = DBNull.Value;
		}
		else
		{
			Adapter.UpdateCommand.Parameters[72].Value = NoiTT_MaDVQL;
		}
		if (Original_MaDangKy == null)
		{
			throw new ArgumentNullException("Original_MaDangKy");
		}
		Adapter.UpdateCommand.Parameters[73].Value = Original_MaDangKy;
		Adapter.UpdateCommand.Parameters[74].Value = Original_TinhTP;
		if (Original_ROW_VERSION == null)
		{
			throw new ArgumentNullException("Original_ROW_VERSION");
		}
		Adapter.UpdateCommand.Parameters[75].Value = Original_ROW_VERSION;
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
	public virtual int Update(string SoGPLX, string HangGPLX, string SoHoSo, string SoGPLXCu, string NoiCapGPLX, DateTime NgayCapGPLX, string CoQuanQLGPLX, DateTime? NgayHHGPLX, DateTime NgayTTGPLX, string MoTaVN, string MoTaEN, string NguoiKy, string MaHTCap, string NoiHocGPLX, int? NamHocGPLX, string DuongDanAnh, string HoTenDem, string TenNLX, string HoVaTen, string NgaySinh, string MaQuocTich, string NoiCT, string NoiCT_MaDVHC, string NoiCT_MaDVQL, string SoCMT, DateTime? NgayCapCMT, string NoiCapCMT, int? MaViPham, DateTime? NgayHHViPham, DateTime? NgayBDViPham, string GhiChu, string NguoiTao, string NguoiSua, DateTime NgayTao, DateTime NgaySua, string GioiTinh, string SoSeri, DateTime? NgayTT_A1, DateTime? NgayTT_A2, DateTime? NgayTT_A3, DateTime? NgayTT_A4, DateTime? NgayTT_B1, DateTime? NgayTT_B2, DateTime? NgayTT_C, DateTime? NgayTT_D, DateTime? NgayTT_E, DateTime? NgayTT_F, DateTime? NgayTT_FB2, DateTime? NgayTT_FC, DateTime? NgayTT_FD, DateTime? NgayTT_FE, string MaLo, string SignedData, string VerifyKey, string HangGplxIn, string NgayTTIn, string ErrorMsg, DateTime? DateError, string MaLoaiHoso, DateTime? NgayTT_B11, DateTime? NgayTT_B12, DateTime? NgayTT_B13, DateTime? NgayTT_A11, DateTime? NgayTT_A12, string SO_CMND_CU, DateTime? NgayTT_B14, DateTime? NgayTT_B15, string HoVaTenIn, string NoiTT, string NoiTT_MaDVHC, string NoiTT_MaDVQL, string Original_MaDangKy, int Original_TinhTP, byte[] Original_ROW_VERSION)
	{
		return Update(Original_MaDangKy, SoGPLX, HangGPLX, SoHoSo, SoGPLXCu, NoiCapGPLX, NgayCapGPLX, CoQuanQLGPLX, NgayHHGPLX, NgayTTGPLX, MoTaVN, MoTaEN, NguoiKy, MaHTCap, NoiHocGPLX, NamHocGPLX, DuongDanAnh, HoTenDem, TenNLX, HoVaTen, NgaySinh, MaQuocTich, NoiCT, NoiCT_MaDVHC, NoiCT_MaDVQL, SoCMT, NgayCapCMT, NoiCapCMT, MaViPham, NgayHHViPham, NgayBDViPham, GhiChu, NguoiTao, NguoiSua, NgayTao, NgaySua, GioiTinh, SoSeri, NgayTT_A1, NgayTT_A2, NgayTT_A3, NgayTT_A4, NgayTT_B1, NgayTT_B2, NgayTT_C, NgayTT_D, NgayTT_E, NgayTT_F, NgayTT_FB2, NgayTT_FC, NgayTT_FD, NgayTT_FE, MaLo, SignedData, VerifyKey, HangGplxIn, NgayTTIn, ErrorMsg, DateError, MaLoaiHoso, Original_TinhTP, NgayTT_B11, NgayTT_B12, NgayTT_B13, NgayTT_A11, NgayTT_A12, SO_CMND_CU, NgayTT_B14, NgayTT_B15, HoVaTenIn, NoiTT, NoiTT_MaDVHC, NoiTT_MaDVQL, Original_MaDangKy, Original_TinhTP, Original_ROW_VERSION);
	}
}
