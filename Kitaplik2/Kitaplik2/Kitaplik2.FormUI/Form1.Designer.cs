namespace Kitaplik2.FormUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCategory = new Button();
            btnAuthor = new Button();
            btnPublisher = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtName = new TextBox();
            txtISBN = new TextBox();
            cmAuthors = new ComboBox();
            cmCategories = new ComboBox();
            cmPublishers = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCategory
            // 
            btnCategory.Location = new Point(14, 16);
            btnCategory.Margin = new Padding(3, 4, 3, 4);
            btnCategory.Name = "btnCategory";
            btnCategory.Size = new Size(104, 45);
            btnCategory.TabIndex = 0;
            btnCategory.Text = "Kategoriler";
            btnCategory.UseVisualStyleBackColor = true;
            btnCategory.Click += btnCategory_Click;
            // 
            // btnAuthor
            // 
            btnAuthor.Location = new Point(126, 16);
            btnAuthor.Margin = new Padding(3, 4, 3, 4);
            btnAuthor.Name = "btnAuthor";
            btnAuthor.Size = new Size(97, 45);
            btnAuthor.TabIndex = 1;
            btnAuthor.Text = "Yazarlar";
            btnAuthor.UseVisualStyleBackColor = true;
            btnAuthor.Click += btnAuthor_Click;
            // 
            // btnPublisher
            // 
            btnPublisher.Location = new Point(230, 16);
            btnPublisher.Margin = new Padding(3, 4, 3, 4);
            btnPublisher.Name = "btnPublisher";
            btnPublisher.Size = new Size(95, 45);
            btnPublisher.TabIndex = 1;
            btnPublisher.Text = "Yayıncılar";
            btnPublisher.UseVisualStyleBackColor = true;
            btnPublisher.Click += btnPublisher_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 357);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(707, 233);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 108);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 3;
            label1.Text = "Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 159);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 3;
            label2.Text = "ISBN:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(401, 63);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 3;
            label3.Text = "Yazar:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(401, 112);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 3;
            label4.Text = "Kategori:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(401, 159);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 3;
            label5.Text = "Yayınevi:";
            // 
            // txtName
            // 
            txtName.Location = new Point(141, 97);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 4;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(141, 147);
            txtISBN.Margin = new Padding(3, 4, 3, 4);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(114, 27);
            txtISBN.TabIndex = 4;
            // 
            // cmAuthors
            // 
            cmAuthors.FormattingEnabled = true;
            cmAuthors.Location = new Point(486, 64);
            cmAuthors.Margin = new Padding(3, 4, 3, 4);
            cmAuthors.Name = "cmAuthors";
            cmAuthors.Size = new Size(138, 28);
            cmAuthors.TabIndex = 5;
            // 
            // cmCategories
            // 
            cmCategories.FormattingEnabled = true;
            cmCategories.Location = new Point(486, 108);
            cmCategories.Margin = new Padding(3, 4, 3, 4);
            cmCategories.Name = "cmCategories";
            cmCategories.Size = new Size(138, 28);
            cmCategories.TabIndex = 5;
            // 
            // cmPublishers
            // 
            cmPublishers.FormattingEnabled = true;
            cmPublishers.Location = new Point(486, 155);
            cmPublishers.Margin = new Padding(3, 4, 3, 4);
            cmPublishers.Name = "cmPublishers";
            cmPublishers.Size = new Size(138, 28);
            cmPublishers.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(39, 197);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(667, 45);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(39, 304);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(667, 45);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Location = new Point(39, 250);
            btndelete.Margin = new Padding(3, 4, 3, 4);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(667, 45);
            btndelete.TabIndex = 7;
            btndelete.Text = "Sil";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 594);
            Controls.Add(btndelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(cmPublishers);
            Controls.Add(cmCategories);
            Controls.Add(cmAuthors);
            Controls.Add(txtISBN);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnPublisher);
            Controls.Add(btnAuthor);
            Controls.Add(btnCategory);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCategory;
        private Button btnAuthor;
        private Button btnPublisher;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtName;
        private TextBox txtISBN;
        private ComboBox cmAuthors;
        private ComboBox cmCategories;
        private ComboBox cmPublishers;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btndelete;
    }
}
