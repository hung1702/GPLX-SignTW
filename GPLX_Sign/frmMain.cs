using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using GPLX.COMMON;
using GPLX_Sign.Cryptography;
using GPLX_Sign.GPLX_TWDataSetTableAdapters;

namespace GPLX_Sign;

public class frmMain : Form
{
    private const string CONSTRING_KEY = "GPLX_Sign.Properties.Settings.GPLX_TWConnectionString";

    private string currentSign = "";

    private int totalData = 0;

    private X509Certificate2 cert = null;

    private IContainer components = null;

    private MenuStrip menuStripMain;

    private ToolStripMenuItem hệThốngToolStripMenuItem;

    private ToolStripMenuItem cấuHìnhKếtNốiCSDLToolStripMenuItem;

    private ToolStripSeparator toolStripSeparator2;

    private ToolStripMenuItem thoátToolStripMenuItem;

    private GPLX_TWDataSet gPLX_TWDataSet;

    private BindingSource gPLXBindingSource;

    private GPLXTableAdapter gPLXTableAdapter;

    private TableAdapterManager tableAdapterManager;

    private DataGridView gPLXDataGridView;

    private ToolStrip tsFooter;

    private ToolStripButton toolStripButton1;

    private ToolStripSeparator toolStripSeparator3;

    private Panel panel1;

    private Panel panel2;

    private DateTimePicker dtFromDate;

    private Label label1;

    private DateTimePicker dtToDate;

    private Label label2;

    private Button btnSign;

    private ToolStripLabel toolStripLabel2;

    private ToolStripLabel lblTotal;

    private ToolStripSeparator toolStripSeparator4;

    private ToolStripComboBox cbxKey;

    private ToolStripLabel toolStripLabel1;

    private BackgroundWorker bgWorker;

    private ToolStripSeparator toolStripSeparator5;

    private ProgressBar tsProgressBar;

    private Label label3;

    private Label label4;

    private Label lblCurrentProfile;

    private Panel panelProgress;

    private Label lblPercents;

    private Panel panelFilter;

    private ComboBox comboBoxMaLo;

    private Label label5;

    private ToolStripMenuItem nạpDữLiệuToolStripMenuItem;

    private ToolStripMenuItem nạpLạiChữKýToolStripMenuItem;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn53;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn26;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn38;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn54;

    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn55;

    private Label label6;

    private ComboBox comboBox1;

    private GPLX_TWDataSet gPLX_TWDataSet1;

    private BindingSource dMDonViGTVTBindingSource;

    private DM_DonViGTVTTableAdapter dM_DonViGTVTTableAdapter;

    public frmMain()
    {
        InitializeComponent();
    }

    private void cấuHìnhKếtNốiCSDLToolStripMenuItem_Click(object sender, EventArgs e)
    {
        frmQlKetNoi frmQlKetNoi2 = new frmQlKetNoi();
        frmQlKetNoi2.ShowDialog();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
        this.gPLXTableAdapter.Adapter.UpdateCommand.CommandTimeout = 300;
        this.gPLXTableAdapter.Adapter.InsertCommand.CommandTimeout = 300;
        this.gPLXTableAdapter.Adapter.DeleteCommand.CommandTimeout = 300;

        this.gPLXDataGridView.DataError += gPLXDataGridView_DataError;

        dM_DonViGTVTTableAdapter.Fill(gPLX_TWDataSet1.DM_DonViGTVT);
        List<string> x509CertificatedNames = CryptographyHelper.GetX509CertificatedNames();
        if (x509CertificatedNames != null && x509CertificatedNames.Count > 0)
        {
            foreach (string item in x509CertificatedNames)
            {
                cbxKey.Items.Add(item);
            }
            cbxKey.SelectedIndex = 0;
        }
        else
        {
            cbxKey.Items.Add("Không tồn tại Certificate!");
        }
        dtFromDate.Value = DateTime.Today.AddYears(-10);
        dtToDate.Value = DateTime.Now;
        updateConnection();
        refreshData();
    }

    private void gPLXBindingNavigatorSaveItem_Click(object sender, EventArgs e)
    {
        Validate();
        gPLXBindingSource.EndEdit();
        tableAdapterManager.UpdateAll(gPLX_TWDataSet);
    }

