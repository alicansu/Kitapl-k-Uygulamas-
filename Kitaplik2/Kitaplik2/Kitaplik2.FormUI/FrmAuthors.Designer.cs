namespace Kitaplik2.FormUI
{
    partial class FrmAuthors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAdd = new Button();
            btnDelete = new Button();
            Update = new Button();
            textBox1 = new TextBox();
            lblAuthors = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(24, 85);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(442, 59);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(24, 150);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(442, 59);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Update
            // 
            Update.Location = new Point(24, 215);
            Update.Name = "Update";
            Update.Size = new Size(442, 59);
            Update.TabIndex = 2;
            Update.Text = "Güncelle";
            Update.UseVisualStyleBackColor = true;
            Update.Click += Update_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(132, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // lblAuthors
            // 
            lblAuthors.AutoSize = true;
            lblAuthors.Location = new Point(34, 33);
            lblAuthors.Name = "lblAuthors";
            lblAuthors.Size = new Size(71, 20);
            lblAuthors.TabIndex = 4;
            lblAuthors.Text = "Yazar Adı";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(24, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(432, 168);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmAuthors
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 459);
            Controls.Add(dataGridView1);
            Controls.Add(lblAuthors);
            Controls.Add(textBox1);
            Controls.Add(Update);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Name = "FrmAuthors";
            Text = "FrmAuthors";
            Load += FrmAuthors_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnDelete;
        private Button Update;
        private TextBox textBox1;
        private Label lblAuthors;
        private DataGridView dataGridView1;
    }
}