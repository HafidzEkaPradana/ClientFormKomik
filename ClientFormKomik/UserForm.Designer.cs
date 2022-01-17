
namespace ClientFormKomik
{
    partial class UserForm
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbIDpemesanan;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button btPesan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource komikBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDKomikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn judulKomikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pengarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btShowPemesanan;
        private System.Windows.Forms.DateTimePicker dtPemesanan;
    }
}