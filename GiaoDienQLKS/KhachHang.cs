using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using DataLayer;
using DevExpress.XtraGrid.Views.Grid;

namespace GiaoDienQLKS
{
    public partial class frmKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        KHACHHANG _khachhang;
        bool _them;
        int _makh;
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            _khachhang = new KHACHHANG();
            loadData();
            showHideControl(true);
        }

        void showHideControl(bool t)
        {
            btnThem.Visible = t;
            btnSua.Visible = t;
            btnXoa.Visible = t;
            btnThoat.Visible = t;
            btnLuu.Visible = !t;
            btnBoQua.Visible = !t;
        }

        void loadData()
        {
            gcKhachHang.DataSource = _khachhang.getall();
            gvKhachHang.OptionsBehavior.Editable = false;
        }

        void clear()
        {
            txtMaKhachHang.Text = "";
            txtTenKhachHang.Text = "";
            txtDiaChi.Text = "";
            txtCCCD.Text = "";
            txtSDT.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            showHideControl(false);
            clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            _them = false;
            txtMaKhachHang.Enabled = false;
            showHideControl(false);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _khachhang.delete(int.Parse(gvKhachHang.GetRowCellValue(gvKhachHang.FocusedRowHandle, "MAKH").ToString()));
            }
            loadData();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_them)
            {
                tb_KHACHHANG kh = new tb_KHACHHANG();
                kh.MAKH = int.Parse(txtMaKhachHang.Text);
                kh.TENKH = txtTenKhachHang.Text;
                kh.DIACHI = txtDiaChi.Text;
                kh.CCCD_CMND = txtCCCD.Text;
                kh.SDT = txtSDT.Text;
                _khachhang.add(kh);
            }
            else
            {
                tb_KHACHHANG kh = _khachhang.getItem(_makh);
                kh.MAKH = int.Parse(txtMaKhachHang.Text);
                kh.TENKH = txtTenKhachHang.Text;
                kh.DIACHI = txtDiaChi.Text;
                kh.CCCD_CMND = txtCCCD.Text;
                kh.SDT = txtSDT.Text;
                _khachhang.update(kh);
            }
            _them = false;
            loadData();
            showHideControl(true);
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            _them = false;
            showHideControl(true);
        }

        private void gvKhachHang_Click(object sender, EventArgs e)
        {
            if (gvKhachHang.RowCount>0)
            {
                txtMaKhachHang.Text =gvKhachHang.GetFocusedRowCellValue("MAKH").ToString();
                txtTenKhachHang.Text = gvKhachHang.GetFocusedRowCellValue("TENKH").ToString();
                txtDiaChi.Text = gvKhachHang.GetFocusedRowCellValue("DIACHI").ToString();
                txtCCCD.Text = gvKhachHang.GetFocusedRowCellValue("CCCD_CMND").ToString();
                txtSDT.Text = gvKhachHang.GetFocusedRowCellValue("SDT").ToString();
            }
        }
    }
}