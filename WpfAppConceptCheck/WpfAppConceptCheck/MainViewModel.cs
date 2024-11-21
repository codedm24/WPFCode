using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfAppConceptCheck
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private string _userInput;
        private string _labelText;
        private bool isBackgroundGreen;

        public MainViewModel()
        {
            LabelText = "Original Text";
            ChangeTextCommand = new RelayCommand(ChangeText);
        }

        public string UserInput
        {
            get => _userInput;
            set
            {
                _userInput = value;
                OnPropertyChanged("UserInput");
            }
        }
        
        public string LabelText { 
            get => _labelText; 
            set { _labelText = value; 
                OnPropertyChanged(nameof(LabelText)); 
            } 
        }

        public bool IsBackgroundGreen
        {
            get => isBackgroundGreen;

            set
            {
                isBackgroundGreen = value;
                OnPropertyChanged();
            }
        }

        public ICommand ChangeTextCommand { get; }

        public event PropertyChangedEventHandler PropertyChanged;


        private void ChangeText(object parameter) { 
            LabelText = "Text Changed!"; 
        }              
         
        
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
