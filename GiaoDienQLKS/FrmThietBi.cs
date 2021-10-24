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
    public partial class FrmThietBi : DevExpress.XtraEditors.XtraForm
    {
        public FrmThietBi()
        {
            InitializeComponent();
        }
        THIETBI _thietbi;
        bool _them;
        int _matb;

        private void FrmThietBi_Load(object sender, EventArgs e)
        {
            _thietbi = new THIETBI();
            loadData();
            ShowHideControl(true);
            txtMaThietBi.Enabled = false;
            txtTenThietBi.Enabled = false;
            txtDonGia.Enabled = false;
            
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
        void loadData()
        {
            gcThietBi.DataSource = _thietbi.getAll();
            gvThietBi.OptionsBehavior.Editable = false;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            _them = true;
            txtMaThietBi.Focus();
            txtMaThietBi.Enabled = true;
            txtTenThietBi.Enabled = true;
            txtDonGia.Enabled = true;
            txtMaThietBi.Focus();
            ShowHideControl(false);
            clear();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            _them = false;
            txtMaThietBi.Enabled = false;
            txtTenThietBi.Enabled = true;
            txtDonGia.Enabled = true;
            
            ShowHideControl(false);
            clear();
        }
        void clear()
        {
            txtMaThietBi.Text = "";
            txtTenThietBi.Text = "";
            txtDonGia.Text = "";
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                for(int i =0; i<gvThietBi.RowCount; i++)
                {
                    bool mutiselect = gvThietBi.IsRowSelected(i);
                    if(mutiselect)
                    {
                        _thietbi.Delete(int.Parse(gvThietBi.GetRowCellValue(i, "MATB").ToString()));
                    }
                }
            loadData();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            if(txtMaThietBi.Text.Length == 0 || txtTenThietBi.Text.Length == 0 || txtDonGia.Text.Length == 0)
            {
                MessageBox.Show("Mời bạn nhập thông tin ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (_them)
                {
                    if (MessageBox.Show("Bạn có muốn lưu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        tb_THIETBI thb = new tb_THIETBI();
                        thb.MATB = int.Parse(txtMaThietBi.Text);
                        thb.TENTB = txtTenThietBi.Text;
                        thb.DONGIA = int.Parse(txtDonGia.Text);
                        for (int i = 0; i < gvThietBi.RowCount; i++)
                        {
                            if (gvThietBi.GetRowCellValue(i, "MATB").ToString() == txtMaThietBi.Text)
                            {
                                MessageBox.Show("Mã thiết bị đã có mời nhập mã khác", "Thông báo", MessageBoxButtons.OK);
                                txtMaThietBi.Text = "";
                                txtMaThietBi.Focus();
                                return;
                            }
                        }
                        _thietbi.them(thb);

                        txtMaThietBi.Enabled = false;
                        txtTenThietBi.Enabled = false;
                        txtDonGia.Enabled = false;

                        clear();
                    }
                    else
                    {
                        
                        txtMaThietBi.Focus();
                        return;
                        
                    }    

                }
                else
                {
                    if (MessageBox.Show("Bạn có muốn lưu những gì đã sửa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        _matb = int.Parse(gvThietBi.GetRowCellValue(gvThietBi.FocusedRowHandle, "MATB").ToString());

                        tb_THIETBI thb = _thietbi.getItem(_matb);
                        MessageBox.Show("Bạn đã sửa thành công", "Thông báo", MessageBoxButtons.OK);

                        thb.MATB = int.Parse(txtMaThietBi.Text);
                        thb.TENTB = txtTenThietBi.Text;
                        thb.DONGIA = float.Parse(txtDonGia.Text);
                        _thietbi.sua(thb);
                        txtTenThietBi.Enabled = false;
                        txtDonGia.Enabled = false;
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

        private void btBoqua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn bỏ qua khi chưa lưu hoặc chỉnh sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _them = false;
                txtMaThietBi.Enabled = false;
                txtTenThietBi.Enabled = false;
                txtDonGia.Enabled = false;
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

        private void gvThietBi_Click(object sender, EventArgs e)
        {
            if(gvThietBi.RowCount>0)
            {
                
                txtMaThietBi.Text = gvThietBi.GetFocusedRowCellValue("MATB").ToString();
                txtTenThietBi.Text = gvThietBi.GetFocusedRowCellValue("TENTB").ToString();
                txtDonGia.Text = gvThietBi.GetFocusedRowCellValue("DONGIA").ToString();
                
            }
        }

        private void txtMaThietBi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
