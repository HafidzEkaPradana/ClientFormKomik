using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientFormKomik
{
    public partial class Register : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
        public Register()
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("User");

            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxMasuk.Text;
            string password = textBoxPassword.Text;
            string kategori = comboBox1.Text;
            string a = service.Register(username, password, kategori);

            if (textBoxMasuk.Text == "" || textBoxPassword.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi !!");
            }
            else
            {
                MessageBox.Show(a);
                Refresh();
            }
        }
    }
}
