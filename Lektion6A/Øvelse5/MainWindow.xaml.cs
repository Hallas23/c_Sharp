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

namespace Øvelse5
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

        private void OpenClick(object sender, RoutedEventArgs e)
        {
            StatusBarI.Content = "Open";
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            StatusBarI.Content = "Saved";
        }
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void AboutWindow(object sender, RoutedEventArgs e)
        {
            Window popup = new Window();
            popup.Show();
            
        }
    }
}
