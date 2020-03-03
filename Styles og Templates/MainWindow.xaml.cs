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

namespace Styles_og_Templates
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            r1.Style = (Style)(this.Resources["rsty"]);
            r2.Style = (Style)(this.Resources["rsty"]);
            r3.Style = (Style)(this.Resources["rsty"]);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            b1.Style = (Style)(this.Resources["Style2"]);
            b2.Style = (Style)(this.Resources["Style2"]);
            b3.Style = (Style)(this.Resources["Style2"]);
            r1.Style = (Style)(this.Resources["hsty"]);
            r2.Style = (Style)(this.Resources["hsty"]);
            r3.Style = (Style)(this.Resources["hsty"]);
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            r1.Style = (Style)(this.Resources["rsty"]);
            r2.Style = (Style)(this.Resources["rsty"]);
            r3.Style = (Style)(this.Resources["rsty"]);
            b1.Style = (Style)(this.Resources["ButtonS1"]);
            b2.Style = (Style)(this.Resources["ButtonS1"]);
            b3.Style = (Style)(this.Resources["ButtonS1"]);
        }
    }
}
