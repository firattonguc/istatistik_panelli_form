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
    public partial class frmurun : Form
    {
        public frmurun()
        {
            InitializeComponent();
        }
        DbEntıtyUrunEntities db = new DbEntıtyUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.tbl_urun select new { x.urunıd, x.urunad, x.stok, x.fıyat,x.tbl_kategori.ad, x.durum }).ToList();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_urun t = new tbl_urun();
            t.urunad = txturunadı.Text;
            t.urunmarka = txtmarka.Text;
            t.stok = short.Parse(txtstok.Text);
            t.kategorı = int.Parse(comboBox1.SelectedValue.ToString());
            t.fıyat = decimal.Parse(txtfiyat.Text);
            t.durum = true;
            db.tbl_urun.Add(t);
            db.SaveChanges();
            MessageBox.Show("ürün sisteme kaydedildi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtıd.Text);
            var urun = db.tbl_urun.Find(x);
            db.tbl_urun.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("ürün silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtıd.Text);
            var urun = db.tbl_urun.Find(x);
            urun.urunad = txturunadı.Text;
            urun.stok = short.Parse(txtstok.Text);
            urun.urunmarka = txtmarka.Text;
            db.SaveChanges();
            MessageBox.Show("ürün güncellendi");
        }

        private void frmurun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.tbl_kategori select new { x.ıd, x.ad }).ToList();
            comboBox1.ValueMember = "ıd";
            comboBox1.DisplayMember = "ad";
            comboBox1.DataSource = kategoriler;

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {


        }
    }
}
