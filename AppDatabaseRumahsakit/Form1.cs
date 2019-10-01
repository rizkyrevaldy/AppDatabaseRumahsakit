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
    public partial class Form1 : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=rumah_sakit;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public Form1()
        {
            InitializeComponent();
            //button3.PerformClick();
        }

        public static Char status;
        private void button4_Click(object sender, EventArgs e)
        {
            status = 'c';
            if (tabControl1.SelectedTab.Equals(tabPage1))
            {
                PasienForm form = new PasienForm();
                form.Show();
            }
            else if(tabControl1.SelectedTab.Equals(tabPage2)){
                DokterForm form = new DokterForm();
                form.Show();
            }
            else if (tabControl1.SelectedTab.Equals(tabPage3))
            {
                PenyakitForm form = new PenyakitForm();
                form.Show();
            }
            else if (tabControl1.SelectedTab.Equals(tabPage4))
            {
                TransaksiForm form = new TransaksiForm();
                form.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Equals(tabPage1))
            {
                listView1.Items.Clear();
                string query = "SELECT * FROM pasien";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem listViewItem = new ListViewItem(reader["ID"].ToString());
                            listViewItem.SubItems.Add(reader["nama"].ToString());
                            listViewItem.SubItems.Add(reader["jenis_kelamin"].ToString());
                            listViewItem.SubItems.Add(reader["alamat"].ToString());
                            listViewItem.SubItems.Add(reader["no_telp"].ToString());
                            listViewItem.SubItems.Add(reader["umur"].ToString());
                            listViewItem.SubItems.Add(reader["berat_badan"].ToString());
                            listViewItem.SubItems.Add(reader["tinggi_badan"].ToString());
                            listViewItem.SubItems.Add(reader["golongan_darah"].ToString());
                            listView1.Items.Add(listViewItem);
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("No rows found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
            }
            else if (tabControl1.SelectedTab.Equals(tabPage2))
            {
                listView2.Items.Clear();
                string query = "SELECT * FROM dokter";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem listViewItem = new ListViewItem(reader["NIP"].ToString());
                            listViewItem.SubItems.Add(reader["nama"].ToString());
                            listViewItem.SubItems.Add(reader["jenis_kelamin"].ToString());
                            listViewItem.SubItems.Add(reader["alamat"].ToString()); 
                            listViewItem.SubItems.Add(reader["no_telp"].ToString());
                            listViewItem.SubItems.Add(reader["gaji_pokok"].ToString());
                            listView2.Items.Add(listViewItem);
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("No rows found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
            }
            else if (tabControl1.SelectedTab.Equals(tabPage3))
            {
                listView4.Items.Clear();
                string query = "SELECT * FROM penyakit";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem listViewItem = new ListViewItem(reader["kode_penyakit"].ToString());
                            listViewItem.SubItems.Add(reader["nama_penyakit"].ToString());
                            listViewItem.SubItems.Add(reader["golongan"].ToString()); //kode_penyakit nama_penyakit golongan
                            listView4.Items.Add(listViewItem);
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("No rows found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
            }
            else if (tabControl1.SelectedTab.Equals(tabPage4))
            {
                listView3.Items.Clear();
                string query = "SELECT * FROM transaksi";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ListViewItem listViewItem = new ListViewItem(reader["no_transaksi"].ToString());
                            listViewItem.SubItems.Add(reader["id_pasien"].ToString());
                            listViewItem.SubItems.Add(reader["nip_dokter"].ToString()); //no_transaksi id_pasien nip_dokter kode_penyakit biaya_perawatan
                            listViewItem.SubItems.Add(reader["kode_penyakit"].ToString());
                            listViewItem.SubItems.Add(reader["biaya_perawatan"].ToString());
                            listView3.Items.Add(listViewItem);
                        }
                        reader.Close();
                    }
                    else
                    {
                        MessageBox.Show("No rows found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                }
            }
        }

        public static string id;
        private void button1_Click(object sender, EventArgs e)
        {
            status = 'u';
            if (tabControl1.SelectedTab.Equals(tabPage1))
            {
                id = listView1.SelectedItems[0].Text;
                PasienForm form = new PasienForm();
                form.Show();
            }
            else if (tabControl1.SelectedTab.Equals(tabPage2))
            {
                id = listView2.SelectedItems[0].Text;
                DokterForm form = new DokterForm();
                form.Show();
            }
            else if (tabControl1.SelectedTab.Equals(tabPage3))
            {
                id = listView4.SelectedItems[0].Text;
                PenyakitForm form = new PenyakitForm();
                form.Show();
            }
            else if (tabControl1.SelectedTab.Equals(tabPage4))
            {
                id = listView3.SelectedItems[0].Text;
                TransaksiForm form = new TransaksiForm();
                form.Show();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Equals(tabPage1))
            {
                string id = listView1.SelectedItems[0].Text;
                string query = "DELETE FROM pasien WHERE ID=@id";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                    button3.PerformClick();
                }
            }
            else if (tabControl1.SelectedTab.Equals(tabPage2))
            {
                string nip = listView2.SelectedItems[0].Text;
                string query = "DELETE FROM dokter WHERE NIP=@nip";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@nip", nip);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                    button3.PerformClick();
                }
            }
            else if (tabControl1.SelectedTab.Equals(tabPage3))
            {
                string kode = listView4.SelectedItems[0].Text;
                string query = "DELETE FROM penyakit WHERE kode_penyakit=@kode";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@kode", kode);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                    button3.PerformClick();
                }
            }
            else if (tabControl1.SelectedTab.Equals(tabPage4))
            {
                string no = listView3.SelectedItems[0].Text;
                string query = "DELETE FROM transaksi WHERE no_transaksi=@no";
                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, databaseConnection);
                    cmd.CommandTimeout = 60;
                    cmd.Parameters.AddWithValue("@no", no);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Berhasil Dihapus");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    databaseConnection.Close();
                    button3.PerformClick();
                }
            }
        }

        private void pasienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage1.Show();
            tabControl1.SelectTab(0);
        }

        private void dokterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage2.Show();
            tabControl1.SelectTab(1);
        }

        private void obatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage3.Show();
            tabControl1.SelectTab(2);
        }

        private void penyakitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabPage4.Show();
            tabControl1.SelectTab(3);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            button3.PerformClick();
        }
        
    }
}

