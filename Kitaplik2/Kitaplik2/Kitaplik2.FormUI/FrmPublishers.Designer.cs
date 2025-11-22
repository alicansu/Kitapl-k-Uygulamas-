namespace Kitaplik2.FormUI
{
    partial class FrmPublishers
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
            label1 = new Label();
            textBox1 = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 33);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Yayıncı Adı";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(145, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 79);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(479, 60);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 145);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(479, 63);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(12, 214);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(479, 60);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 307);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(471, 153);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FrmPublishers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 472);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmPublishers";
            Text = "FrmPublishers";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridView1;
    }
}