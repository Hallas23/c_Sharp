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

namespace Lektion7B_WpfDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person p = new Person("Ole;70;24;100");
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
    }
}
