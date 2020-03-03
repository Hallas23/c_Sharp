using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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

namespace GradedExercisesWPFReal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> data = new ObservableCollection<User>();

        public MainWindow()
        {
            InitializeComponent();

            listBox.ItemsSource = data;
            gridOuter.DataContext = data;
        }

        private void GetUsers(object sender, RoutedEventArgs e)
        {
            data.Clear();
            NameB.Text = " ";
            IDB.Text = " ";
            AgeB.Text = " ";
            ScoreB.Text = " ";
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string[] lines = (File.ReadAllLines(openFileDialog.FileName));
                foreach (string sp in lines)
                {
                    User p = new User(sp);
                    data.Add(p);
                }

            }
            string time = DateTime.Now.ToString("h:mm:ss tt");
            stBarI.Content = "Antal linjer: " + data.Count() + ", klokken: " + time ;
        }

        private void Person_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ListBox).SelectedItem is User p)
            {
                NameB.Text = p.Name;
                IDB.Text = p.Id.ToString();
                AgeB.Text = p.Age.ToString();
                ScoreB.Text = p.Score.ToString();
            }
        }
    }
}
