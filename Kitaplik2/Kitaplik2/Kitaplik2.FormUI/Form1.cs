using Kitaplik.Business.Concrete;
using Kitaplik2.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kitaplik2.FormUI
{
    public partial class Form1 : Form
    {
        CategoryManager _categoryManager = new();
        AuthorManager _authorManager = new();
        PublisherManager _publisherManager = new();
        BookManager _bookManager = new();
        public Form1()
        {
            InitializeComponent();

            cmCategories.DataSource = _categoryManager.GetAll();
            cmCategories.DisplayMember = "Name";
            cmCategories.ValueMember = "Id";

            cmAuthors.DataSource = _authorManager.GetAll();
            cmAuthors.DisplayMember = "Name";
            cmAuthors.ValueMember = "Id";

            cmPublishers.DataSource = _publisherManager.GetAll();
            cmPublishers.DisplayMember = "Name";
            cmPublishers.ValueMember = "Id";


            KitapListele();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[9].Visible = false;
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            FrmCategory frm = new();
            frm.ShowDialog();
        }
        void KitapListele()
        {
            dataGridView1.DataSource = _bookManager.GetAll();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (
               !string.IsNullOrWhiteSpace(txtName.Text) &&
               !string.IsNullOrWhiteSpace(txtISBN.Text) &&
               !string.IsNullOrEmpty(cmAuthors.Text) &&
               !string.IsNullOrEmpty(cmCategories.Text) &&
               !string.IsNullOrEmpty(cmPublishers.Text)

               )
            {

                Book book = new Book();

                dynamic authorId = (cmAuthors.SelectedItem as dynamic).Id;

                dynamic publisherId = (cmPublishers.SelectedItem as dynamic).Id;

                dynamic categoryId = (cmCategories.SelectedItem as dynamic).Id;

                book.Name = txtName.Text;
                book.ISBN = txtISBN.Text;
                book.PublisherId = Convert.ToInt32(publisherId);
                book.AuthorId = Convert.ToInt32(authorId);
                book.CategoryId = Convert.ToInt32(categoryId);

                _bookManager.Add(book);
                MessageBox.Show("Kitap Eklendi");
                KitapListele();
            }
            else
            {
                MessageBox.Show("Herhangi Bir Alan Boþ Geçilemez");
            }
        }

        private void btnAuthor_Click(object sender, EventArgs e)
        {
            FrmAuthors frm = new FrmAuthors();
            frm.ShowDialog();
        }

        private void btnPublisher_Click(object sender, EventArgs e)
        {
            FrmPublishers frm = new FrmPublishers();
            frm.ShowDialog();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

                var book = _bookManager.GetById(id);

                if (book != null)
                {
                    var result = MessageBox.Show(
                        "Seçili kitabý silmek istediðinize emin misiniz?",
                        "Onay",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        _bookManager.Delete(book);
                        KitapListele();
                        MessageBox.Show("Kitap baþarýyla silindi.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Silmek için önce bir kitap seçin.");
            }
            txtName.Clear();
            txtISBN.Clear();
            cmAuthors.SelectedIndex = -1;
            cmCategories.SelectedIndex = -1;
            cmPublishers.SelectedIndex = -1;
            KitapListele();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
