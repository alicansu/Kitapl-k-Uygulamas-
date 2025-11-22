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
    public partial class FrmPublishers : Form
    {
        public PublisherManager _publisherManager = new();
        int _id = -1;

        public FrmPublishers()
        {
            InitializeComponent();
            YayinEviListele();
        }
        void YayinEviListele()
        {
            dataGridView1.DataSource = _publisherManager.GetAll();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                Publisher publisher = new Publisher();
                publisher.Name = textBox1.Text;
                _publisherManager.Add(publisher);
                textBox1.Clear();
                YayinEviListele();
            }
            else
            {
                MessageBox.Show("Yayın evi adı boş geçilemez");
            }

        }

        private void Sil_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Publisher updatePublisher = _publisherManager.GetById(_id);
            if (updatePublisher != null && !string.IsNullOrEmpty(textBox1.Text))
            {
                updatePublisher.Name = textBox1.Text;
                _publisherManager.Update(updatePublisher);
                textBox1.Clear();
                YayinEviListele();
            }
            else
            {
                MessageBox.Show("Yayın evi adı boş geçilemez");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Publisher deletePublisher = _publisherManager.GetById(_id);
            if (deletePublisher != null)
            {
                _publisherManager.Delete(deletePublisher);
                textBox1.Clear();
                YayinEviListele();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                _id = int.Parse(row.Cells[0].Value.ToString());
                Publisher publisher = _publisherManager.GetById(_id);
                textBox1.Text = publisher.Name;
            }
        }
    }
}
