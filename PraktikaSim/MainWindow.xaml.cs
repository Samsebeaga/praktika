using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;


namespace PraktikaSim
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private async Task Main(object sender, RoutedEventArgs e)
        {
            SqlCommand command = new SqlCommand();
            String connectionString = @"Server=192.168.10.15\SQLEXPRESS;Initial Catalog = Simonzhenkova; User ID = wsr-6; password d = #6d241Ac086b7$; Persist Security Info=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                Console.WriteLine("Подключение открыто");
            }
        }
            public MainWindow()
        {
            InitializeComponent();
        }
      
            

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
