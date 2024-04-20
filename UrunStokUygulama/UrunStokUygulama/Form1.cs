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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DbEntıtyUrunEntities db=new DbEntıtyUrunEntities();
        private void btnlistele_Click(object sender, EventArgs e)
        {
            var kategoriler=db.tbl_kategori.ToList();
            dataGridView1.DataSource = kategoriler;
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            tbl_kategori t=new tbl_kategori();
            t.ad=txtad.Text;    
            db.tbl_kategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("kategori eklendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int x=Convert.ToInt32(txtıd.Text);
            var kt=db.tbl_kategori.Find(x);
            db.tbl_kategori.Remove(kt);
            db.SaveChanges();
            MessageBox.Show("kategori silindi");
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txtıd.Text);
            var kt = db.tbl_kategori.Find(x);
            kt.ad = txtad.Text;
            db.SaveChanges();
            MessageBox.Show("güncelleme yapıldı");
        }
    }
}
