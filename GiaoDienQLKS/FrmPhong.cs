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

namespace GiaoDienQLKS
{
    public partial class FrmPhong : Form
    {
        public FrmPhong()
        {
            InitializeComponent();
        }
        PHONG _phong;
        bool _them;
        int _maphong;
        private void FrmPhong_Load(object sender, EventArgs e)
        {
            _phong = new PHONG();
            loadData();
            ShowHideControl(true);
            txtMaphong.Enabled = false;
            txtTenphong.Enabled = false;
            txtDongia.Enabled = false;
            cbMalp.Enabled = false;
            ckTrangthai.Enabled = false;
            
        }
        void ShowHideControl(bool t)
        {
            btThem.Visible = t;
            btSua.Visible = t;
            btXoa.Visible = t;
            btLuu.Visible = !t;
            btBoqua.Visible = !t;
            btThoat.Visible = t;

        }
        public void loadData()
        {
            gcPhong.DataSource = _phong.getAll();
            gvPhong.OptionsBehavior.Editable = false;
        }
        void clear()
        {
            txtMaphong.Text = "";
            txtTenphong.Text = "";
            txtDongia.Text = "";
            cbMalp.Text = "";
            ckTrangthai.Text = "";
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtMaphong.Focus();
            txtMaphong.Enabled = true;
            txtTenphong.Enabled = true;
            txtDongia.Enabled = true;
            cbMalp.Enabled = true;
            ckTrangthai.Enabled = false;
            txtMaphong.Focus();
            ShowHideControl(false);
            clear();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            _them = false;
            txtMaphong.Enabled = false;
            txtTenphong.Enabled = true;
            txtDongia.Enabled = true;
            cbMalp.Enabled = false;


            ShowHideControl(false);
            clear();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if (txtMaphong.Text.Length == 0 || txtTenphong.Text.Length == 0 || txtDongia.Text.Length == 0 || cbMalp.Text.Length == 0 ) //ckTrangthai.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn nhập thông tin ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (_them)
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_PHONG phog = new tb_PHONG();
                        phog.MAPHONG = int.Parse(txtMaphong.Text);
                        phog.TENPHONG = txtTenphong.Text;
                        phog.DONGIA = int.Parse(txtDongia.Text);
                        phog.MALP = int.Parse(cbMalp.Text);
                        phog.TRANGTHAIPHONG = ckTrangthai.Checked;

                        for (int i = 0; i < gvPhong.RowCount; i++)
                        {
                            if (gvPhong.GetRowCellValue(i, "MALP").ToString() == txtMaphong.Text)
                            {
                                MessageBox.Show("Mã thiết bị đã có mời nhập mã khác", "Thông báo", MessageBoxButtons.OK);
                                txtMaphong.Text = "";
                                txtMaphong.Focus();
                                return;
                            }
                        }
                        _phong.them(phog);

                        txtMaphong.Enabled = false;
                        txtTenphong.Enabled = false;
                        txtDongia.Enabled = false;
                        cbMalp.Enabled = false;
                        ckTrangthai.Enabled = false;

                        clear();
                    }
                    else
                    {

                        txtMaphong.Focus();
                        return;

                    }

                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn lưu những gì đã sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _maphong = int.Parse(gvPhong.GetRowCellValue(gvPhong.FocusedRowHandle, "MATB").ToString());

                        tb_PHONG phog = _phong.getItem(_maphong);
                        MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK);

                        phog.MAPHONG = int.Parse(txtMaphong.Text);
                        phog.TENPHONG = txtTenphong.Text;
                        phog.DONGIA = float.Parse(txtDongia.Text);
                        phog.MALP = int.Parse(cbMalp.Text);
                        _phong.sua(phog);
                        txtTenphong.Enabled = false;
                        txtDongia.Enabled = false;
                        clear();
                    }
                    else
                    {
                        return;
                    }

                }
                _them = false;
                loadData();
                ShowHideControl(true);
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                for (int i = 0; i < gvPhong.RowCount; i++)
                {
                    bool mutiselect = gvPhong.IsRowSelected(i);
                    if (mutiselect)
                    {
                        _phong.Delete(int.Parse(gvPhong.GetRowCellValue(i, "MAPHONG ").ToString()));
                    }
                }
            loadData();
        }

        private void btBoqua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn bỏ qua khi chưa lưu hoặc chỉnh sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _them = false;
                txtMaphong.Enabled = false;
                txtTenphong.Enabled = false;
                txtDongia.Enabled = false;
                cbMalp.Enabled = false;
                ShowHideControl(true);
                clear();
            }
            else
            {
                return;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvPhong_Click(object sender, EventArgs e)
        {
            txtMaphong.Text = gvPhong.GetFocusedRowCellValue("MAPHONG").ToString();
            txtTenphong.Text = gvPhong.GetFocusedRowCellValue("TENPHONG").ToString();
            txtDongia.Text = gvPhong.GetFocusedRowCellValue("DONGIA").ToString();
            cbMalp.Text = gvPhong.GetFocusedRowCellValue("MALP").ToString();
        }

    }
    
}
