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
using System.Windows.Shapes;
using SirketUygulama;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Threading;

namespace SirketUygulama
{
    /// <summary>
    /// Interaction logic for Intro.xaml
    /// </summary>
    public partial class Intro : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        
        public Intro()
        {
            InitializeComponent();
            timer.Interval = TimeSpan.FromSeconds(0.5);
            timer.Start();
            timer.Tick += Timer_Tick;   
            try
            {
             
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=Sirketdb;Integrated Security=True";
                con.Open();


            }
            catch (Exception)
            {
                MessageBox.Show("İnternete bağlanılamıyor");
                Close();
            }

             


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(prg.Value==100)
            {
                MainWindow pencere = new MainWindow();
                pencere.Show();
                this.Hide();
                timer.Stop();
            }
            prg.Value += 10;
            }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
