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

namespace Øvelse2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Person p = new Person("Ole;70;24;100");
        public MainWindow()
        {
            InitializeComponent();
            NameP = p.Name;
            WeightP = Convert.ToString(p.Weight);
            AgeP = p.Age.ToString();
            ScoreP = Convert.ToString(p.Score);
            AcceptedP = "True";
            Name.DataContext = this;
            Weight.DataContext = this;
            Age.DataContext = this;
            Score.DataContext = this;
            Accepted.DataContext = this;



        }
        public string NameP { get; set; }
        public string WeightP { get; set; }
        public string AgeP { get; set; }
        public string ScoreP { get; set; }
        public string AcceptedP { get; set; }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            p.Name = ((TextBox)sender).Text;
        }
    }
}