    private void btnSign_Click(object sender, EventArgs e)
    {
        if (cbxKey.SelectedItem != null)
        {
            currentSign = cbxKey.SelectedItem.ToString();
            cert = CryptographyHelper.GetStoreX509Certificate2(currentSign);
            if (!bgWorker.IsBusy)
            {
                tsProgressBar.Maximum = totalData;
                bgWorker.RunWorkerAsync();
                UpdateStatusSign(isSign: true);
            }
            else
            {
                bgWorker.CancelAsync();
            }
        }
    }

    private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
    {
        int batchSize = 200;
        var table = gPLX_TWDataSet.Tables["GPLX"];

        for (int i = 0; i < table.Rows.Count; i++)
        {
            if (bgWorker.CancellationPending)
            {
                e.Cancel = true;
                break;
            }

            DataRow row = table.Rows[i];
            CAInfo caInfo = MapRowToCAInfo(row); // thay Cast<CAInfo> bằng map chuẩn

            caInfo.NgayKy = $"{DateTime.Now:yyyyMMdd}";
            caInfo.MaNguoiKy = "Bộ Công An";

            var cryptographyData = new CryptographyData();
            cryptographyData.SetData(caInfo);
            cryptographyData.SetPropertyList("SoGPLX", "HoVaTen", "MaQuocTich",
                                             "NgaySinh", "NoiCT", "NoiCT",
                                             "HangGPLX", "NgayHHGPLX", "NgayTTGPLX",
                                             "NgayKy", "MaNguoiKy");
            cryptographyData.RSA = new RSACryptography(cert);

            caInfo.Verify = cryptographyData.GetSignedData();
            caInfo.VerifyKey = cryptographyData.RSA.RawData;

            row["SignedData"] = caInfo.Verify;
            row["VerifyKey"] = caInfo.VerifyKey;
            row["NgaySua"] = DateTime.Now;

            lblCurrentProfile.Invoke((MethodInvoker)(() =>
            {
                lblCurrentProfile.Text = caInfo.HoVaTen;
            }));

            gPLXDataGridView.Invoke((MethodInvoker)(() =>
            {
                gPLXDataGridView.Rows[i].Selected = true;
                gPLXDataGridView.Rows[i].Cells[0].Selected = true;
            }));

            bgWorker.ReportProgress(i + 1);

            if (row.RowState == DataRowState.Unchanged)
            {
                row.SetModified();
            }

            // batch update
            if (i > 0 && i % batchSize == 0)
            {
                lock (tableAdapterManager)
                {
                    try
                    {
                        tableAdapterManager.UpdateAll(gPLX_TWDataSet);
                    }
                    catch 
                    {
                    }
                }
            }
        }

        // update nốt phần dư
        lock (tableAdapterManager)
        {
            try
            {
                tableAdapterManager.UpdateAll(gPLX_TWDataSet);
            }
            catch 
            {
            }
        }
    }


