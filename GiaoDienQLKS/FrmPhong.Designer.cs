
namespace GiaoDienQLKS
{
    partial class FrmPhong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btThem = new System.Windows.Forms.ToolStripButton();
            this.btSua = new System.Windows.Forms.ToolStripButton();
            this.btLuu = new System.Windows.Forms.ToolStripButton();
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.btBoqua = new System.Windows.Forms.ToolStripButton();
            this.btThoat = new System.Windows.Forms.ToolStripButton();
            this.gcPhong = new DevExpress.XtraGrid.GridControl();
            this.gvPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MAPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENPHONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TRANGTHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MALP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ckTrangthai = new System.Windows.Forms.CheckBox();
            this.txtDongia = new System.Windows.Forms.TextBox();
            this.txtTenphong = new System.Windows.Forms.TextBox();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.cbMalp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btThem,
            this.btSua,
            this.btXoa,
            this.btLuu,
            this.btBoqua,
            this.btThoat});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1148, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btThem
            // 
            this.btThem.Image = global::GiaoDienQLKS.Properties.Resources._246130847_468891440991176_3234327469697315953_n;
            this.btThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(50, 44);
            this.btThem.Text = "Thêm";
            this.btThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Image = global::GiaoDienQLKS.Properties.Resources._246373727_588160059162528_5593937301632022831_n;
            this.btSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(38, 44);
            this.btSua.Text = "Sửa";
            this.btSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btLuu
            // 
            this.btLuu.Image = global::GiaoDienQLKS.Properties.Resources._246583716_405854201046583_4378044928147575928_n;
            this.btLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(37, 44);
            this.btLuu.Text = "Lưu";
            this.btLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btXoa
            // 
            this.btXoa.Image = global::GiaoDienQLKS.Properties.Resources._246476992_198455759093156_3024265263960661329_n;
            this.btXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(39, 44);
            this.btXoa.Text = "Xóa";
            this.btXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btBoqua
            // 
            this.btBoqua.Image = global::GiaoDienQLKS.Properties.Resources._246024307_382193433619508_247342697742012969_n;
            this.btBoqua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btBoqua.Name = "btBoqua";
            this.btBoqua.Size = new System.Drawing.Size(60, 44);
            this.btBoqua.Text = "Bỏ qua";
            this.btBoqua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btBoqua.Click += new System.EventHandler(this.btBoqua_Click);
            // 
            // btThoat
            // 
            this.btThoat.Image = global::GiaoDienQLKS.Properties.Resources._245924269_244620910865564_7492964276496436695_n;
            this.btThoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(51, 44);
            this.btThoat.Text = "Thoát";
            this.btThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // gcPhong
            // 
            this.gcPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhong.Location = new System.Drawing.Point(0, 47);
            this.gcPhong.MainView = this.gvPhong;
            this.gcPhong.Name = "gcPhong";
            this.gcPhong.Size = new System.Drawing.Size(1148, 175);
            this.gcPhong.TabIndex = 0;
            this.gcPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPhong});
            // 
            // gvPhong
            // 
            this.gvPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MAPHONG,
            this.TENPHONG,
            this.TRANGTHAI,
            this.MALP,
            this.DONGIA});
            this.gvPhong.GridControl = this.gcPhong;
            this.gvPhong.Name = "gvPhong";
            this.gvPhong.OptionsView.ShowGroupPanel = false;
            this.gvPhong.Click += new System.EventHandler(this.gvPhong_Click);
            // 
            // MAPHONG
            // 
            this.MAPHONG.Caption = "MÃ PHÒNG";
            this.MAPHONG.FieldName = "MAPHONG";
            this.MAPHONG.MinWidth = 25;
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.Visible = true;
            this.MAPHONG.VisibleIndex = 3;
            this.MAPHONG.Width = 94;
            // 
            // TENPHONG
            // 
            this.TENPHONG.Caption = "TÊN PHÒNG";
            this.TENPHONG.FieldName = "TENPHONG";
            this.TENPHONG.MinWidth = 25;
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.Visible = true;
            this.TENPHONG.VisibleIndex = 1;
            this.TENPHONG.Width = 94;
            // 
            // TRANGTHAI
            // 
            this.TRANGTHAI.Caption = "TRẠNG THÁI PHÒNG";
            this.TRANGTHAI.FieldName = "TRANGTHAIPHONG";
            this.TRANGTHAI.MinWidth = 25;
            this.TRANGTHAI.Name = "TRANGTHAI";
            this.TRANGTHAI.Visible = true;
            this.TRANGTHAI.VisibleIndex = 2;
            this.TRANGTHAI.Width = 94;
            // 
            // MALP
            // 
            this.MALP.Caption = "MÃ LOẠI PHÒNG";
            this.MALP.FieldName = "MALP";
            this.MALP.MinWidth = 25;
            this.MALP.Name = "MALP";
            this.MALP.Visible = true;
            this.MALP.VisibleIndex = 0;
            this.MALP.Width = 94;
            // 
            // DONGIA
            // 
            this.DONGIA.Caption = "ĐƠN GIÁ";
            this.DONGIA.FieldName = "DONGIA";
            this.DONGIA.MinWidth = 25;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Visible = true;
            this.DONGIA.VisibleIndex = 4;
            this.DONGIA.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ckTrangthai);
            this.groupControl1.Controls.Add(this.txtDongia);
            this.groupControl1.Controls.Add(this.txtTenphong);
            this.groupControl1.Controls.Add(this.txtMaphong);
            this.groupControl1.Controls.Add(this.cbMalp);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 222);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1148, 331);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin";
            // 
            // ckTrangthai
            // 
            this.ckTrangthai.AutoSize = true;
            this.ckTrangthai.Location = new System.Drawing.Point(600, 115);
            this.ckTrangthai.Name = "ckTrangthai";
            this.ckTrangthai.Size = new System.Drawing.Size(95, 21);
            this.ckTrangthai.TabIndex = 3;
            this.ckTrangthai.Text = "Trạng Thái";
            this.ckTrangthai.UseVisualStyleBackColor = true;
            // 
            // txtDongia
            // 
            this.txtDongia.Location = new System.Drawing.Point(155, 156);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.Size = new System.Drawing.Size(316, 23);
            this.txtDongia.TabIndex = 3;
            // 
            // txtTenphong
            // 
            this.txtTenphong.Location = new System.Drawing.Point(155, 113);
            this.txtTenphong.Name = "txtTenphong";
            this.txtTenphong.Size = new System.Drawing.Size(316, 23);
            this.txtTenphong.TabIndex = 2;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(155, 60);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(316, 23);
            this.txtMaphong.TabIndex = 1;
            // 
            // cbMalp
            // 
            this.cbMalp.FormattingEnabled = true;
            this.cbMalp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbMalp.Location = new System.Drawing.Point(700, 59);
            this.cbMalp.Name = "cbMalp";
            this.cbMalp.Size = new System.Drawing.Size(165, 24);
            this.cbMalp.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(597, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã Loại Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Phòng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng";
            // 
            // FrmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 553);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcPhong);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmPhong";
            this.Text = "FrmPhong";
            this.Load += new System.EventHandler(this.FrmPhong_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btThem;
        private System.Windows.Forms.ToolStripButton btSua;
        private System.Windows.Forms.ToolStripButton btLuu;
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStripButton btBoqua;
        private System.Windows.Forms.ToolStripButton btThoat;
        private DevExpress.XtraGrid.GridControl gcPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gvPhong;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMalp;
        private System.Windows.Forms.TextBox txtDongia;
        private System.Windows.Forms.TextBox txtTenphong;
        private System.Windows.Forms.TextBox txtMaphong;
        private DevExpress.XtraGrid.Columns.GridColumn MAPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TENPHONG;
        private DevExpress.XtraGrid.Columns.GridColumn TRANGTHAI;
        private DevExpress.XtraGrid.Columns.GridColumn MALP;
        private DevExpress.XtraGrid.Columns.GridColumn DONGIA;
        private System.Windows.Forms.CheckBox ckTrangthai;
    }
}