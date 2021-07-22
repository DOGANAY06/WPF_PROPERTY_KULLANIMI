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

namespace Property
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            changeProperty();
            StackPanel sp = new StackPanel(); //stackpanel oluşturup özelliklerini belirledim 
            sp.Background = new SolidColorBrush(Colors.Aquamarine); //renk belirledik 
            sp.Width = 100;
            sp.Height = 50;
            sp.Margin = new Thickness(100, 0, 0, 250); //margin kenarlıkları 
             
            Button btn = new Button(); //button oluşturdum 
            
            btn.Content = "Code Button"; //buttonun içine yazılacak metin 
            btn.Width =100;  
            btn.Height = 50;
            btn.Click += btn_Code_Click;  //buttona tıklandığında ne olacağını aldığımız metot 
            btn.Margin = new Thickness(0,0,0,250); //margin kenarlıkları 

            sp.Children.Add(btn); //stackpanele buttonu ekledim 
            grd1.Children.Add(sp); //grid in çocuğu olarak code tarafından oluşturulan buttonu ekledim
        }

        private void btn_Code_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ben code tarafından BUTTON"); //butona tıklandığında bu mesaj eklenecek 
        }

        void changeProperty()
        { //windows pencerenin rengini belirlemek için kullandım bu metodu
            LinearGradientBrush brush = new LinearGradientBrush();

            GradientStop stop1 = new GradientStop();
            stop1.Offset = 0;
            stop1.Color = Colors.Red;
            brush.GradientStops.Add(stop1);

            GradientStop stop2 = new GradientStop();
            stop2.Offset = 1;
            stop2.Color = Colors.DarkBlue;
            brush.GradientStops.Add(stop2);

            grd1.Background = brush;

        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ben XAML tarafından BUTTON"); //XAML tarafından oluşturduğum buttona tıklanınca da bu mesaj gelir
        }
    }
}
