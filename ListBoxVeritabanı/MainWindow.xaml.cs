using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace ListBoxVeritabanı
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { //sql tanımlamak için öncelikle sql nesnesi yaratalım
        public SqlConnection conn;
        public SqlCommand cmd;
        string SqlString = "Select * From Person.ContactType";
        //sql tanımlaması yaptım 
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler
        }

    }
}
