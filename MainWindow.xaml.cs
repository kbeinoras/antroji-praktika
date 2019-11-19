using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;

namespace antroji_praktika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }
        private int count;
        private int ID;
        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection m_dbConnection = new SQLiteConnection(@"Data Source=DbAntras.db;");
            try
            {
                if (m_dbConnection.State == System.Data.ConnectionState.Closed)
                {
                    m_dbConnection.Open();
                }
                string query = "SELECT COUNT(1) FROM Vartotojai WHERE Slapyvardis=@username AND Slaptazodis=@password";

                SQLiteCommand sql1 = new SQLiteCommand(query, m_dbConnection);
                sql1.CommandType = System.Data.CommandType.Text;
                sql1.Parameters.AddWithValue("@username", TxtBoxNick.Text);
                sql1.Parameters.AddWithValue("@password", TxtBoxPass.Password);
                string nick = TxtBoxNick.Text;
                string pass = TxtBoxPass.Password;
                count = Convert.ToInt32(sql1.ExecuteScalar());
                if (count == 1)
                {
                    this.Hide();
                    LoggedIn prisijunges = new LoggedIn();
                    prisijunges.Show();
                    backend.User.setUserId(nick, pass);
                }
                else
                {
                    MessageBox.Show("Neteisingai įvesti duomenys!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                m_dbConnection.Close();
            }
        }
        private void BtnRegistracija_Click(object sender, RoutedEventArgs e)
        {
            Registracija RegLangas = new Registracija();
            RegLangas.Show();
            this.Hide();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
    
}
