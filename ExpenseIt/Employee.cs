using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseIt
{
    public class Employee : INotifyPropertyChanged
    {
        /*private DateTime _startDate;
        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                _startDate = value;
                OnPropertyChanged();
            }
        }*/

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                RaisePropertyChanged();
            }
        }
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                RaisePropertyChanged();
            }
        }

        private bool _wasReelected;
        public bool WasReelected
        {
            get
            {
                return _wasReelected;
            }

            set
            {
                _wasReelected = value;
                RaisePropertyChanged();
            }
        }

        private Party _affiliation;
        public Party Affiliation
        {
            get
            {
                return _affiliation;
            }
            set
            {
                _affiliation = value;
                RaisePropertyChanged();
            }
        }

        /*public Employee(string name, string title, DateTime startDate)
        {
            Name = name;
            Title = title;
            //StartDate = startDate;
        }*/

        /*public static Employee GetEmployee()
        {
            var emp = new Employee()
            {
                Name = "Tom",
                Title = "Developer"
            };

            return emp;
        }*/

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }

        /*private void OnPropertyChanged(
            [CallerMemberName] string caller = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
            }
        }*/

        public static ObservableCollection<Employee> GetEmployees()
        {
            var employees = new ObservableCollection<Employee>
            {
                new Employee { Name = "Washington", Title = "President 1", WasReelected=true, Affiliation = Party.Independent },
                new Employee { Name = "Adams", Title = "President 2", WasReelected=false, Affiliation = Party.Federalist },
                new Employee { Name = "Jefferson", Title = "President 3", WasReelected=true, Affiliation = Party.DemocratRepublican },
                new Employee { Name = "Madison", Title = "President 4", WasReelected=true, Affiliation = Party.DemocratRepublican },
                new Employee { Name = "Monroe", Title = "President 5", WasReelected=true, Affiliation = Party.DemocratRepublican }
            };
            return employees;
        }
    }

    public enum Party
    {
        Independent, Federalist, DemocratRepublican
    }

}
