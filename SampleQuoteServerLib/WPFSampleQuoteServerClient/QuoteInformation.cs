using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPFSampleQuoteServerClient
{
    public class QuoteInformation : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private bool _enableRequest;
        private string _quote = string.Empty;

        public QuoteInformation()
        {
            _enableRequest = true;
        }

        public string Quote
        {
            get { return _quote; }
            internal set { SetProperty(ref _quote, value); }
        }

        public bool EnableRequest {
            get { return _enableRequest; }
            internal set { SetProperty(ref _enableRequest, value); }
        }

        private void SetProperty<T>(ref T field, T value, [CallerMemberName] string? propertyName = null) { 
            if(!EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
