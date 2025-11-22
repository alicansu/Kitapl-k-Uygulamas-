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
    public partial class FrmAuthors : Form
    {
        AuthorManager _authorsManager = new AuthorManager();
        int _id = -1;

        public FrmAuthors()
        {
            InitializeComponent();
            YazarListele();
        }

        private void FrmAuthors_Load(object sender, EventArgs e)
        {
            YazarListele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Author author = new Author();
                author.Name = textBox1.Text;
                _authorsManager.Add(author);
                textBox1.Clear();
                YazarListele();
            }
            else
            {
                MessageBox.Show("Yazar adı boş geçilemez");
            }
        }

        private void YazarListele()
        {

            dataGridView1.DataSource = _authorsManager.GetAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)

        {
            Author deleteAuthors = _authorsManager.GetById(_id);
            if (deleteAuthors != null)
            {
                _authorsManager.Delete(deleteAuthors);
                textBox1.Clear();
                YazarListele();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Author editAuthors = _authorsManager.GetById(_id);
            if (editAuthors != null)
            {
                editAuthors.Name = textBox1.Text;
                _authorsManager.Update(editAuthors);
                textBox1.Clear();
                YazarListele();
            }
            else
            {
                MessageBox.Show("Lütfen önce güncellenecek Yazarı seçiniz");    
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                _id = int.Parse(row.Cells[0].Value.ToString());

                Author author = _authorsManager.GetById(_id);
                textBox1.Text = author.Name;

            }
        }
    }
}

