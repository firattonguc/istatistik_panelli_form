using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStokUygulama
{
    public partial class frmgiris : Form
    {
        public frmgiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbEntıtyUrunEntities db=new DbEntıtyUrunEntities();
            var sorgu = from x in db.tbl_admin where x.kullanıcı == textBox1.Text && x.sifre == textBox2.Text select x;
            if(sorgu.Any() )
            {
                Frmanaform form = new Frmanaform();
                form.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatalı giriş");
            }
        }
    }
}
