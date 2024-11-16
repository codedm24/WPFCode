using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAppConceptCheck
{
    internal class PersonViewModel : INotifyPropertyChanged
    {
        private Person _person;
        public Person Person
        {
            get
            {
                return _person;
            }
            set
            {
                _person = value; 
                OnPropertyChanged(nameof(Person));
            }
        }
        public ICommand ShowNameCommand { get; }

        public PersonViewModel() { 
            Person = new Person { 
                Name = "John Doe", 
                Age = 30 
            }; 
            ShowNameCommand = new RelayCommand(ShowName); 
        }

        private void ShowName(object parameter) { 
            MessageBox.Show($"Name: {Person.Name}"); 
        }
        
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName) { 
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); 
        }
    }
}
