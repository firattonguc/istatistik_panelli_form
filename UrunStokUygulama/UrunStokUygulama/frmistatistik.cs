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
    public partial class frmistatistik : Form
    {
        public frmistatistik()
        {
            InitializeComponent();
        }
        DbEntıtyUrunEntities db=new DbEntıtyUrunEntities();
        private void frmistatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.tbl_kategori.Count().ToString();
            label3.Text = db.tbl_urun.Count().ToString();
            label5.Text=  db.tbl_musterı.Count(x=>x.durum==true).ToString();
            label7.Text=  db.tbl_musterı.Count(x=>x.durum==false).ToString();
            label13.Text=  db.tbl_urun.Sum(x=>x.stok).ToString();
            label21.Text = db.tbl_satıs.Sum(z => z.fıyat).ToString() + "tl";
            label11.Text = (from xx in db.tbl_urun orderby xx.fıyat descending select xx.urunad).FirstOrDefault();
            label9.Text=(from x in db.tbl_urun orderby x.fıyat ascending select x.urunad).FirstOrDefault();
            label15.Text=db.tbl_urun.Count(x=>x.kategorı==1).ToString();    
            label17.Text=db.tbl_urun.Count(x=>x.urunad=="buzdolabı").ToString();
            label23.Text=(from x in db.tbl_musterı select x.sehır).Distinct().Count().ToString();
            label19.Text=db.markagetır().FirstOrDefault();
        }
    }
}
