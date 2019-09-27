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

namespace AppDatabaseRumahsakit
{
    public partial class DokterForm : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=rumah_sakit;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public DokterForm()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Form1.status == 'c')
            {
                string query = "INSERT INTO dokter (NIP, nama, jenis_kelamin, alamat, no_telp, gaji_pokok) VALUES (@nip, @nama, @jenis_kelamin, @alamat, @no_telp, @gaji_pokok)"; 

            try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@nip", textBox1.Text);
                    cmd.Parameters.AddWithValue("@nama", textBox2.Text);
                    cmd.Parameters.AddWithValue("@jenis_kelamin", textBox3.Text);
                    cmd.Parameters.AddWithValue("@alamat", textBox4.Text);
                    cmd.Parameters.AddWithValue("@no_telp", textBox5.Text);
                    cmd.Parameters.AddWithValue("@gaji_pokok", textBox6.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil ditambahkan");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
                this.Close();
            }
            else if (Form1.status == 'u')
            {
                string query = "UPDATE dokter SET nama = @nama, jenis_kelamin = @jenis_kelamin, alamat = @alamat, no_telp = @no_telp, gaji_pokok = @gaji_pokok WHERE NIP = @nip";

                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@nip", textBox1.Text);
                    cmd.Parameters.AddWithValue("@nama", textBox2.Text);
                    cmd.Parameters.AddWithValue("@jenis_kelamin", textBox3.Text);
                    cmd.Parameters.AddWithValue("@alamat", textBox4.Text);
                    cmd.Parameters.AddWithValue("@no_telp", textBox5.Text);
                    cmd.Parameters.AddWithValue("@gaji_pokok", textBox6.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
                this.Close();
            }
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DokterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
