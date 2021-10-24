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
using System.Data.SqlClient;
using DataLayer;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GiaoDienQLKS
{
    public partial class frmKetNoiDB : DevExpress.XtraEditors.XtraForm
    {
        public frmKetNoiDB()
        {
            InitializeComponent();
        }
        SqlConnection getCon(string servername, string username, string pass, string database)
        {
            return new SqlConnection("Data Source=" + servername + "; Initial Catalog=" + database + "; User ID=" + username + "; Password=" + pass + ";");
            
        }

        private void frmKetNoiDB_Load(object sender, EventArgs e)
        {

        }

        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            SqlConnection con = getCon(txtserver.Text, txtuser.Text, txtpasswd.Text, cbData.Text);
            try
            {
                con.Open();
                MessageBox.Show("ket noi thanh cong");
            }
            catch(Exception )
            {
                MessageBox.Show("loi");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string svEncrypt = Encryptor.Encrypt(txtserver.Text, "fsfuoufsd8935@!", true);
            string usEncrypt = Encryptor.Encrypt(txtuser.Text, "fsfuoufsd8935@!", true);
            string pwEncrypt = Encryptor.Encrypt(txtpasswd.Text, "fsfuoufsd8935@!", true);
            string dbEncrypt = Encryptor.Encrypt(cbData.Text, "fsfuoufsd8935@!", true);

            SaveFileDialog sf = new SaveFileDialog();
            sf.Title = "chon noi luu tru";
            sf.Filter = "Text Files (*.dba)|*.dba| AllFiles(*.*)|*.*";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                connect cn = new connect(svEncrypt, usEncrypt, pwEncrypt, dbEncrypt);
                cn.SaveFile(sf.FileName);
                MessageBox.Show("Luu file thanh cong");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbData_MouseClick(object sender, MouseEventArgs e)
        {
            cbData.Items.Clear();
            string conn = "server=" + txtserver.Text +  "; User ID=" + txtuser.Text + "; pwd=" + txtpasswd.Text + ";";
            SqlConnection con = new SqlConnection(conn);

            con.Open();

            string qr = "SELECT NAME FROM SYS.DATABASES";

            SqlCommand cmd = new SqlCommand(qr,con);

            IDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbData.Items.Add(dr[0].ToString());
            }


        }

        private void btndoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "chon tap tin";
            op.Filter= "Text Files (*.dba)|*.dba| AllFiles(*.*)|*.*";
            if (op.ShowDialog()==DialogResult.OK)
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(op.FileName, FileMode.Open, FileAccess.Read);
                connect con = (connect)bf.Deserialize(fs);
                string sv = Encryptor.Decrypt(con.servername, "fsfuoufsd8935@!", true);
                string us = Encryptor.Decrypt(con.username, "fsfuoufsd8935@!", true);
                string pw = Encryptor.Decrypt(con.passwd, "fsfuoufsd8935@!", true);
                string db = Encryptor.Decrypt(con.database, "fsfuoufsd8935@!", true);

                txtserver.Text = sv;
                txtuser.Text = us;
                txtpasswd.Text = pw;
                cbData.Text = db;
            }
        }
    }
}