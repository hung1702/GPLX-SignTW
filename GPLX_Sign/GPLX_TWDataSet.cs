using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GPLX_Sign;

[Serializable]
[DesignerCategory("code")]
[ToolboxItem(true)]
[XmlSchemaProvider("GetTypedDataSetSchema")]
[XmlRoot("GPLX_TWDataSet")]
[HelpKeyword("vs.data.DataSet")]
public class GPLX_TWDataSet : DataSet
{
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void GPLXRowChangeEventHandler(object sender, GPLXRowChangeEvent e);

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public delegate void DM_DonViGTVTRowChangeEventHandler(object sender, DM_DonViGTVTRowChangeEvent e);

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class GPLXDataTable : TypedTableBase<GPLXRow>
	{
		private DataColumn columnMaDangKy;

		private DataColumn columnSoGPLX;

		private DataColumn columnHangGPLX;

		private DataColumn columnSoHoSo;

		private DataColumn columnSoGPLXCu;

		private DataColumn columnNoiCapGPLX;

		private DataColumn columnNgayCapGPLX;

		private DataColumn columnCoQuanQLGPLX;

		private DataColumn columnNgayHHGPLX;

		private DataColumn columnNgayTTGPLX;

		private DataColumn columnMoTaVN;

		private DataColumn columnMoTaEN;

		private DataColumn columnNguoiKy;

		private DataColumn columnMaHTCap;

		private DataColumn columnNoiHocGPLX;

		private DataColumn columnNamHocGPLX;

		private DataColumn columnDuongDanAnh;

		private DataColumn columnHoTenDem;

		private DataColumn columnTenNLX;

		private DataColumn columnHoVaTen;

		private DataColumn columnNgaySinh;

		private DataColumn columnMaQuocTich;

		private DataColumn columnNoiCT;

		private DataColumn columnNoiCT_MaDVHC;

		private DataColumn columnNoiCT_MaDVQL;

		private DataColumn columnSoCMT;

		private DataColumn columnNgayCapCMT;

		private DataColumn columnNoiCapCMT;

		private DataColumn columnMaViPham;

		private DataColumn columnNgayHHViPham;

		private DataColumn columnNgayBDViPham;

		private DataColumn columnGhiChu;

		private DataColumn columnNguoiTao;

		private DataColumn columnNguoiSua;

		private DataColumn columnNgayTao;

		private DataColumn columnNgaySua;

		private DataColumn columnGioiTinh;

		private DataColumn columnSoSeri;

		private DataColumn columnNgayTT_A1;

		private DataColumn columnNgayTT_A2;

		private DataColumn columnNgayTT_A3;

		private DataColumn columnNgayTT_A4;

		private DataColumn columnNgayTT_B1;

		private DataColumn columnNgayTT_B2;

		private DataColumn columnNgayTT_C;

		private DataColumn columnNgayTT_D;

		private DataColumn columnNgayTT_E;

		private DataColumn columnNgayTT_F;

		private DataColumn columnNgayTT_FB2;

		private DataColumn columnNgayTT_FC;

		private DataColumn columnNgayTT_FD;

		private DataColumn columnNgayTT_FE;

		private DataColumn columnMaLo;

		private DataColumn columnSignedData;

		private DataColumn columnVerifyKey;

		private DataColumn columnHangGplxIn;

		private DataColumn columnNgayTTIn;

		private DataColumn columnErrorMsg;

		private DataColumn columnDateError;

		private DataColumn columnMaLoaiHoso;

		private DataColumn columnTinhTP;

		private DataColumn columnNgayTT_B11;

		private DataColumn columnROW_VERSION;

		private DataColumn columnNgayTT_B12;

		private DataColumn columnNgayTT_B13;

		private DataColumn columnNgayTT_A11;

		private DataColumn columnNgayTT_A12;

		private DataColumn columnSO_CMND_CU;

		private DataColumn columnNgayTT_B14;

		private DataColumn columnNgayTT_B15;

		private DataColumn columnHoVaTenIn;

		private DataColumn columnNoiTT;

		private DataColumn columnNoiTT_MaDVHC;

		private DataColumn columnNoiTT_MaDVQL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MaDangKyColumn => columnMaDangKy;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn SoGPLXColumn => columnSoGPLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn HangGPLXColumn => columnHangGPLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn SoHoSoColumn => columnSoHoSo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn SoGPLXCuColumn => columnSoGPLXCu;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NoiCapGPLXColumn => columnNoiCapGPLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayCapGPLXColumn => columnNgayCapGPLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn CoQuanQLGPLXColumn => columnCoQuanQLGPLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayHHGPLXColumn => columnNgayHHGPLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTTGPLXColumn => columnNgayTTGPLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MoTaVNColumn => columnMoTaVN;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MoTaENColumn => columnMoTaEN;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NguoiKyColumn => columnNguoiKy;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MaHTCapColumn => columnMaHTCap;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NoiHocGPLXColumn => columnNoiHocGPLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NamHocGPLXColumn => columnNamHocGPLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn DuongDanAnhColumn => columnDuongDanAnh;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn HoTenDemColumn => columnHoTenDem;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TenNLXColumn => columnTenNLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn HoVaTenColumn => columnHoVaTen;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgaySinhColumn => columnNgaySinh;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MaQuocTichColumn => columnMaQuocTich;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NoiCTColumn => columnNoiCT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NoiCT_MaDVHCColumn => columnNoiCT_MaDVHC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NoiCT_MaDVQLColumn => columnNoiCT_MaDVQL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn SoCMTColumn => columnSoCMT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayCapCMTColumn => columnNgayCapCMT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NoiCapCMTColumn => columnNoiCapCMT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MaViPhamColumn => columnMaViPham;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayHHViPhamColumn => columnNgayHHViPham;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayBDViPhamColumn => columnNgayBDViPham;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn GhiChuColumn => columnGhiChu;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NguoiTaoColumn => columnNguoiTao;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NguoiSuaColumn => columnNguoiSua;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTaoColumn => columnNgayTao;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgaySuaColumn => columnNgaySua;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn GioiTinhColumn => columnGioiTinh;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn SoSeriColumn => columnSoSeri;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_A1Column => columnNgayTT_A1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_A2Column => columnNgayTT_A2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_A3Column => columnNgayTT_A3;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_A4Column => columnNgayTT_A4;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_B1Column => columnNgayTT_B1;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_B2Column => columnNgayTT_B2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_CColumn => columnNgayTT_C;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_DColumn => columnNgayTT_D;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_EColumn => columnNgayTT_E;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_FColumn => columnNgayTT_F;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_FB2Column => columnNgayTT_FB2;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_FCColumn => columnNgayTT_FC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_FDColumn => columnNgayTT_FD;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_FEColumn => columnNgayTT_FE;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MaLoColumn => columnMaLo;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn SignedDataColumn => columnSignedData;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn VerifyKeyColumn => columnVerifyKey;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn HangGplxInColumn => columnHangGplxIn;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTTInColumn => columnNgayTTIn;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn ErrorMsgColumn => columnErrorMsg;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn DateErrorColumn => columnDateError;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MaLoaiHosoColumn => columnMaLoaiHoso;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TinhTPColumn => columnTinhTP;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_B11Column => columnNgayTT_B11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn ROW_VERSIONColumn => columnROW_VERSION;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_B12Column => columnNgayTT_B12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_B13Column => columnNgayTT_B13;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_A11Column => columnNgayTT_A11;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_A12Column => columnNgayTT_A12;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn SO_CMND_CUColumn => columnSO_CMND_CU;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_B14Column => columnNgayTT_B14;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NgayTT_B15Column => columnNgayTT_B15;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn HoVaTenInColumn => columnHoVaTenIn;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NoiTTColumn => columnNoiTT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NoiTT_MaDVHCColumn => columnNoiTT_MaDVHC;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn NoiTT_MaDVQLColumn => columnNoiTT_MaDVQL;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public GPLXRow this[int index] => (GPLXRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event GPLXRowChangeEventHandler GPLXRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event GPLXRowChangeEventHandler GPLXRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event GPLXRowChangeEventHandler GPLXRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event GPLXRowChangeEventHandler GPLXRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public GPLXDataTable()
		{
			base.TableName = "GPLX";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal GPLXDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected GPLXDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddGPLXRow(GPLXRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public GPLXRow AddGPLXRow(string MaDangKy, string SoGPLX, string HangGPLX, string SoHoSo, string SoGPLXCu, string NoiCapGPLX, DateTime NgayCapGPLX, string CoQuanQLGPLX, DateTime NgayHHGPLX, DateTime NgayTTGPLX, string MoTaVN, string MoTaEN, string NguoiKy, string MaHTCap, string NoiHocGPLX, int NamHocGPLX, string DuongDanAnh, string HoTenDem, string TenNLX, string HoVaTen, string NgaySinh, string MaQuocTich, string NoiCT, string NoiCT_MaDVHC, string NoiCT_MaDVQL, string SoCMT, DateTime NgayCapCMT, string NoiCapCMT, int MaViPham, DateTime NgayHHViPham, DateTime NgayBDViPham, string GhiChu, string NguoiTao, string NguoiSua, DateTime NgayTao, DateTime NgaySua, string GioiTinh, string SoSeri, DateTime NgayTT_A1, DateTime NgayTT_A2, DateTime NgayTT_A3, DateTime NgayTT_A4, DateTime NgayTT_B1, DateTime NgayTT_B2, DateTime NgayTT_C, DateTime NgayTT_D, DateTime NgayTT_E, DateTime NgayTT_F, DateTime NgayTT_FB2, DateTime NgayTT_FC, DateTime NgayTT_FD, DateTime NgayTT_FE, string MaLo, string SignedData, string VerifyKey, string HangGplxIn, string NgayTTIn, string ErrorMsg, DateTime DateError, string MaLoaiHoso, int TinhTP, DateTime NgayTT_B11, byte[] ROW_VERSION, DateTime NgayTT_B12, DateTime NgayTT_B13, DateTime NgayTT_A11, DateTime NgayTT_A12, string SO_CMND_CU, DateTime NgayTT_B14, DateTime NgayTT_B15, string HoVaTenIn, string NoiTT, string NoiTT_MaDVHC, string NoiTT_MaDVQL)
		{
			GPLXRow gPLXRow = (GPLXRow)NewRow();
			object[] array2 = (gPLXRow.ItemArray = new object[74]
			{
				MaDangKy, SoGPLX, HangGPLX, SoHoSo, SoGPLXCu, NoiCapGPLX, NgayCapGPLX, CoQuanQLGPLX, NgayHHGPLX, NgayTTGPLX,
				MoTaVN, MoTaEN, NguoiKy, MaHTCap, NoiHocGPLX, NamHocGPLX, DuongDanAnh, HoTenDem, TenNLX, HoVaTen,
				NgaySinh, MaQuocTich, NoiCT, NoiCT_MaDVHC, NoiCT_MaDVQL, SoCMT, NgayCapCMT, NoiCapCMT, MaViPham, NgayHHViPham,
				NgayBDViPham, GhiChu, NguoiTao, NguoiSua, NgayTao, NgaySua, GioiTinh, SoSeri, NgayTT_A1, NgayTT_A2,
				NgayTT_A3, NgayTT_A4, NgayTT_B1, NgayTT_B2, NgayTT_C, NgayTT_D, NgayTT_E, NgayTT_F, NgayTT_FB2, NgayTT_FC,
				NgayTT_FD, NgayTT_FE, MaLo, SignedData, VerifyKey, HangGplxIn, NgayTTIn, ErrorMsg, DateError, MaLoaiHoso,
				TinhTP, NgayTT_B11, ROW_VERSION, NgayTT_B12, NgayTT_B13, NgayTT_A11, NgayTT_A12, SO_CMND_CU, NgayTT_B14, NgayTT_B15,
				HoVaTenIn, NoiTT, NoiTT_MaDVHC, NoiTT_MaDVQL
			});
			base.Rows.Add(gPLXRow);
			return gPLXRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public GPLXRow FindByMaDangKyTinhTP(string MaDangKy, int TinhTP)
		{
			return (GPLXRow)base.Rows.Find(new object[2] { MaDangKy, TinhTP });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public override DataTable Clone()
		{
			GPLXDataTable gPLXDataTable = (GPLXDataTable)base.Clone();
			gPLXDataTable.InitVars();
			return gPLXDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new GPLXDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnMaDangKy = base.Columns["MaDangKy"];
			columnSoGPLX = base.Columns["SoGPLX"];
			columnHangGPLX = base.Columns["HangGPLX"];
			columnSoHoSo = base.Columns["SoHoSo"];
			columnSoGPLXCu = base.Columns["SoGPLXCu"];
			columnNoiCapGPLX = base.Columns["NoiCapGPLX"];
			columnNgayCapGPLX = base.Columns["NgayCapGPLX"];
			columnCoQuanQLGPLX = base.Columns["CoQuanQLGPLX"];
			columnNgayHHGPLX = base.Columns["NgayHHGPLX"];
			columnNgayTTGPLX = base.Columns["NgayTTGPLX"];
			columnMoTaVN = base.Columns["MoTaVN"];
			columnMoTaEN = base.Columns["MoTaEN"];
			columnNguoiKy = base.Columns["NguoiKy"];
			columnMaHTCap = base.Columns["MaHTCap"];
			columnNoiHocGPLX = base.Columns["NoiHocGPLX"];
			columnNamHocGPLX = base.Columns["NamHocGPLX"];
			columnDuongDanAnh = base.Columns["DuongDanAnh"];
			columnHoTenDem = base.Columns["HoTenDem"];
			columnTenNLX = base.Columns["TenNLX"];
			columnHoVaTen = base.Columns["HoVaTen"];
			columnNgaySinh = base.Columns["NgaySinh"];
			columnMaQuocTich = base.Columns["MaQuocTich"];
			columnNoiCT = base.Columns["NoiCT"];
			columnNoiCT_MaDVHC = base.Columns["NoiCT_MaDVHC"];
			columnNoiCT_MaDVQL = base.Columns["NoiCT_MaDVQL"];
			columnSoCMT = base.Columns["SoCMT"];
			columnNgayCapCMT = base.Columns["NgayCapCMT"];
			columnNoiCapCMT = base.Columns["NoiCapCMT"];
			columnMaViPham = base.Columns["MaViPham"];
			columnNgayHHViPham = base.Columns["NgayHHViPham"];
			columnNgayBDViPham = base.Columns["NgayBDViPham"];
			columnGhiChu = base.Columns["GhiChu"];
			columnNguoiTao = base.Columns["NguoiTao"];
			columnNguoiSua = base.Columns["NguoiSua"];
			columnNgayTao = base.Columns["NgayTao"];
			columnNgaySua = base.Columns["NgaySua"];
			columnGioiTinh = base.Columns["GioiTinh"];
			columnSoSeri = base.Columns["SoSeri"];
			columnNgayTT_A1 = base.Columns["NgayTT_A1"];
			columnNgayTT_A2 = base.Columns["NgayTT_A2"];
			columnNgayTT_A3 = base.Columns["NgayTT_A3"];
			columnNgayTT_A4 = base.Columns["NgayTT_A4"];
			columnNgayTT_B1 = base.Columns["NgayTT_B1"];
			columnNgayTT_B2 = base.Columns["NgayTT_B2"];
			columnNgayTT_C = base.Columns["NgayTT_C"];
			columnNgayTT_D = base.Columns["NgayTT_D"];
			columnNgayTT_E = base.Columns["NgayTT_E"];
			columnNgayTT_F = base.Columns["NgayTT_F"];
			columnNgayTT_FB2 = base.Columns["NgayTT_FB2"];
			columnNgayTT_FC = base.Columns["NgayTT_FC"];
			columnNgayTT_FD = base.Columns["NgayTT_FD"];
			columnNgayTT_FE = base.Columns["NgayTT_FE"];
			columnMaLo = base.Columns["MaLo"];
			columnSignedData = base.Columns["SignedData"];
			columnVerifyKey = base.Columns["VerifyKey"];
			columnHangGplxIn = base.Columns["HangGplxIn"];
			columnNgayTTIn = base.Columns["NgayTTIn"];
			columnErrorMsg = base.Columns["ErrorMsg"];
			columnDateError = base.Columns["DateError"];
			columnMaLoaiHoso = base.Columns["MaLoaiHoso"];
			columnTinhTP = base.Columns["TinhTP"];
			columnNgayTT_B11 = base.Columns["NgayTT_B11"];
			columnROW_VERSION = base.Columns["ROW_VERSION"];
			columnNgayTT_B12 = base.Columns["NgayTT_B12"];
			columnNgayTT_B13 = base.Columns["NgayTT_B13"];
			columnNgayTT_A11 = base.Columns["NgayTT_A11"];
			columnNgayTT_A12 = base.Columns["NgayTT_A12"];
			columnSO_CMND_CU = base.Columns["SO_CMND_CU"];
			columnNgayTT_B14 = base.Columns["NgayTT_B14"];
			columnNgayTT_B15 = base.Columns["NgayTT_B15"];
			columnHoVaTenIn = base.Columns["HoVaTenIn"];
			columnNoiTT = base.Columns["NoiTT"];
			columnNoiTT_MaDVHC = base.Columns["NoiTT_MaDVHC"];
			columnNoiTT_MaDVQL = base.Columns["NoiTT_MaDVQL"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnMaDangKy = new DataColumn("MaDangKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMaDangKy);
			columnSoGPLX = new DataColumn("SoGPLX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoGPLX);
			columnHangGPLX = new DataColumn("HangGPLX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHangGPLX);
			columnSoHoSo = new DataColumn("SoHoSo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoHoSo);
			columnSoGPLXCu = new DataColumn("SoGPLXCu", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoGPLXCu);
			columnNoiCapGPLX = new DataColumn("NoiCapGPLX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNoiCapGPLX);
			columnNgayCapGPLX = new DataColumn("NgayCapGPLX", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayCapGPLX);
			columnCoQuanQLGPLX = new DataColumn("CoQuanQLGPLX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnCoQuanQLGPLX);
			columnNgayHHGPLX = new DataColumn("NgayHHGPLX", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayHHGPLX);
			columnNgayTTGPLX = new DataColumn("NgayTTGPLX", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTTGPLX);
			columnMoTaVN = new DataColumn("MoTaVN", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMoTaVN);
			columnMoTaEN = new DataColumn("MoTaEN", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMoTaEN);
			columnNguoiKy = new DataColumn("NguoiKy", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNguoiKy);
			columnMaHTCap = new DataColumn("MaHTCap", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMaHTCap);
			columnNoiHocGPLX = new DataColumn("NoiHocGPLX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNoiHocGPLX);
			columnNamHocGPLX = new DataColumn("NamHocGPLX", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnNamHocGPLX);
			columnDuongDanAnh = new DataColumn("DuongDanAnh", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnDuongDanAnh);
			columnHoTenDem = new DataColumn("HoTenDem", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHoTenDem);
			columnTenNLX = new DataColumn("TenNLX", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenNLX);
			columnHoVaTen = new DataColumn("HoVaTen", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHoVaTen);
			columnNgaySinh = new DataColumn("NgaySinh", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgaySinh);
			columnMaQuocTich = new DataColumn("MaQuocTich", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMaQuocTich);
			columnNoiCT = new DataColumn("NoiCT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNoiCT);
			columnNoiCT_MaDVHC = new DataColumn("NoiCT_MaDVHC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNoiCT_MaDVHC);
			columnNoiCT_MaDVQL = new DataColumn("NoiCT_MaDVQL", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNoiCT_MaDVQL);
			columnSoCMT = new DataColumn("SoCMT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoCMT);
			columnNgayCapCMT = new DataColumn("NgayCapCMT", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayCapCMT);
			columnNoiCapCMT = new DataColumn("NoiCapCMT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNoiCapCMT);
			columnMaViPham = new DataColumn("MaViPham", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnMaViPham);
			columnNgayHHViPham = new DataColumn("NgayHHViPham", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayHHViPham);
			columnNgayBDViPham = new DataColumn("NgayBDViPham", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayBDViPham);
			columnGhiChu = new DataColumn("GhiChu", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnGhiChu);
			columnNguoiTao = new DataColumn("NguoiTao", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNguoiTao);
			columnNguoiSua = new DataColumn("NguoiSua", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNguoiSua);
			columnNgayTao = new DataColumn("NgayTao", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTao);
			columnNgaySua = new DataColumn("NgaySua", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgaySua);
			columnGioiTinh = new DataColumn("GioiTinh", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnGioiTinh);
			columnSoSeri = new DataColumn("SoSeri", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSoSeri);
			columnNgayTT_A1 = new DataColumn("NgayTT_A1", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_A1);
			columnNgayTT_A2 = new DataColumn("NgayTT_A2", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_A2);
			columnNgayTT_A3 = new DataColumn("NgayTT_A3", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_A3);
			columnNgayTT_A4 = new DataColumn("NgayTT_A4", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_A4);
			columnNgayTT_B1 = new DataColumn("NgayTT_B1", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_B1);
			columnNgayTT_B2 = new DataColumn("NgayTT_B2", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_B2);
			columnNgayTT_C = new DataColumn("NgayTT_C", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_C);
			columnNgayTT_D = new DataColumn("NgayTT_D", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_D);
			columnNgayTT_E = new DataColumn("NgayTT_E", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_E);
			columnNgayTT_F = new DataColumn("NgayTT_F", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_F);
			columnNgayTT_FB2 = new DataColumn("NgayTT_FB2", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_FB2);
			columnNgayTT_FC = new DataColumn("NgayTT_FC", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_FC);
			columnNgayTT_FD = new DataColumn("NgayTT_FD", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_FD);
			columnNgayTT_FE = new DataColumn("NgayTT_FE", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_FE);
			columnMaLo = new DataColumn("MaLo", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMaLo);
			columnSignedData = new DataColumn("SignedData", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSignedData);
			columnVerifyKey = new DataColumn("VerifyKey", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnVerifyKey);
			columnHangGplxIn = new DataColumn("HangGplxIn", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHangGplxIn);
			columnNgayTTIn = new DataColumn("NgayTTIn", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNgayTTIn);
			columnErrorMsg = new DataColumn("ErrorMsg", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnErrorMsg);
			columnDateError = new DataColumn("DateError", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnDateError);
			columnMaLoaiHoso = new DataColumn("MaLoaiHoso", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMaLoaiHoso);
			columnTinhTP = new DataColumn("TinhTP", typeof(int), null, MappingType.Element);
			base.Columns.Add(columnTinhTP);
			columnNgayTT_B11 = new DataColumn("NgayTT_B11", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_B11);
			columnROW_VERSION = new DataColumn("ROW_VERSION", typeof(byte[]), null, MappingType.Element);
			base.Columns.Add(columnROW_VERSION);
			columnNgayTT_B12 = new DataColumn("NgayTT_B12", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_B12);
			columnNgayTT_B13 = new DataColumn("NgayTT_B13", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_B13);
			columnNgayTT_A11 = new DataColumn("NgayTT_A11", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_A11);
			columnNgayTT_A12 = new DataColumn("NgayTT_A12", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_A12);
			columnSO_CMND_CU = new DataColumn("SO_CMND_CU", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnSO_CMND_CU);
			columnNgayTT_B14 = new DataColumn("NgayTT_B14", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_B14);
			columnNgayTT_B15 = new DataColumn("NgayTT_B15", typeof(DateTime), null, MappingType.Element);
			base.Columns.Add(columnNgayTT_B15);
			columnHoVaTenIn = new DataColumn("HoVaTenIn", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnHoVaTenIn);
			columnNoiTT = new DataColumn("NoiTT", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNoiTT);
			columnNoiTT_MaDVHC = new DataColumn("NoiTT_MaDVHC", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNoiTT_MaDVHC);
			columnNoiTT_MaDVQL = new DataColumn("NoiTT_MaDVQL", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnNoiTT_MaDVQL);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[2] { columnMaDangKy, columnTinhTP }, isPrimaryKey: true));
			columnMaDangKy.AllowDBNull = false;
			columnMaDangKy.MaxLength = 30;
			columnSoGPLX.AllowDBNull = false;
			columnSoGPLX.MaxLength = 20;
			columnHangGPLX.AllowDBNull = false;
			columnHangGPLX.MaxLength = 3;
			columnSoHoSo.AllowDBNull = false;
			columnSoHoSo.MaxLength = 18;
			columnSoGPLXCu.MaxLength = 120;
			columnNoiCapGPLX.AllowDBNull = false;
			columnNoiCapGPLX.MaxLength = 6;
			columnNgayCapGPLX.AllowDBNull = false;
			columnCoQuanQLGPLX.AllowDBNull = false;
			columnCoQuanQLGPLX.MaxLength = 6;
			columnNgayTTGPLX.AllowDBNull = false;
			columnMoTaVN.AllowDBNull = false;
			columnMoTaVN.MaxLength = 1000;
			columnMoTaEN.AllowDBNull = false;
			columnMoTaEN.MaxLength = 1000;
			columnNguoiKy.MaxLength = 255;
			columnMaHTCap.AllowDBNull = false;
			columnMaHTCap.MaxLength = 5;
			columnNoiHocGPLX.MaxLength = 6;
			columnDuongDanAnh.MaxLength = 255;
			columnHoTenDem.AllowDBNull = false;
			columnHoTenDem.MaxLength = 50;
			columnTenNLX.AllowDBNull = false;
			columnTenNLX.MaxLength = 20;
			columnHoVaTen.AllowDBNull = false;
			columnHoVaTen.MaxLength = 70;
			columnNgaySinh.AllowDBNull = false;
			columnNgaySinh.MaxLength = 8;
			columnMaQuocTich.AllowDBNull = false;
			columnMaQuocTich.MaxLength = 3;
			columnNoiCT.MaxLength = 50;
			columnNoiCT_MaDVHC.MaxLength = 5;
			columnNoiCT_MaDVQL.MaxLength = 5;
			columnSoCMT.AllowDBNull = false;
			columnSoCMT.MaxLength = 20;
			columnNoiCapCMT.MaxLength = 50;
			columnGhiChu.MaxLength = 255;
			columnNguoiTao.MaxLength = 30;
			columnNguoiSua.MaxLength = 30;
			columnNgayTao.AllowDBNull = false;
			columnNgaySua.AllowDBNull = false;
			columnGioiTinh.MaxLength = 1;
			columnSoSeri.MaxLength = 20;
			columnMaLo.MaxLength = 50;
			columnSignedData.MaxLength = int.MaxValue;
			columnVerifyKey.MaxLength = int.MaxValue;
			columnHangGplxIn.MaxLength = 150;
			columnNgayTTIn.MaxLength = 150;
			columnErrorMsg.MaxLength = 500;
			columnMaLoaiHoso.MaxLength = 300;
			columnTinhTP.AllowDBNull = false;
			columnROW_VERSION.ReadOnly = true;
			columnSO_CMND_CU.MaxLength = 20;
			columnHoVaTenIn.MaxLength = 70;
			columnNoiTT.MaxLength = 50;
			columnNoiTT_MaDVHC.MaxLength = 50;
			columnNoiTT_MaDVQL.MaxLength = 5;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public GPLXRow NewGPLXRow()
		{
			return (GPLXRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new GPLXRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(GPLXRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.GPLXRowChanged != null)
			{
				this.GPLXRowChanged(this, new GPLXRowChangeEvent((GPLXRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.GPLXRowChanging != null)
			{
				this.GPLXRowChanging(this, new GPLXRowChangeEvent((GPLXRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.GPLXRowDeleted != null)
			{
				this.GPLXRowDeleted(this, new GPLXRowChangeEvent((GPLXRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.GPLXRowDeleting != null)
			{
				this.GPLXRowDeleting(this, new GPLXRowChangeEvent((GPLXRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveGPLXRow(GPLXRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			GPLX_TWDataSet gPLX_TWDataSet = new GPLX_TWDataSet();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = gPLX_TWDataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "GPLXDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = gPLX_TWDataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	[Serializable]
	[XmlSchemaProvider("GetTypedTableSchema")]
	public class DM_DonViGTVTDataTable : TypedTableBase<DM_DonViGTVTRow>
	{
		private DataColumn columnMaDV;

		private DataColumn columnLoaiDV;

		private DataColumn columnTenDV;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn MaDVColumn => columnMaDV;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn LoaiDVColumn => columnLoaiDV;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataColumn TenDVColumn => columnTenDV;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		[Browsable(false)]
		public int Count => base.Rows.Count;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DM_DonViGTVTRow this[int index] => (DM_DonViGTVTRow)base.Rows[index];

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event DM_DonViGTVTRowChangeEventHandler DM_DonViGTVTRowChanging;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event DM_DonViGTVTRowChangeEventHandler DM_DonViGTVTRowChanged;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event DM_DonViGTVTRowChangeEventHandler DM_DonViGTVTRowDeleting;

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public event DM_DonViGTVTRowChangeEventHandler DM_DonViGTVTRowDeleted;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DM_DonViGTVTDataTable()
		{
			base.TableName = "DM_DonViGTVT";
			BeginInit();
			InitClass();
			EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DM_DonViGTVTDataTable(DataTable table)
		{
			base.TableName = table.TableName;
			if (table.CaseSensitive != table.DataSet.CaseSensitive)
			{
				base.CaseSensitive = table.CaseSensitive;
			}
			if (table.Locale.ToString() != table.DataSet.Locale.ToString())
			{
				base.Locale = table.Locale;
			}
			if (table.Namespace != table.DataSet.Namespace)
			{
				base.Namespace = table.Namespace;
			}
			base.Prefix = table.Prefix;
			base.MinimumCapacity = table.MinimumCapacity;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected DM_DonViGTVTDataTable(SerializationInfo info, StreamingContext context)
			: base(info, context)
		{
			InitVars();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void AddDM_DonViGTVTRow(DM_DonViGTVTRow row)
		{
			base.Rows.Add(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DM_DonViGTVTRow AddDM_DonViGTVTRow(string MaDV, string LoaiDV, string TenDV)
		{
			DM_DonViGTVTRow dM_DonViGTVTRow = (DM_DonViGTVTRow)NewRow();
			object[] array2 = (dM_DonViGTVTRow.ItemArray = new object[3] { MaDV, LoaiDV, TenDV });
			base.Rows.Add(dM_DonViGTVTRow);
			return dM_DonViGTVTRow;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DM_DonViGTVTRow FindByMaDV(string MaDV)
		{
			return (DM_DonViGTVTRow)base.Rows.Find(new object[1] { MaDV });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public override DataTable Clone()
		{
			DM_DonViGTVTDataTable dM_DonViGTVTDataTable = (DM_DonViGTVTDataTable)base.Clone();
			dM_DonViGTVTDataTable.InitVars();
			return dM_DonViGTVTDataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataTable CreateInstance()
		{
			return new DM_DonViGTVTDataTable();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal void InitVars()
		{
			columnMaDV = base.Columns["MaDV"];
			columnLoaiDV = base.Columns["LoaiDV"];
			columnTenDV = base.Columns["TenDV"];
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		private void InitClass()
		{
			columnMaDV = new DataColumn("MaDV", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnMaDV);
			columnLoaiDV = new DataColumn("LoaiDV", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnLoaiDV);
			columnTenDV = new DataColumn("TenDV", typeof(string), null, MappingType.Element);
			base.Columns.Add(columnTenDV);
			base.Constraints.Add(new UniqueConstraint("Constraint1", new DataColumn[1] { columnMaDV }, isPrimaryKey: true));
			columnMaDV.AllowDBNull = false;
			columnMaDV.Unique = true;
			columnMaDV.MaxLength = 6;
			columnLoaiDV.AllowDBNull = false;
			columnLoaiDV.MaxLength = 2;
			columnTenDV.MaxLength = 100;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DM_DonViGTVTRow NewDM_DonViGTVTRow()
		{
			return (DM_DonViGTVTRow)NewRow();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
		{
			return new DM_DonViGTVTRow(builder);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override Type GetRowType()
		{
			return typeof(DM_DonViGTVTRow);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanged(DataRowChangeEventArgs e)
		{
			base.OnRowChanged(e);
			if (this.DM_DonViGTVTRowChanged != null)
			{
				this.DM_DonViGTVTRowChanged(this, new DM_DonViGTVTRowChangeEvent((DM_DonViGTVTRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowChanging(DataRowChangeEventArgs e)
		{
			base.OnRowChanging(e);
			if (this.DM_DonViGTVTRowChanging != null)
			{
				this.DM_DonViGTVTRowChanging(this, new DM_DonViGTVTRowChangeEvent((DM_DonViGTVTRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleted(DataRowChangeEventArgs e)
		{
			base.OnRowDeleted(e);
			if (this.DM_DonViGTVTRowDeleted != null)
			{
				this.DM_DonViGTVTRowDeleted(this, new DM_DonViGTVTRowChangeEvent((DM_DonViGTVTRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		protected override void OnRowDeleting(DataRowChangeEventArgs e)
		{
			base.OnRowDeleting(e);
			if (this.DM_DonViGTVTRowDeleting != null)
			{
				this.DM_DonViGTVTRowDeleting(this, new DM_DonViGTVTRowChangeEvent((DM_DonViGTVTRow)e.Row, e.Action));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void RemoveDM_DonViGTVTRow(DM_DonViGTVTRow row)
		{
			base.Rows.Remove(row);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			GPLX_TWDataSet gPLX_TWDataSet = new GPLX_TWDataSet();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
			xmlSchemaAny.MinOccurs = 0m;
			xmlSchemaAny.MaxOccurs = decimal.MaxValue;
			xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
			xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
			xmlSchemaAny2.MinOccurs = 1m;
			xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
			xmlSchemaSequence.Items.Add(xmlSchemaAny2);
			XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
			xmlSchemaAttribute.Name = "namespace";
			xmlSchemaAttribute.FixedValue = gPLX_TWDataSet.Namespace;
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
			XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
			xmlSchemaAttribute2.Name = "tableTypeName";
			xmlSchemaAttribute2.FixedValue = "DM_DonViGTVTDataTable";
			xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = gPLX_TWDataSet.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					XmlSchema xmlSchema = null;
					schemaSerializable.Write(memoryStream);
					IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
					while (enumerator.MoveNext())
					{
						xmlSchema = (XmlSchema)enumerator.Current;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					memoryStream?.Close();
					memoryStream2?.Close();
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}
	}

	public class GPLXRow : DataRow
	{
		private GPLXDataTable tableGPLX;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string MaDangKy
		{
			get
			{
				return (string)base[tableGPLX.MaDangKyColumn];
			}
			set
			{
				base[tableGPLX.MaDangKyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string SoGPLX
		{
			get
			{
				return (string)base[tableGPLX.SoGPLXColumn];
			}
			set
			{
				base[tableGPLX.SoGPLXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string HangGPLX
		{
			get
			{
				return (string)base[tableGPLX.HangGPLXColumn];
			}
			set
			{
				base[tableGPLX.HangGPLXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string SoHoSo
		{
			get
			{
				return (string)base[tableGPLX.SoHoSoColumn];
			}
			set
			{
				base[tableGPLX.SoHoSoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string SoGPLXCu
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.SoGPLXCuColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoGPLXCu' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.SoGPLXCuColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NoiCapGPLX
		{
			get
			{
				return (string)base[tableGPLX.NoiCapGPLXColumn];
			}
			set
			{
				base[tableGPLX.NoiCapGPLXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayCapGPLX
		{
			get
			{
				return (DateTime)base[tableGPLX.NgayCapGPLXColumn];
			}
			set
			{
				base[tableGPLX.NgayCapGPLXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string CoQuanQLGPLX
		{
			get
			{
				return (string)base[tableGPLX.CoQuanQLGPLXColumn];
			}
			set
			{
				base[tableGPLX.CoQuanQLGPLXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayHHGPLX
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayHHGPLXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayHHGPLX' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayHHGPLXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTTGPLX
		{
			get
			{
				return (DateTime)base[tableGPLX.NgayTTGPLXColumn];
			}
			set
			{
				base[tableGPLX.NgayTTGPLXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string MoTaVN
		{
			get
			{
				return (string)base[tableGPLX.MoTaVNColumn];
			}
			set
			{
				base[tableGPLX.MoTaVNColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string MoTaEN
		{
			get
			{
				return (string)base[tableGPLX.MoTaENColumn];
			}
			set
			{
				base[tableGPLX.MoTaENColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NguoiKy
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NguoiKyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NguoiKy' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NguoiKyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string MaHTCap
		{
			get
			{
				return (string)base[tableGPLX.MaHTCapColumn];
			}
			set
			{
				base[tableGPLX.MaHTCapColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NoiHocGPLX
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NoiHocGPLXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoiHocGPLX' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NoiHocGPLXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public int NamHocGPLX
		{
			get
			{
				try
				{
					return (int)base[tableGPLX.NamHocGPLXColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NamHocGPLX' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NamHocGPLXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string DuongDanAnh
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.DuongDanAnhColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DuongDanAnh' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.DuongDanAnhColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string HoTenDem
		{
			get
			{
				return (string)base[tableGPLX.HoTenDemColumn];
			}
			set
			{
				base[tableGPLX.HoTenDemColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TenNLX
		{
			get
			{
				return (string)base[tableGPLX.TenNLXColumn];
			}
			set
			{
				base[tableGPLX.TenNLXColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string HoVaTen
		{
			get
			{
				return (string)base[tableGPLX.HoVaTenColumn];
			}
			set
			{
				base[tableGPLX.HoVaTenColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NgaySinh
		{
			get
			{
				return (string)base[tableGPLX.NgaySinhColumn];
			}
			set
			{
				base[tableGPLX.NgaySinhColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string MaQuocTich
		{
			get
			{
				return (string)base[tableGPLX.MaQuocTichColumn];
			}
			set
			{
				base[tableGPLX.MaQuocTichColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NoiCT
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NoiCTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoiCT' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NoiCTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NoiCT_MaDVHC
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NoiCT_MaDVHCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoiCT_MaDVHC' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NoiCT_MaDVHCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NoiCT_MaDVQL
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NoiCT_MaDVQLColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoiCT_MaDVQL' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NoiCT_MaDVQLColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string SoCMT
		{
			get
			{
				return (string)base[tableGPLX.SoCMTColumn];
			}
			set
			{
				base[tableGPLX.SoCMTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayCapCMT
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayCapCMTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayCapCMT' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayCapCMTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NoiCapCMT
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NoiCapCMTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoiCapCMT' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NoiCapCMTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public int MaViPham
		{
			get
			{
				try
				{
					return (int)base[tableGPLX.MaViPhamColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'MaViPham' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.MaViPhamColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayHHViPham
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayHHViPhamColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayHHViPham' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayHHViPhamColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayBDViPham
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayBDViPhamColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayBDViPham' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayBDViPhamColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string GhiChu
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.GhiChuColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'GhiChu' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.GhiChuColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NguoiTao
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NguoiTaoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NguoiTao' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NguoiTaoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NguoiSua
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NguoiSuaColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NguoiSua' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NguoiSuaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTao
		{
			get
			{
				return (DateTime)base[tableGPLX.NgayTaoColumn];
			}
			set
			{
				base[tableGPLX.NgayTaoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgaySua
		{
			get
			{
				return (DateTime)base[tableGPLX.NgaySuaColumn];
			}
			set
			{
				base[tableGPLX.NgaySuaColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string GioiTinh
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.GioiTinhColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'GioiTinh' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.GioiTinhColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string SoSeri
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.SoSeriColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SoSeri' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.SoSeriColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_A1
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_A1Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_A1' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_A1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_A2
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_A2Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_A2' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_A2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_A3
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_A3Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_A3' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_A3Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_A4
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_A4Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_A4' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_A4Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_B1
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_B1Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_B1' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_B1Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_B2
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_B2Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_B2' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_B2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_C
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_CColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_C' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_CColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_D
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_DColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_D' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_DColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_E
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_EColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_E' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_EColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_F
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_FColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_F' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_FColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_FB2
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_FB2Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_FB2' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_FB2Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_FC
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_FCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_FC' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_FCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_FD
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_FDColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_FD' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_FDColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_FE
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_FEColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_FE' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_FEColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string MaLo
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.MaLoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'MaLo' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.MaLoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string SignedData
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.SignedDataColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SignedData' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.SignedDataColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string VerifyKey
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.VerifyKeyColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'VerifyKey' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.VerifyKeyColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string HangGplxIn
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.HangGplxInColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HangGplxIn' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.HangGplxInColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NgayTTIn
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NgayTTInColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTTIn' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTTInColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string ErrorMsg
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.ErrorMsgColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ErrorMsg' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.ErrorMsgColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime DateError
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.DateErrorColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'DateError' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.DateErrorColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string MaLoaiHoso
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.MaLoaiHosoColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'MaLoaiHoso' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.MaLoaiHosoColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public int TinhTP
		{
			get
			{
				return (int)base[tableGPLX.TinhTPColumn];
			}
			set
			{
				base[tableGPLX.TinhTPColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_B11
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_B11Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_B11' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_B11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public byte[] ROW_VERSION
		{
			get
			{
				try
				{
					return (byte[])base[tableGPLX.ROW_VERSIONColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'ROW_VERSION' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.ROW_VERSIONColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_B12
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_B12Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_B12' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_B12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_B13
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_B13Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_B13' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_B13Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_A11
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_A11Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_A11' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_A11Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_A12
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_A12Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_A12' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_A12Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string SO_CMND_CU
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.SO_CMND_CUColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'SO_CMND_CU' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.SO_CMND_CUColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_B14
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_B14Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_B14' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_B14Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DateTime NgayTT_B15
		{
			get
			{
				try
				{
					return (DateTime)base[tableGPLX.NgayTT_B15Column];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NgayTT_B15' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NgayTT_B15Column] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string HoVaTenIn
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.HoVaTenInColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'HoVaTenIn' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.HoVaTenInColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NoiTT
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NoiTTColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoiTT' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NoiTTColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NoiTT_MaDVHC
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NoiTT_MaDVHCColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoiTT_MaDVHC' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NoiTT_MaDVHCColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string NoiTT_MaDVQL
		{
			get
			{
				try
				{
					return (string)base[tableGPLX.NoiTT_MaDVQLColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'NoiTT_MaDVQL' in table 'GPLX' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableGPLX.NoiTT_MaDVQLColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal GPLXRow(DataRowBuilder rb)
			: base(rb)
		{
			tableGPLX = (GPLXDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsSoGPLXCuNull()
		{
			return IsNull(tableGPLX.SoGPLXCuColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetSoGPLXCuNull()
		{
			base[tableGPLX.SoGPLXCuColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayHHGPLXNull()
		{
			return IsNull(tableGPLX.NgayHHGPLXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayHHGPLXNull()
		{
			base[tableGPLX.NgayHHGPLXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNguoiKyNull()
		{
			return IsNull(tableGPLX.NguoiKyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNguoiKyNull()
		{
			base[tableGPLX.NguoiKyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNoiHocGPLXNull()
		{
			return IsNull(tableGPLX.NoiHocGPLXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNoiHocGPLXNull()
		{
			base[tableGPLX.NoiHocGPLXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNamHocGPLXNull()
		{
			return IsNull(tableGPLX.NamHocGPLXColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNamHocGPLXNull()
		{
			base[tableGPLX.NamHocGPLXColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsDuongDanAnhNull()
		{
			return IsNull(tableGPLX.DuongDanAnhColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetDuongDanAnhNull()
		{
			base[tableGPLX.DuongDanAnhColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNoiCTNull()
		{
			return IsNull(tableGPLX.NoiCTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNoiCTNull()
		{
			base[tableGPLX.NoiCTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNoiCT_MaDVHCNull()
		{
			return IsNull(tableGPLX.NoiCT_MaDVHCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNoiCT_MaDVHCNull()
		{
			base[tableGPLX.NoiCT_MaDVHCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNoiCT_MaDVQLNull()
		{
			return IsNull(tableGPLX.NoiCT_MaDVQLColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNoiCT_MaDVQLNull()
		{
			base[tableGPLX.NoiCT_MaDVQLColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayCapCMTNull()
		{
			return IsNull(tableGPLX.NgayCapCMTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayCapCMTNull()
		{
			base[tableGPLX.NgayCapCMTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNoiCapCMTNull()
		{
			return IsNull(tableGPLX.NoiCapCMTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNoiCapCMTNull()
		{
			base[tableGPLX.NoiCapCMTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsMaViPhamNull()
		{
			return IsNull(tableGPLX.MaViPhamColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetMaViPhamNull()
		{
			base[tableGPLX.MaViPhamColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayHHViPhamNull()
		{
			return IsNull(tableGPLX.NgayHHViPhamColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayHHViPhamNull()
		{
			base[tableGPLX.NgayHHViPhamColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayBDViPhamNull()
		{
			return IsNull(tableGPLX.NgayBDViPhamColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayBDViPhamNull()
		{
			base[tableGPLX.NgayBDViPhamColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsGhiChuNull()
		{
			return IsNull(tableGPLX.GhiChuColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetGhiChuNull()
		{
			base[tableGPLX.GhiChuColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNguoiTaoNull()
		{
			return IsNull(tableGPLX.NguoiTaoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNguoiTaoNull()
		{
			base[tableGPLX.NguoiTaoColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNguoiSuaNull()
		{
			return IsNull(tableGPLX.NguoiSuaColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNguoiSuaNull()
		{
			base[tableGPLX.NguoiSuaColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsGioiTinhNull()
		{
			return IsNull(tableGPLX.GioiTinhColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetGioiTinhNull()
		{
			base[tableGPLX.GioiTinhColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsSoSeriNull()
		{
			return IsNull(tableGPLX.SoSeriColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetSoSeriNull()
		{
			base[tableGPLX.SoSeriColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_A1Null()
		{
			return IsNull(tableGPLX.NgayTT_A1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_A1Null()
		{
			base[tableGPLX.NgayTT_A1Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_A2Null()
		{
			return IsNull(tableGPLX.NgayTT_A2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_A2Null()
		{
			base[tableGPLX.NgayTT_A2Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_A3Null()
		{
			return IsNull(tableGPLX.NgayTT_A3Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_A3Null()
		{
			base[tableGPLX.NgayTT_A3Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_A4Null()
		{
			return IsNull(tableGPLX.NgayTT_A4Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_A4Null()
		{
			base[tableGPLX.NgayTT_A4Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_B1Null()
		{
			return IsNull(tableGPLX.NgayTT_B1Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_B1Null()
		{
			base[tableGPLX.NgayTT_B1Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_B2Null()
		{
			return IsNull(tableGPLX.NgayTT_B2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_B2Null()
		{
			base[tableGPLX.NgayTT_B2Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_CNull()
		{
			return IsNull(tableGPLX.NgayTT_CColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_CNull()
		{
			base[tableGPLX.NgayTT_CColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_DNull()
		{
			return IsNull(tableGPLX.NgayTT_DColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_DNull()
		{
			base[tableGPLX.NgayTT_DColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_ENull()
		{
			return IsNull(tableGPLX.NgayTT_EColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_ENull()
		{
			base[tableGPLX.NgayTT_EColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_FNull()
		{
			return IsNull(tableGPLX.NgayTT_FColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_FNull()
		{
			base[tableGPLX.NgayTT_FColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_FB2Null()
		{
			return IsNull(tableGPLX.NgayTT_FB2Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_FB2Null()
		{
			base[tableGPLX.NgayTT_FB2Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_FCNull()
		{
			return IsNull(tableGPLX.NgayTT_FCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_FCNull()
		{
			base[tableGPLX.NgayTT_FCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_FDNull()
		{
			return IsNull(tableGPLX.NgayTT_FDColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_FDNull()
		{
			base[tableGPLX.NgayTT_FDColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_FENull()
		{
			return IsNull(tableGPLX.NgayTT_FEColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_FENull()
		{
			base[tableGPLX.NgayTT_FEColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsMaLoNull()
		{
			return IsNull(tableGPLX.MaLoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetMaLoNull()
		{
			base[tableGPLX.MaLoColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsSignedDataNull()
		{
			return IsNull(tableGPLX.SignedDataColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetSignedDataNull()
		{
			base[tableGPLX.SignedDataColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsVerifyKeyNull()
		{
			return IsNull(tableGPLX.VerifyKeyColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetVerifyKeyNull()
		{
			base[tableGPLX.VerifyKeyColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsHangGplxInNull()
		{
			return IsNull(tableGPLX.HangGplxInColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetHangGplxInNull()
		{
			base[tableGPLX.HangGplxInColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTTInNull()
		{
			return IsNull(tableGPLX.NgayTTInColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTTInNull()
		{
			base[tableGPLX.NgayTTInColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsErrorMsgNull()
		{
			return IsNull(tableGPLX.ErrorMsgColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetErrorMsgNull()
		{
			base[tableGPLX.ErrorMsgColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsDateErrorNull()
		{
			return IsNull(tableGPLX.DateErrorColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetDateErrorNull()
		{
			base[tableGPLX.DateErrorColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsMaLoaiHosoNull()
		{
			return IsNull(tableGPLX.MaLoaiHosoColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetMaLoaiHosoNull()
		{
			base[tableGPLX.MaLoaiHosoColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_B11Null()
		{
			return IsNull(tableGPLX.NgayTT_B11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_B11Null()
		{
			base[tableGPLX.NgayTT_B11Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsROW_VERSIONNull()
		{
			return IsNull(tableGPLX.ROW_VERSIONColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetROW_VERSIONNull()
		{
			base[tableGPLX.ROW_VERSIONColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_B12Null()
		{
			return IsNull(tableGPLX.NgayTT_B12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_B12Null()
		{
			base[tableGPLX.NgayTT_B12Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_B13Null()
		{
			return IsNull(tableGPLX.NgayTT_B13Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_B13Null()
		{
			base[tableGPLX.NgayTT_B13Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_A11Null()
		{
			return IsNull(tableGPLX.NgayTT_A11Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_A11Null()
		{
			base[tableGPLX.NgayTT_A11Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_A12Null()
		{
			return IsNull(tableGPLX.NgayTT_A12Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_A12Null()
		{
			base[tableGPLX.NgayTT_A12Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsSO_CMND_CUNull()
		{
			return IsNull(tableGPLX.SO_CMND_CUColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetSO_CMND_CUNull()
		{
			base[tableGPLX.SO_CMND_CUColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_B14Null()
		{
			return IsNull(tableGPLX.NgayTT_B14Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_B14Null()
		{
			base[tableGPLX.NgayTT_B14Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNgayTT_B15Null()
		{
			return IsNull(tableGPLX.NgayTT_B15Column);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNgayTT_B15Null()
		{
			base[tableGPLX.NgayTT_B15Column] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsHoVaTenInNull()
		{
			return IsNull(tableGPLX.HoVaTenInColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetHoVaTenInNull()
		{
			base[tableGPLX.HoVaTenInColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNoiTTNull()
		{
			return IsNull(tableGPLX.NoiTTColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNoiTTNull()
		{
			base[tableGPLX.NoiTTColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNoiTT_MaDVHCNull()
		{
			return IsNull(tableGPLX.NoiTT_MaDVHCColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNoiTT_MaDVHCNull()
		{
			base[tableGPLX.NoiTT_MaDVHCColumn] = Convert.DBNull;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsNoiTT_MaDVQLNull()
		{
			return IsNull(tableGPLX.NoiTT_MaDVQLColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetNoiTT_MaDVQLNull()
		{
			base[tableGPLX.NoiTT_MaDVQLColumn] = Convert.DBNull;
		}
	}

	public class DM_DonViGTVTRow : DataRow
	{
		private DM_DonViGTVTDataTable tableDM_DonViGTVT;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string MaDV
		{
			get
			{
				return (string)base[tableDM_DonViGTVT.MaDVColumn];
			}
			set
			{
				base[tableDM_DonViGTVT.MaDVColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string LoaiDV
		{
			get
			{
				return (string)base[tableDM_DonViGTVT.LoaiDVColumn];
			}
			set
			{
				base[tableDM_DonViGTVT.LoaiDVColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public string TenDV
		{
			get
			{
				try
				{
					return (string)base[tableDM_DonViGTVT.TenDVColumn];
				}
				catch (InvalidCastException innerException)
				{
					throw new StrongTypingException("The value for column 'TenDV' in table 'DM_DonViGTVT' is DBNull.", innerException);
				}
			}
			set
			{
				base[tableDM_DonViGTVT.TenDVColumn] = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		internal DM_DonViGTVTRow(DataRowBuilder rb)
			: base(rb)
		{
			tableDM_DonViGTVT = (DM_DonViGTVTDataTable)base.Table;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public bool IsTenDVNull()
		{
			return IsNull(tableDM_DonViGTVT.TenDVColumn);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public void SetTenDVNull()
		{
			base[tableDM_DonViGTVT.TenDVColumn] = Convert.DBNull;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class GPLXRowChangeEvent : EventArgs
	{
		private GPLXRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public GPLXRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public GPLXRowChangeEvent(GPLXRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public class DM_DonViGTVTRowChangeEvent : EventArgs
	{
		private DM_DonViGTVTRow eventRow;

		private DataRowAction eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DM_DonViGTVTRow Row => eventRow;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DataRowAction Action => eventAction;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
		public DM_DonViGTVTRowChangeEvent(DM_DonViGTVTRow row, DataRowAction action)
		{
			eventRow = row;
			eventAction = action;
		}
	}

	private GPLXDataTable tableGPLX;

	private DM_DonViGTVTDataTable tableDM_DonViGTVT;

	private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public GPLXDataTable GPLX => tableGPLX;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(false)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
	public DM_DonViGTVTDataTable DM_DonViGTVT => tableDM_DonViGTVT;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[Browsable(true)]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
	public override SchemaSerializationMode SchemaSerializationMode
	{
		get
		{
			return _schemaSerializationMode;
		}
		set
		{
			_schemaSerializationMode = value;
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataTableCollection Tables => base.Tables;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public new DataRelationCollection Relations => base.Relations;

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public GPLX_TWDataSet()
	{
		BeginInit();
		InitClass();
		CollectionChangeEventHandler value = SchemaChanged;
		base.Tables.CollectionChanged += value;
		base.Relations.CollectionChanged += value;
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected GPLX_TWDataSet(SerializationInfo info, StreamingContext context)
		: base(info, context, ConstructSchema: false)
	{
		if (IsBinarySerialized(info, context))
		{
			InitVars(initTable: false);
			CollectionChangeEventHandler value = SchemaChanged;
			Tables.CollectionChanged += value;
			Relations.CollectionChanged += value;
			return;
		}
		string s = (string)info.GetValue("XmlSchema", typeof(string));
		if (DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
		{
			DataSet dataSet = new DataSet();
			dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(s)));
			if (dataSet.Tables["GPLX"] != null)
			{
				base.Tables.Add(new GPLXDataTable(dataSet.Tables["GPLX"]));
			}
			if (dataSet.Tables["DM_DonViGTVT"] != null)
			{
				base.Tables.Add(new DM_DonViGTVTDataTable(dataSet.Tables["DM_DonViGTVT"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXmlSchema(new XmlTextReader(new StringReader(s)));
		}
		GetSerializationData(info, context);
		CollectionChangeEventHandler value2 = SchemaChanged;
		base.Tables.CollectionChanged += value2;
		Relations.CollectionChanged += value2;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override void InitializeDerivedDataSet()
	{
		BeginInit();
		InitClass();
		EndInit();
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public override DataSet Clone()
	{
		GPLX_TWDataSet gPLX_TWDataSet = (GPLX_TWDataSet)base.Clone();
		gPLX_TWDataSet.InitVars();
		gPLX_TWDataSet.SchemaSerializationMode = SchemaSerializationMode;
		return gPLX_TWDataSet;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override bool ShouldSerializeTables()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override bool ShouldSerializeRelations()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override void ReadXmlSerializable(XmlReader reader)
	{
		if (DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
		{
			Reset();
			DataSet dataSet = new DataSet();
			dataSet.ReadXml(reader);
			if (dataSet.Tables["GPLX"] != null)
			{
				base.Tables.Add(new GPLXDataTable(dataSet.Tables["GPLX"]));
			}
			if (dataSet.Tables["DM_DonViGTVT"] != null)
			{
				base.Tables.Add(new DM_DonViGTVTDataTable(dataSet.Tables["DM_DonViGTVT"]));
			}
			base.DataSetName = dataSet.DataSetName;
			base.Prefix = dataSet.Prefix;
			base.Namespace = dataSet.Namespace;
			base.Locale = dataSet.Locale;
			base.CaseSensitive = dataSet.CaseSensitive;
			base.EnforceConstraints = dataSet.EnforceConstraints;
			Merge(dataSet, preserveChanges: false, MissingSchemaAction.Add);
			InitVars();
		}
		else
		{
			ReadXml(reader);
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	protected override XmlSchema GetSchemaSerializable()
	{
		MemoryStream memoryStream = new MemoryStream();
		WriteXmlSchema(new XmlTextWriter(memoryStream, null));
		memoryStream.Position = 0L;
		return XmlSchema.Read(new XmlTextReader(memoryStream), null);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	internal void InitVars()
	{
		InitVars(initTable: true);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	internal void InitVars(bool initTable)
	{
		tableGPLX = (GPLXDataTable)base.Tables["GPLX"];
		if (initTable && tableGPLX != null)
		{
			tableGPLX.InitVars();
		}
		tableDM_DonViGTVT = (DM_DonViGTVTDataTable)base.Tables["DM_DonViGTVT"];
		if (initTable && tableDM_DonViGTVT != null)
		{
			tableDM_DonViGTVT.InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void InitClass()
	{
		base.DataSetName = "GPLX_TWDataSet";
		base.Prefix = "";
		base.Namespace = "http://tempuri.org/GPLX_TWDataSet.xsd";
		base.EnforceConstraints = true;
		SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
		tableGPLX = new GPLXDataTable();
		base.Tables.Add(tableGPLX);
		tableDM_DonViGTVT = new DM_DonViGTVTDataTable();
		base.Tables.Add(tableDM_DonViGTVT);
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeGPLX()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private bool ShouldSerializeDM_DonViGTVT()
	{
		return false;
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	private void SchemaChanged(object sender, CollectionChangeEventArgs e)
	{
		if (e.Action == CollectionChangeAction.Remove)
		{
			InitVars();
		}
	}

	[DebuggerNonUserCode]
	[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "17.0.0.0")]
	public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
	{
		GPLX_TWDataSet gPLX_TWDataSet = new GPLX_TWDataSet();
		XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
		XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
		XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
		xmlSchemaAny.Namespace = gPLX_TWDataSet.Namespace;
		xmlSchemaSequence.Items.Add(xmlSchemaAny);
		xmlSchemaComplexType.Particle = xmlSchemaSequence;
		XmlSchema schemaSerializable = gPLX_TWDataSet.GetSchemaSerializable();
		if (xs.Contains(schemaSerializable.TargetNamespace))
		{
			MemoryStream memoryStream = new MemoryStream();
			MemoryStream memoryStream2 = new MemoryStream();
			try
			{
				XmlSchema xmlSchema = null;
				schemaSerializable.Write(memoryStream);
				IEnumerator enumerator = xs.Schemas(schemaSerializable.TargetNamespace).GetEnumerator();
				while (enumerator.MoveNext())
				{
					xmlSchema = (XmlSchema)enumerator.Current;
					memoryStream2.SetLength(0L);
					xmlSchema.Write(memoryStream2);
					if (memoryStream.Length == memoryStream2.Length)
					{
						memoryStream.Position = 0L;
						memoryStream2.Position = 0L;
						while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
						{
						}
						if (memoryStream.Position == memoryStream.Length)
						{
							return xmlSchemaComplexType;
						}
					}
				}
			}
			finally
			{
				memoryStream?.Close();
				memoryStream2?.Close();
			}
		}
		xs.Add(schemaSerializable);
		return xmlSchemaComplexType;
	}
}
