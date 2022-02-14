using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
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

namespace Task4_1_Config
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string fontSize = ConfigurationSettings.AppSettings["Foo"];
            NameValueCollection appSet = ConfigurationSettings.AppSettings["sf"].ToString(); ;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)RadioButton1.IsChecked) Label1.FontSize = 8;
            if ((bool)RadioButton2.IsChecked) Label1.FontSize = 10;
            if ((bool)RadioButton3.IsChecked) Label1.FontSize = 12;
            if ((bool)RadioButton4.IsChecked) Label1.FontSize = 14;
            if ((bool)RadioButton5.IsChecked) Label1.FontSize = 16;
        }
    }
}
