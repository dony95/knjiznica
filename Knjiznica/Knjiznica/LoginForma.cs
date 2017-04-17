using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Knjiznica
{
    public partial class LoginForma : Form
    {
        MySqlConnection conn;
        public LoginForma(MySqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            MySqlCommand command = conn.CreateCommand();
            command.CommandText = "SELECT * FROM employees where username = @username and password = @password";
            command.Parameters.AddWithValue("@username", tb_Username.Text);
            command.Parameters.AddWithValue("@password", tb_Password.Text);
            command.ExecuteNonQuery();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows == false)
                {
                    MessageBox.Show("Neispravni podaci!");
                    return;
                }
                else
                {
                    MessageBox.Show("Uspješna prijava!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }
    }
}
