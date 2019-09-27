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
    public partial class PasienForm : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=rumah_sakit;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public PasienForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Form1.status == 'c')
            {
                string query = "INSERT INTO pasien (ID, nama, jenis_kelamin, alamat, no_telp, umur, berat_badan, tinggi_badan, golongan_darah) VALUES(@id, @nama, @jeniskelamin, @alamat, @no_telp, @umur, @beratbadan, @tinggibadan, @golongandarah)"; 


            try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@nama", textBox2.Text);
                    cmd.Parameters.AddWithValue("@jeniskelamin", textBox3.Text);
                    cmd.Parameters.AddWithValue("@alamat", textBox4.Text);
                    cmd.Parameters.AddWithValue("@no_telp", textBox5.Text);
                    cmd.Parameters.AddWithValue("@umur", textBox6.Text);
                    cmd.Parameters.AddWithValue("@beratbadan", textBox7.Text);
                    cmd.Parameters.AddWithValue("@tinggibadan", textBox8.Text);
                    cmd.Parameters.AddWithValue("@golongandarah", textBox9.Text);
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

            }
        }
    }
}
