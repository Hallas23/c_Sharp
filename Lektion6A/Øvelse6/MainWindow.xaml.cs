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

namespace Øvelse6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> Check = new List<String>();
        List<String> Radio = new List<String>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Method(object sender, RoutedEventArgs e)
        {
            SBI.Content = "";
            Control temp1;
            Control temp2;
            string CheckBoxS = "";
            string RadioButS = "";
            if (sender is CheckBox)
            {
                temp1 = sender as CheckBox;
                CheckBoxS = temp1.Name;
            }
            else
            {
                temp2 = sender as RadioButton;
                RadioButS = temp2.Name;
            }
            if (CheckBoxS.Length > 0)
            {
                if (Check.Contains(CheckBoxS))
                {
                    Check.Remove(CheckBoxS);
                }
                else
                {
                    Check.Add(CheckBoxS);
                }
            }
            if (RadioButS.Length > 0)
            {
                if (Radio.Contains(RadioButS))
                {
                    Radio.Remove(RadioButS);
                }
                else
                {
                    Radio = new List<string>
                    {
                        RadioButS
                    };
                }
            }
            SBI.Content += Radio[0];
            foreach(String si in Check)
            {
                SBI.Content += si;
            }
        }
    }
}
