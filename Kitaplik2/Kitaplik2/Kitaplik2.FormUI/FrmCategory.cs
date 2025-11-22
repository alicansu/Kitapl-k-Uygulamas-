using Kitaplik.Business.Concrete;
using Kitaplik2.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplik2.FormUI
{
    public partial class FrmCategory : Form
    {
        CategoryManager _categoryManager = new();
        int _id = -1;
        public FrmCategory()
        {
            InitializeComponent();
            KategoriListele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Category category = new Category();
                category.Name = textBox1.Text;
                _categoryManager.Add(category);
                textBox1.Clear();
                KategoriListele();
            }
            else
            {
                MessageBox.Show("Kategori adı boş geçilemez");
            }

        }

        void KategoriListele()
        {
            dataGridView1.DataSource = _categoryManager.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Category deleteCategory = _categoryManager.GetById(_id);

            if (deleteCategory != null)
            {
                _categoryManager.Delete(deleteCategory);

                textBox1.Clear();
                KategoriListele();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                _id = int.Parse(row.Cells[0].Value.ToString());

                Category category = _categoryManager.GetById(_id);
                textBox1.Text = category.Name;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Category editCategory = _categoryManager.GetById(_id);
            if (editCategory != null)
            {
                editCategory.Name = textBox1.Text;
                _categoryManager.Update(editCategory);
                textBox1.Text = string.Empty;
                KategoriListele();
            }
            else
            {
                MessageBox.Show("Lütfen önce güncellenecek kategoriyi seçiniz");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
