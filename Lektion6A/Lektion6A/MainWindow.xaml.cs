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

namespace Lektion6A
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

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            object temp = Label1.Content; 
            Label1.Content = Label3.Content;
            Label3.Content = temp;
        }

        private void RightButton_Click_1(object sender, RoutedEventArgs e)
        {
            object temp = Label2.Content;
            Label2.Content = Label4.Content;
            Label4.Content = temp;
        }
    }
}
