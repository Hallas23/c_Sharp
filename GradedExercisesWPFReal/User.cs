using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradedExercisesWPFReal
{
    public class User : INotifyPropertyChanged
    {
        public User(string data)
        {
            var L = data.Split(';');
            Name = L[0];
            Id = int.Parse(L[1]);
            Age = int.Parse(L[2]);
            Score = int.Parse(L[3]);
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        private string name;
        public int Age { get; set; }
        public int Score { get; set; }
        public int Id { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public string ListBoxToString
        {
            get
            {
                return Name + " (" + Id + ")";
            }
        }

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public override string ToString()
        {
            return String.Format(" Name : {0,-5} ID : {1,3} Age : {2,3} Score : {3,3} ", Name, Id, Age, Score);
        }
    }
}
