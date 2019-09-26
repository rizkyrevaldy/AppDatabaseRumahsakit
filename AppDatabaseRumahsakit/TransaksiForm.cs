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
    public partial class TransaksiForm : Form
    {
        private static string connectionString = "server=localhost;port=3306;username=root;password=;database=rumah_sakit;";
        private MySqlConnection databaseConnection = new MySqlConnection(connectionString);

        public TransaksiForm()
        {
            InitializeComponent();
        }
    }
}
