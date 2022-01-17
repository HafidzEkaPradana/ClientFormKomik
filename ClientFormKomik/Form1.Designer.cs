
namespace ClientFormKomik
{
    partial class Form1
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
            this.btAdd = new System.Windows.Forms.Button();
            this.btEdit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btDelete = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.textBoxIdKomik = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxJudulKomik = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAuthorKomik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTahun = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.SystemColors.Control;
            this.btAdd.Location = new System.Drawing.Point(614, 53);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(145, 34);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Tambah";
            this.btAdd.UseVisualStyleBackColor = false;
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(614, 119);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(145, 34);
            this.btEdit.TabIndex = 3;
            this.btEdit.Text = "Edit";
            this.btEdit.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "Login";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(72, 29);
            this.toolStripMenuItem1.Text = "Login";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(78, 29);
            this.toolStripMenuItem2.Text = "Komik";
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Gray;
            this.btDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btDelete.Location = new System.Drawing.Point(614, 185);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(145, 34);
            this.btDelete.TabIndex = 6;
            this.btDelete.Text = "Hapus";
            this.btDelete.UseVisualStyleBackColor = false;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(614, 248);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(145, 34);
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Bersihkan";
            this.btClear.UseVisualStyleBackColor = true;
            // 
            // textBoxIdKomik
            // 
            this.textBoxIdKomik.Location = new System.Drawing.Point(150, 61);
            this.textBoxIdKomik.Name = "textBoxIdKomik";
            this.textBoxIdKomik.Size = new System.Drawing.Size(401, 26);
            this.textBoxIdKomik.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID Komik";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Judul Komik";
            // 
            // textBoxJudulKomik
            // 
            this.textBoxJudulKomik.Location = new System.Drawing.Point(150, 120);
            this.textBoxJudulKomik.Name = "textBoxJudulKomik";
            this.textBoxJudulKomik.Size = new System.Drawing.Size(401, 26);
            this.textBoxJudulKomik.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Author";
            // 
            // textBoxAuthorKomik
            // 
            this.textBoxAuthorKomik.Location = new System.Drawing.Point(150, 186);
            this.textBoxAuthorKomik.Name = "textBoxAuthorKomik";
            this.textBoxAuthorKomik.Size = new System.Drawing.Size(401, 26);
            this.textBoxAuthorKomik.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tahun";
            // 
            // textBoxTahun
            // 
            this.textBoxTahun.Location = new System.Drawing.Point(150, 252);
            this.textBoxTahun.Name = "textBoxTahun";
            this.textBoxTahun.Size = new System.Drawing.Size(401, 26);
            this.textBoxTahun.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 314);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(727, 271);
            this.dataGridView1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 597);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTahun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAuthorKomik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxJudulKomik);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIdKomik);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btEdit);
            this.Controls.Add(this.btAdd);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Komik";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btEdit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.TextBox textBoxIdKomik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxJudulKomik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAuthorKomik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTahun;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

