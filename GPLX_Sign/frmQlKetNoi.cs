using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using GPLX.COMMON;

namespace GPLX_Sign;

public class frmQlKetNoi : Form
{
	private const string CONSTRING_KEY = "GPLX_Sign.Properties.Settings.GPLX_TWConnectionString";

	private IContainer components = null;

	private Button btnThoat;

	private Label label1;

	private Label label2;

	private TextBox txtMatKhau;

	private Button btnLuu;

	private Label label4;

	private TextBox txtTenTaiKhoan;

	private Label label3;

	private TextBox txtTenCSDL;

	private TextBox txtDiaChiMayChu;

	public frmQlKetNoi()
	{
		InitializeComponent();
	}

	private void frmQlKetNoi_Load(object sender, EventArgs e)
	{
		try
		{
			txtDiaChiMayChu.Focus();
			string constring = Utils.GetConstring("GPLX_Sign.Properties.Settings.GPLX_TWConnectionString");
			constring = constring.Replace("Data Source=", "");
			constring = constring.Replace(";Initial Catalog=", "|");
			constring = constring.Replace(";Persist Security Info=True", "");
			constring = constring.Replace(";User ID=", "|");
			constring = constring.Replace(";Password=", "|");
			string[] array = constring.Split('|');
			txtDiaChiMayChu.Text = array[0].Trim();
			txtTenCSDL.Text = array[1].Trim();
			txtTenTaiKhoan.Text = array[2].Trim();
			txtMatKhau.Text = array[3].Trim();
			btnThoat.Visible = true;
		}
		catch
		{
		}
	}

	protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
	{
		if (keyData == Keys.Escape)
		{
			Dispose();
		}
		return base.ProcessCmdKey(ref msg, keyData);
	}

	private void btnThoat_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void btnLuu_Click(object sender, EventArgs e)
	{
		try
		{
			string text = $"Data Source={Utils.Encrypt(txtDiaChiMayChu.Text.Trim())};Initial Catalog={Utils.Encrypt(txtTenCSDL.Text.Trim())};Persist Security Info=True;User ID={Utils.Encrypt(txtTenTaiKhoan.Text.Trim())};Password={Utils.Encrypt(txtMatKhau.Text.Trim())}";
			string strConstring = $"Data Source={txtDiaChiMayChu.Text.Trim()};Initial Catalog={txtTenCSDL.Text.Trim()};Persist Security Info=True;User ID={txtTenTaiKhoan.Text.Trim()};Password={txtMatKhau.Text.Trim()}";
			if (!KiemTraKetNoi(strConstring))
			{
				MessageBox.Show("Không kết nối được tới cơ sở dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				txtDiaChiMayChu.Focus();
			}
			else if (Utils.ChangeConstrings(strConstring, "GPLX_Sign.Properties.Settings.GPLX_TWConnectionString"))
			{
				MessageBox.Show("Lưu thành công chuỗi kết nối", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				btnThoat_Click(null, null);
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra trong quá trình lưu vào CSDL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				txtDiaChiMayChu.Focus();
			}
		}
		catch
		{
			MessageBox.Show("Có lỗi xảy ra trong quá trình lưu vào CSDL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			txtDiaChiMayChu.Focus();
		}
	}

	private bool KiemTraKetNoi(string strConstring)
	{
		try
		{
			using SqlConnection sqlConnection = new SqlConnection(strConstring);
			sqlConnection.Open();
			return sqlConnection.State == ConnectionState.Open;
		}
		catch (SqlException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.btnThoat = new System.Windows.Forms.Button();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.txtMatKhau = new System.Windows.Forms.TextBox();
		this.btnLuu = new System.Windows.Forms.Button();
		this.label4 = new System.Windows.Forms.Label();
		this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.txtTenCSDL = new System.Windows.Forms.TextBox();
		this.txtDiaChiMayChu = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnThoat.Location = new System.Drawing.Point(268, 164);
		this.btnThoat.Name = "btnThoat";
		this.btnThoat.Size = new System.Drawing.Size(84, 32);
		this.btnThoat.TabIndex = 22;
		this.btnThoat.Text = "&Thoát";
		this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnThoat.UseVisualStyleBackColor = true;
		this.btnThoat.Visible = false;
		this.btnThoat.Click += new System.EventHandler(btnThoat_Click);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(68, 41);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(92, 14);
		this.label1.TabIndex = 23;
		this.label1.Text = "Địa chỉ máy chủ";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(99, 71);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(61, 14);
		this.label2.TabIndex = 24;
		this.label2.Text = "Tên CSDL";
		this.txtMatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtMatKhau.Location = new System.Drawing.Point(178, 124);
		this.txtMatKhau.Name = "txtMatKhau";
		this.txtMatKhau.PasswordChar = '*';
		this.txtMatKhau.Size = new System.Drawing.Size(299, 22);
		this.txtMatKhau.TabIndex = 20;
		this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnLuu.Location = new System.Drawing.Point(178, 164);
		this.btnLuu.Name = "btnLuu";
		this.btnLuu.Size = new System.Drawing.Size(84, 32);
		this.btnLuu.TabIndex = 21;
		this.btnLuu.Text = "&Lưu";
		this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
		this.btnLuu.UseVisualStyleBackColor = true;
		this.btnLuu.Click += new System.EventHandler(btnLuu_Click);
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(103, 131);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(57, 14);
		this.label4.TabIndex = 26;
		this.label4.Text = "Mật khẩu";
		this.txtTenTaiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtTenTaiKhoan.Location = new System.Drawing.Point(178, 95);
		this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
		this.txtTenTaiKhoan.Size = new System.Drawing.Size(299, 22);
		this.txtTenTaiKhoan.TabIndex = 19;
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(100, 102);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(60, 14);
		this.label3.TabIndex = 25;
		this.label3.Text = "Tài khoản";
		this.txtTenCSDL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtTenCSDL.Location = new System.Drawing.Point(178, 64);
		this.txtTenCSDL.Name = "txtTenCSDL";
		this.txtTenCSDL.Size = new System.Drawing.Size(299, 22);
		this.txtTenCSDL.TabIndex = 18;
		this.txtDiaChiMayChu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
		this.txtDiaChiMayChu.Location = new System.Drawing.Point(178, 34);
		this.txtDiaChiMayChu.Name = "txtDiaChiMayChu";
		this.txtDiaChiMayChu.Size = new System.Drawing.Size(299, 22);
		this.txtDiaChiMayChu.TabIndex = 17;
		base.AutoScaleDimensions = new System.Drawing.SizeF(7f, 14f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new System.Drawing.Size(544, 223);
		base.Controls.Add(this.btnThoat);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.txtMatKhau);
		base.Controls.Add(this.btnLuu);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.txtTenTaiKhoan);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.txtTenCSDL);
		base.Controls.Add(this.txtDiaChiMayChu);
		this.Font = new System.Drawing.Font("Tahoma", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.MinimizeBox = false;
		base.Name = "frmQlKetNoi";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Quản lý kết nối CSDL";
		base.Load += new System.EventHandler(frmQlKetNoi_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