    private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
        tsProgressBar.Value = e.ProgressPercentage;
        lblPercents.Text = e.ProgressPercentage * 100 / totalData + "% (" + e.ProgressPercentage + "/" + totalData + ")";
    }

    private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
    {
        //tableAdapterManager.UpdateAll(gPLX_TWDataSet);
        if (e.Cancelled)
        {
            MessageBox.Show("Tiến trình đã bị hủy bỏ.", "Hủy bỏ");
        }
        else if (e.Error != null)
        {
            if (e.Error is System.Data.DBConcurrencyException)
            {
                MessageBox.Show("Tiến trình đã hoàn thành (D)", "Completed");
            }
            else
            {
                MessageBox.Show("Error occurred: " + e.Error.Message);
            }
        }
        //else if (e.Error != null)
        //{
        //	MessageBox.Show("Error occurred: " + e.Error.Message, "Error");
        //}
        else
        {
            MessageBox.Show("Tiến trình đã hoàn thành.", "Completed");
        }
        //refreshData();
        UpdateStatusSign(isSign: false);
    }

    private CAInfo MapRowToCAInfo(DataRow row)
    {
        if (row == null) return null;

        return new CAInfo
        {
            SoGPLX = row["SoGPLX"]?.ToString(),
            HoVaTen = row["HoVaTen"]?.ToString(),
            MaQuocTich = row["MaQuocTich"]?.ToString(),
            NgaySinh = row["NgaySinh"]?.ToString(),
            NoiCT = row["NoiCT"]?.ToString(),
            HangGPLX = row["HangGPLX"]?.ToString(),
            NgayHHGPLX = row["NgayHHGPLX"]?.ToString(),
            NgayTTGPLX = row["NgayTTGPLX"]?.ToString(),
            // Các trường sẽ được set trong DoWork
            NgayKy = row.Table.Columns.Contains("NgayKy") ? row["NgayKy"]?.ToString() : null,
            MaNguoiKy = row.Table.Columns.Contains("MaNguoiKy") ? row["MaNguoiKy"]?.ToString() : null,
            Verify = row.Table.Columns.Contains("SignedData") ? row["SignedData"]?.ToString() : null,
            VerifyKey = row.Table.Columns.Contains("VerifyKey") ? row["VerifyKey"]?.ToString() : null
        };
    }

    private void updateConnection()
    {
        Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        gPLXTableAdapter.Connection = new SqlConnection(configuration.ConnectionStrings.ConnectionStrings["GPLX_Sign.Properties.Settings.GPLX_TWConnectionString"].ConnectionString);
    }

    private void refreshData()
    {
        gPLXTableAdapter.FillBy(gPLX_TWDataSet.GPLX);
        totalData = gPLX_TWDataSet.GPLX.Rows.Count;
        comboBoxMaLo.Items.Add("Tất cả");
        comboBoxMaLo.Items.AddRange((from row in gPLX_TWDataSet.Tables["GPLX"].AsEnumerable()
                                     select row["MaLo"]).Distinct().ToArray());
        comboBoxMaLo.SelectedIndex = 0;
        lblTotal.Text = totalData.ToString("N0");
    }

    private void UpdateStatusSign(bool isSign)
    {
        btnSign.Text = (isSign ? "Dừng ký" : "Bắt đầu ký");
        panelProgress.Visible = isSign;
        panelFilter.Enabled = !isSign;
    }

    private void comboBoxMaLo_SelectedIndexChanged(object sender, EventArgs e)
    {
        updateFilter();
    }

    private void nạpDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
    {
        updateConnection();
        refreshData();
    }

    private void nạpLạiChữKýToolStripMenuItem_Click(object sender, EventArgs e)
    {
        List<string> x509CertificatedNames = CryptographyHelper.GetX509CertificatedNames();
        cbxKey.Items.Clear();
        if (x509CertificatedNames != null && x509CertificatedNames.Count > 0)
        {
            foreach (string item in x509CertificatedNames)
            {
                cbxKey.Items.Add(item);
            }
            cbxKey.SelectedIndex = 0;
        }
        else
        {
            cbxKey.Items.Add("Không tồn tại Certificate!");
        }
    }

    private void updateFilter()
    {
    }

    private string getSqlDate(DateTime date)
    {
        string text = date.Year.ToString() ?? "";
        string text2 = ((date.Month < 10) ? ("0" + date.Month) : (date.Month.ToString() ?? ""));
        string text3 = ((date.Day < 10) ? ("0" + date.Day) : (date.Day.ToString() ?? ""));
        return text + "-" + text2 + "-" + text3 + " 00:00:00";
    }

    private void dtFromDate_ValueChanged(object sender, EventArgs e)
    {
        updateFilter();
    }

    private void dtToDate_ValueChanged(object sender, EventArgs e)
    {
        updateFilter();
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void gPLXDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
    {
        e.ThrowException = false; // ngăn chương trình bị crash
    }

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GPLX_Sign.frmMain));
        this.menuStripMain = new System.Windows.Forms.MenuStrip();
        this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.cấuHìnhKếtNốiCSDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.nạpLạiChữKýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.nạpDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        this.gPLXDataGridView = new System.Windows.Forms.DataGridView();
        this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn53 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn38 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn54 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn55 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.gPLXBindingSource = new System.Windows.Forms.BindingSource(this.components);
        this.gPLX_TWDataSet = new GPLX_Sign.GPLX_TWDataSet();
        this.tsFooter = new System.Windows.Forms.ToolStrip();
        this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
        this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
        this.cbxKey = new System.Windows.Forms.ToolStripComboBox();
        this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
        this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
        this.lblTotal = new System.Windows.Forms.ToolStripLabel();
        this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
        this.panel1 = new System.Windows.Forms.Panel();
        this.panelFilter = new System.Windows.Forms.Panel();
        this.label6 = new System.Windows.Forms.Label();
        this.comboBox1 = new System.Windows.Forms.ComboBox();
        this.dMDonViGTVTBindingSource = new System.Windows.Forms.BindingSource(this.components);
        this.gPLX_TWDataSet1 = new GPLX_Sign.GPLX_TWDataSet();
        this.comboBoxMaLo = new System.Windows.Forms.ComboBox();
        this.label5 = new System.Windows.Forms.Label();
        this.label1 = new System.Windows.Forms.Label();
        this.dtFromDate = new System.Windows.Forms.DateTimePicker();
        this.label2 = new System.Windows.Forms.Label();
        this.dtToDate = new System.Windows.Forms.DateTimePicker();
        this.panelProgress = new System.Windows.Forms.Panel();
        this.lblPercents = new System.Windows.Forms.Label();
        this.tsProgressBar = new System.Windows.Forms.ProgressBar();
        this.lblCurrentProfile = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.label3 = new System.Windows.Forms.Label();
        this.btnSign = new System.Windows.Forms.Button();
        this.panel2 = new System.Windows.Forms.Panel();
        this.bgWorker = new System.ComponentModel.BackgroundWorker();
        this.gPLXTableAdapter = new GPLX_Sign.GPLX_TWDataSetTableAdapters.GPLXTableAdapter();
        this.tableAdapterManager = new GPLX_Sign.GPLX_TWDataSetTableAdapters.TableAdapterManager();
        this.dM_DonViGTVTTableAdapter = new GPLX_Sign.GPLX_TWDataSetTableAdapters.DM_DonViGTVTTableAdapter();
        this.menuStripMain.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.gPLXDataGridView).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.gPLXBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.gPLX_TWDataSet).BeginInit();
        this.tsFooter.SuspendLayout();
        this.panel1.SuspendLayout();
        this.panelFilter.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)this.dMDonViGTVTBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)this.gPLX_TWDataSet1).BeginInit();
        this.panelProgress.SuspendLayout();
        this.panel2.SuspendLayout();
        base.SuspendLayout();
        this.menuStripMain.Font = new System.Drawing.Font("Tahoma", 9f);
        this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[1] { this.hệThốngToolStripMenuItem });
        this.menuStripMain.Location = new System.Drawing.Point(0, 0);
        this.menuStripMain.Name = "menuStripMain";
        this.menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
        this.menuStripMain.Size = new System.Drawing.Size(1004, 24);
        this.menuStripMain.TabIndex = 1;
        this.menuStripMain.Text = "menuStrip1";
        this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[5] { this.cấuHìnhKếtNốiCSDLToolStripMenuItem, this.nạpLạiChữKýToolStripMenuItem, this.nạpDữLiệuToolStripMenuItem, this.toolStripSeparator2, this.thoátToolStripMenuItem });
        this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
        this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
        this.hệThốngToolStripMenuItem.Text = "&Hệ thống";
        this.cấuHìnhKếtNốiCSDLToolStripMenuItem.Name = "cấuHìnhKếtNốiCSDLToolStripMenuItem";
        this.cấuHìnhKếtNốiCSDLToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
        this.cấuHìnhKếtNốiCSDLToolStripMenuItem.Text = "Cấu hình kết nối CSDL";
        this.cấuHìnhKếtNốiCSDLToolStripMenuItem.Click += new System.EventHandler(cấuHìnhKếtNốiCSDLToolStripMenuItem_Click);
        this.nạpLạiChữKýToolStripMenuItem.Name = "nạpLạiChữKýToolStripMenuItem";
        this.nạpLạiChữKýToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
        this.nạpLạiChữKýToolStripMenuItem.Text = "Nạp lại chữ ký";
        this.nạpLạiChữKýToolStripMenuItem.Click += new System.EventHandler(nạpLạiChữKýToolStripMenuItem_Click);
        this.nạpDữLiệuToolStripMenuItem.Name = "nạpDữLiệuToolStripMenuItem";
        this.nạpDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
        this.nạpDữLiệuToolStripMenuItem.Text = "Nạp dữ liệu";
        this.nạpDữLiệuToolStripMenuItem.Click += new System.EventHandler(nạpDữLiệuToolStripMenuItem_Click);
        this.toolStripSeparator2.Name = "toolStripSeparator2";
        this.toolStripSeparator2.Size = new System.Drawing.Size(192, 6);
        this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
        this.thoátToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
        this.thoátToolStripMenuItem.Text = "&Thoát";
        this.gPLXDataGridView.AllowUserToAddRows = false;
        this.gPLXDataGridView.AllowUserToDeleteRows = false;
        this.gPLXDataGridView.AutoGenerateColumns = false;
        this.gPLXDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.gPLXDataGridView.Columns.AddRange(this.dataGridViewTextBoxColumn20, this.dataGridViewTextBoxColumn53, this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3, this.dataGridViewTextBoxColumn5, this.dataGridViewTextBoxColumn21, this.dataGridViewTextBoxColumn23, this.dataGridViewTextBoxColumn26, this.dataGridViewTextBoxColumn38, this.dataGridViewTextBoxColumn54, this.dataGridViewTextBoxColumn55);
        this.gPLXDataGridView.DataSource = this.gPLXBindingSource;
        this.gPLXDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
        this.gPLXDataGridView.Location = new System.Drawing.Point(0, 0);
        this.gPLXDataGridView.Margin = new System.Windows.Forms.Padding(0);
        this.gPLXDataGridView.MultiSelect = false;
        this.gPLXDataGridView.Name = "gPLXDataGridView";
        this.gPLXDataGridView.ReadOnly = true;
        this.gPLXDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.gPLXDataGridView.Size = new System.Drawing.Size(1004, 312);
        this.gPLXDataGridView.TabIndex = 3;
        this.dataGridViewTextBoxColumn20.DataPropertyName = "HoVaTen";
        this.dataGridViewTextBoxColumn20.HeaderText = "HoVaTen";
        this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
        this.dataGridViewTextBoxColumn20.ReadOnly = true;
        this.dataGridViewTextBoxColumn53.DataPropertyName = "MaLo";
        this.dataGridViewTextBoxColumn53.HeaderText = "MaLo";
        this.dataGridViewTextBoxColumn53.Name = "dataGridViewTextBoxColumn53";
        this.dataGridViewTextBoxColumn53.ReadOnly = true;
        this.dataGridViewTextBoxColumn1.DataPropertyName = "MaDangKy";
        this.dataGridViewTextBoxColumn1.HeaderText = "MaDangKy";
        this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn1.ReadOnly = true;
        this.dataGridViewTextBoxColumn2.DataPropertyName = "SoGPLX";
        this.dataGridViewTextBoxColumn2.HeaderText = "SoGPLX";
        this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        this.dataGridViewTextBoxColumn2.ReadOnly = true;
        this.dataGridViewTextBoxColumn3.DataPropertyName = "HangGPLX";
        this.dataGridViewTextBoxColumn3.HeaderText = "HangGPLX";
        this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        this.dataGridViewTextBoxColumn3.ReadOnly = true;
        this.dataGridViewTextBoxColumn5.DataPropertyName = "SoGPLXCu";
        this.dataGridViewTextBoxColumn5.HeaderText = "SoGPLXCu";
        this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        this.dataGridViewTextBoxColumn5.ReadOnly = true;
        this.dataGridViewTextBoxColumn21.DataPropertyName = "NgaySinh";
        this.dataGridViewTextBoxColumn21.HeaderText = "NgaySinh";
        this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
        this.dataGridViewTextBoxColumn21.ReadOnly = true;
        this.dataGridViewTextBoxColumn23.DataPropertyName = "NoiCT";
        this.dataGridViewTextBoxColumn23.HeaderText = "NoiCT";
        this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
        this.dataGridViewTextBoxColumn23.ReadOnly = true;
        this.dataGridViewTextBoxColumn26.DataPropertyName = "SoCMT";
        this.dataGridViewTextBoxColumn26.HeaderText = "SoCMT";
        this.dataGridViewTextBoxColumn26.Name = "dataGridViewTextBoxColumn26";
        this.dataGridViewTextBoxColumn26.ReadOnly = true;
        this.dataGridViewTextBoxColumn38.DataPropertyName = "SoSeri";
        this.dataGridViewTextBoxColumn38.HeaderText = "SoSeri";
        this.dataGridViewTextBoxColumn38.Name = "dataGridViewTextBoxColumn38";
        this.dataGridViewTextBoxColumn38.ReadOnly = true;
        this.dataGridViewTextBoxColumn54.DataPropertyName = "SignedData";
        this.dataGridViewTextBoxColumn54.HeaderText = "SignedData";
        this.dataGridViewTextBoxColumn54.Name = "dataGridViewTextBoxColumn54";
        this.dataGridViewTextBoxColumn54.ReadOnly = true;
        this.dataGridViewTextBoxColumn55.DataPropertyName = "VerifyKey";
        this.dataGridViewTextBoxColumn55.HeaderText = "VerifyKey";
        this.dataGridViewTextBoxColumn55.Name = "dataGridViewTextBoxColumn55";
        this.dataGridViewTextBoxColumn55.ReadOnly = true;
        this.gPLXBindingSource.DataMember = "GPLX";
        this.gPLXBindingSource.DataSource = this.gPLX_TWDataSet;
        this.gPLX_TWDataSet.DataSetName = "GPLX_TWDataSet";
        this.gPLX_TWDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        this.tsFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.tsFooter.Font = new System.Drawing.Font("Tahoma", 8.25f);
        this.tsFooter.Items.AddRange(new System.Windows.Forms.ToolStripItem[8] { this.toolStripButton1, this.toolStripSeparator3, this.toolStripLabel1, this.cbxKey, this.toolStripSeparator4, this.toolStripLabel2, this.lblTotal, this.toolStripSeparator5 });
        this.tsFooter.Location = new System.Drawing.Point(0, 436);
        this.tsFooter.Name = "tsFooter";
        this.tsFooter.Size = new System.Drawing.Size(1004, 25);
        this.tsFooter.TabIndex = 4;
        this.tsFooter.Text = "toolStrip2";
        this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
        this.toolStripButton1.Image = (System.Drawing.Image)resources.GetObject("toolStripButton1.Image");
        this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
        this.toolStripButton1.Name = "toolStripButton1";
        this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
        this.toolStripButton1.Text = "toolStripButton1";
        this.toolStripSeparator3.Name = "toolStripSeparator3";
        this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
        this.toolStripLabel1.Name = "toolStripLabel1";
        this.toolStripLabel1.Size = new System.Drawing.Size(36, 22);
        this.toolStripLabel1.Text = "Token";
        this.cbxKey.CausesValidation = false;
        this.cbxKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.cbxKey.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
        this.cbxKey.Name = "cbxKey";
        this.cbxKey.Size = new System.Drawing.Size(300, 25);
        this.toolStripSeparator4.Name = "toolStripSeparator4";
        this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
        this.toolStripLabel2.Name = "toolStripLabel2";
        this.toolStripLabel2.Size = new System.Drawing.Size(83, 22);
        this.toolStripLabel2.Text = "Tổng số bản ghi";
        this.lblTotal.Font = new System.Drawing.Font("Tahoma", 8.25f, System.Drawing.FontStyle.Bold);
        this.lblTotal.Name = "lblTotal";
        this.lblTotal.Size = new System.Drawing.Size(35, 22);
        this.lblTotal.Text = "1000";
        this.toolStripSeparator5.Name = "toolStripSeparator5";
        this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
        this.panel1.Controls.Add(this.panelFilter);
        this.panel1.Controls.Add(this.panelProgress);
        this.panel1.Controls.Add(this.btnSign);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel1.Location = new System.Drawing.Point(0, 24);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(1004, 100);
        this.panel1.TabIndex = 5;
        this.panelFilter.Controls.Add(this.label6);
        this.panelFilter.Controls.Add(this.comboBox1);
        this.panelFilter.Controls.Add(this.comboBoxMaLo);
        this.panelFilter.Controls.Add(this.label5);
        this.panelFilter.Controls.Add(this.label1);
        this.panelFilter.Controls.Add(this.dtFromDate);
        this.panelFilter.Controls.Add(this.label2);
        this.panelFilter.Controls.Add(this.dtToDate);
        this.panelFilter.Location = new System.Drawing.Point(9, 8);
        this.panelFilter.Name = "panelFilter";
        this.panelFilter.Size = new System.Drawing.Size(509, 83);
        this.panelFilter.TabIndex = 10;
        this.label6.AutoSize = true;
        this.label6.Location = new System.Drawing.Point(215, 52);
        this.label6.Name = "label6";
        this.label6.Size = new System.Drawing.Size(38, 13);
        this.label6.TabIndex = 7;
        this.label6.Text = "Đơn vị";
        this.comboBox1.DataSource = this.dMDonViGTVTBindingSource;
        this.comboBox1.DisplayMember = "TenDV";
        this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBox1.FormattingEnabled = true;
        this.comboBox1.Location = new System.Drawing.Point(259, 47);
        this.comboBox1.Name = "comboBox1";
        this.comboBox1.Size = new System.Drawing.Size(122, 21);
        this.comboBox1.TabIndex = 6;
        this.comboBox1.ValueMember = "MaDV";
        this.dMDonViGTVTBindingSource.DataMember = "DM_DonViGTVT";
        this.dMDonViGTVTBindingSource.DataSource = this.gPLX_TWDataSet1;
        this.gPLX_TWDataSet1.DataSetName = "GPLX_TWDataSet";
        this.gPLX_TWDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        this.comboBoxMaLo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.comboBoxMaLo.FormattingEnabled = true;
        this.comboBoxMaLo.Location = new System.Drawing.Point(259, 14);
        this.comboBoxMaLo.Name = "comboBoxMaLo";
        this.comboBoxMaLo.Size = new System.Drawing.Size(224, 21);
        this.comboBoxMaLo.TabIndex = 5;
        this.comboBoxMaLo.SelectedIndexChanged += new System.EventHandler(comboBoxMaLo_SelectedIndexChanged);
        this.label5.AutoSize = true;
        this.label5.Location = new System.Drawing.Point(215, 18);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(33, 13);
        this.label5.TabIndex = 4;
        this.label5.Text = "Mã lô";
        this.label1.AutoSize = true;
        this.label1.Location = new System.Drawing.Point(18, 18);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(46, 13);
        this.label1.TabIndex = 0;
        this.label1.Text = "Từ ngày";
        this.dtFromDate.CustomFormat = "    dd/MM/yyyy";
        this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtFromDate.Location = new System.Drawing.Point(78, 14);
        this.dtFromDate.Name = "dtFromDate";
        this.dtFromDate.Size = new System.Drawing.Size(107, 20);
        this.dtFromDate.TabIndex = 1;
        this.dtFromDate.ValueChanged += new System.EventHandler(dtFromDate_ValueChanged);
        this.label2.AutoSize = true;
        this.label2.Location = new System.Drawing.Point(18, 52);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(53, 13);
        this.label2.TabIndex = 2;
        this.label2.Text = "Đến ngày";
        this.dtToDate.CustomFormat = "    dd/MM/yyyy";
        this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.dtToDate.Location = new System.Drawing.Point(78, 48);
        this.dtToDate.Name = "dtToDate";
        this.dtToDate.Size = new System.Drawing.Size(107, 20);
        this.dtToDate.TabIndex = 3;
        this.dtToDate.ValueChanged += new System.EventHandler(dtToDate_ValueChanged);
        this.panelProgress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.panelProgress.Controls.Add(this.lblPercents);
        this.panelProgress.Controls.Add(this.tsProgressBar);
        this.panelProgress.Controls.Add(this.lblCurrentProfile);
        this.panelProgress.Controls.Add(this.label4);
        this.panelProgress.Controls.Add(this.label3);
        this.panelProgress.Location = new System.Drawing.Point(531, 8);
        this.panelProgress.Name = "panelProgress";
        this.panelProgress.Size = new System.Drawing.Size(321, 83);
        this.panelProgress.TabIndex = 9;
        this.panelProgress.Visible = false;
        this.lblPercents.AutoSize = true;
        this.lblPercents.BackColor = System.Drawing.Color.Transparent;
        this.lblPercents.Location = new System.Drawing.Point(183, 18);
        this.lblPercents.Name = "lblPercents";
        this.lblPercents.Size = new System.Drawing.Size(24, 13);
        this.lblPercents.TabIndex = 10;
        this.lblPercents.Text = "0 %";
        this.tsProgressBar.Location = new System.Drawing.Point(99, 13);
        this.tsProgressBar.Name = "tsProgressBar";
        this.tsProgressBar.Size = new System.Drawing.Size(219, 23);
        this.tsProgressBar.TabIndex = 7;
        this.lblCurrentProfile.ForeColor = System.Drawing.SystemColors.Highlight;
        this.lblCurrentProfile.Location = new System.Drawing.Point(96, 53);
        this.lblCurrentProfile.Name = "lblCurrentProfile";
        this.lblCurrentProfile.Size = new System.Drawing.Size(220, 19);
        this.lblCurrentProfile.TabIndex = 8;
        this.lblCurrentProfile.Text = "Nguyen Van A";
        this.label4.AutoSize = true;
        this.label4.Location = new System.Drawing.Point(47, 19);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(44, 13);
        this.label4.TabIndex = 5;
        this.label4.Text = "Tiến độ";
        this.label3.AutoSize = true;
        this.label3.Location = new System.Drawing.Point(4, 53);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(87, 13);
        this.label3.TabIndex = 6;
        this.label3.Text = "Hồ sơ đang xử lý";
        this.btnSign.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
        this.btnSign.Location = new System.Drawing.Point(860, 14);
        this.btnSign.Name = "btnSign";
        this.btnSign.Size = new System.Drawing.Size(130, 71);
        this.btnSign.TabIndex = 4;
        this.btnSign.Text = "Bắt đầu ký";
        this.btnSign.UseVisualStyleBackColor = true;
        this.btnSign.Click += new System.EventHandler(btnSign_Click);
        this.panel2.Controls.Add(this.gPLXDataGridView);
        this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel2.Location = new System.Drawing.Point(0, 124);
        this.panel2.Margin = new System.Windows.Forms.Padding(0);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(1004, 312);
        this.panel2.TabIndex = 6;
        this.bgWorker.WorkerReportsProgress = true;
        this.bgWorker.WorkerSupportsCancellation = true;
        this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(bgWorker_DoWork);
        this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(bgWorker_ProgressChanged);
        this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(bgWorker_RunWorkerCompleted);
        this.gPLXTableAdapter.ClearBeforeFill = true;
        this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
        this.tableAdapterManager.DM_DonViGTVTTableAdapter = null;
        this.tableAdapterManager.GPLXTableAdapter = this.gPLXTableAdapter;
        this.tableAdapterManager.UpdateOrder = GPLX_Sign.GPLX_TWDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
        this.dM_DonViGTVTTableAdapter.ClearBeforeFill = true;
        base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
        base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        base.ClientSize = new System.Drawing.Size(1004, 461);
        base.Controls.Add(this.panel2);
        base.Controls.Add(this.panel1);
        base.Controls.Add(this.tsFooter);
        base.Controls.Add(this.menuStripMain);
        base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
        this.MinimumSize = new System.Drawing.Size(1020, 500);
        base.Name = "frmMain";
        base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Ký số tập trung";
        base.Load += new System.EventHandler(frmMain_Load);
        this.menuStripMain.ResumeLayout(false);
        this.menuStripMain.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.gPLXDataGridView).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.gPLXBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.gPLX_TWDataSet).EndInit();
        this.tsFooter.ResumeLayout(false);
        this.tsFooter.PerformLayout();
        this.panel1.ResumeLayout(false);
        this.panelFilter.ResumeLayout(false);
        this.panelFilter.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)this.dMDonViGTVTBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)this.gPLX_TWDataSet1).EndInit();
        this.panelProgress.ResumeLayout(false);
        this.panelProgress.PerformLayout();
        this.panel2.ResumeLayout(false);
        base.ResumeLayout(false);
        base.PerformLayout();
    }
}
