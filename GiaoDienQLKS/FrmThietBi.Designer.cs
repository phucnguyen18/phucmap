
namespace GiaoDienQLKS
{
    partial class FrmThietBi
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
            this.btXoa = new System.Windows.Forms.ToolStripButton();
            this.btLuu = new System.Windows.Forms.ToolStripButton();
            this.btBoqua = new System.Windows.Forms.ToolStripButton();
            this.btThoat = new System.Windows.Forms.ToolStripButton();
            this.gcThietBi = new DevExpress.XtraGrid.GridControl();
            this.gvThietBi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.MA_TB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TEN_TB = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DON_GIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtTenThietBi = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaThietBi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThietBi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThietBi)).BeginInit();
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
            this.toolStrip1.Size = new System.Drawing.Size(1123, 47);
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
            // btLuu
            // 
            this.btLuu.Image = global::GiaoDienQLKS.Properties.Resources._246583716_405854201046583_4378044928147575928_n;
            this.btLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(37, 44);
            this.btLuu.Text = "Lưu";
            this.btLuu.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.btLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
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
            // gcThietBi
            // 
            this.gcThietBi.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcThietBi.Location = new System.Drawing.Point(0, 47);
            this.gcThietBi.MainView = this.gvThietBi;
            this.gcThietBi.Name = "gcThietBi";
            this.gcThietBi.Size = new System.Drawing.Size(1123, 266);
            this.gcThietBi.TabIndex = 6;
            this.gcThietBi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvThietBi});
            // 
            // gvThietBi
            // 
            this.gvThietBi.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.MA_TB,
            this.TEN_TB,
            this.DON_GIA});
            this.gvThietBi.GridControl = this.gcThietBi;
            this.gvThietBi.Name = "gvThietBi";
            this.gvThietBi.OptionsSelection.MultiSelect = true;
            this.gvThietBi.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gvThietBi.OptionsView.ShowGroupPanel = false;
            this.gvThietBi.Click += new System.EventHandler(this.gvThietBi_Click);
            // 
            // MA_TB
            // 
            this.MA_TB.Caption = "MÃ THIẾT BỊ";
            this.MA_TB.FieldName = "MATB";
            this.MA_TB.MaxWidth = 175;
            this.MA_TB.MinWidth = 87;
            this.MA_TB.Name = "MA_TB";
            this.MA_TB.Visible = true;
            this.MA_TB.VisibleIndex = 1;
            this.MA_TB.Width = 87;
            // 
            // TEN_TB
            // 
            this.TEN_TB.Caption = "TÊN THIẾT BỊ";
            this.TEN_TB.FieldName = "TENTB";
            this.TEN_TB.MaxWidth = 350;
            this.TEN_TB.MinWidth = 175;
            this.TEN_TB.Name = "TEN_TB";
            this.TEN_TB.Visible = true;
            this.TEN_TB.VisibleIndex = 2;
            this.TEN_TB.Width = 175;
            // 
            // DON_GIA
            // 
            this.DON_GIA.Caption = "ĐƠN GIÁ";
            this.DON_GIA.FieldName = "DONGIA";
            this.DON_GIA.MaxWidth = 500;
            this.DON_GIA.MinWidth = 22;
            this.DON_GIA.Name = "DON_GIA";
            this.DON_GIA.Visible = true;
            this.DON_GIA.VisibleIndex = 3;
            this.DON_GIA.Width = 100;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtTenThietBi);
            this.groupControl1.Controls.Add(this.txtDonGia);
            this.groupControl1.Controls.Add(this.txtMaThietBi);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 313);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1123, 295);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtTenThietBi
            // 
            this.txtTenThietBi.Location = new System.Drawing.Point(152, 112);
            this.txtTenThietBi.Name = "txtTenThietBi";
            this.txtTenThietBi.Size = new System.Drawing.Size(204, 23);
            this.txtTenThietBi.TabIndex = 2;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(546, 112);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(147, 23);
            this.txtDonGia.TabIndex = 3;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // txtMaThietBi
            // 
            this.txtMaThietBi.Location = new System.Drawing.Point(152, 53);
            this.txtMaThietBi.Name = "txtMaThietBi";
            this.txtMaThietBi.Size = new System.Drawing.Size(204, 23);
            this.txtMaThietBi.TabIndex = 1;
            this.txtMaThietBi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaThietBi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(469, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Thiết Bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Thiết bị";
            // 
            // FrmThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 608);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gcThietBi);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmThietBi";
            this.Text = "FrmThietBi";
            this.Load += new System.EventHandler(this.FrmThietBi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcThietBi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvThietBi)).EndInit();
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
        private System.Windows.Forms.ToolStripButton btXoa;
        private System.Windows.Forms.ToolStripButton btLuu;
        private System.Windows.Forms.ToolStripButton btBoqua;
        private System.Windows.Forms.ToolStripButton btThoat;
        private DevExpress.XtraGrid.GridControl gcThietBi;
        private DevExpress.XtraGrid.Views.Grid.GridView gvThietBi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtTenThietBi;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaThietBi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn MA_TB;
        private DevExpress.XtraGrid.Columns.GridColumn TEN_TB;
        private DevExpress.XtraGrid.Columns.GridColumn DON_GIA;
    }
}