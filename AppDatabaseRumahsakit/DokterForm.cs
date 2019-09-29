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
                    cmd.Parameters.AddWithValue("@nip", tbNIP.Text);
                    cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("@jenis_kelamin", cbJK.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@alamat", tbAlamat.Text);
                    cmd.Parameters.AddWithValue("@no_telp", tbTelp.Text);
                    cmd.Parameters.AddWithValue("@gaji_pokok", tbGaji.Text);
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
                    cmd.Parameters.AddWithValue("@nip", tbNIP.Text);
                    cmd.Parameters.AddWithValue("@nama", tbNama.Text);
                    cmd.Parameters.AddWithValue("@jenis_kelamin", cbJK.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@alamat", tbAlamat.Text);
                    cmd.Parameters.AddWithValue("@no_telp", tbTelp.Text);
                    cmd.Parameters.AddWithValue("@gaji_pokok", tbGaji.Text);
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
    }
}
