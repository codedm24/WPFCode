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
    internal class MainViewModel : INotifyPropertyChanged
    {
        private string _userInput;
        public string UserInput
        {
            get => _userInput;
            set
            {
                _userInput = value;
                OnPropertyChanged("UserInput");
            }
        }

        private string _labelText;
        
        public string LabelText { 
            get { return _labelText; } 
            set { _labelText = value; 
                OnPropertyChanged(nameof(LabelText)); 
            } 
        }
        
        public ICommand ChangeTextCommand { get; }

        public MainViewModel() { 
            LabelText = "Original Text"; 
            ChangeTextCommand = new RelayCommand(ChangeText);
        }

        private void ChangeText(object parameter) { LabelText = "Text Changed!"; }

        public event PropertyChangedEventHandler PropertyChanged; 
        
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
