using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuoteServerService
{
    public partial class SampleQuoteService : ServiceBase
    {
        private const string QUOTESFILE = "quotes.txt";

        private SampleQuoteServerLib.QuoteServer _quoteServer = null;
        public SampleQuoteService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (_quoteServer == null)
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, QUOTESFILE);
                _quoteServer = new SampleQuoteServerLib.QuoteServer(filePath, 5678);
                //_quoteServer = new SampleQuoteServerLib.QuoteServer();
            }
            _quoteServer.Start();
        }

        protected override void OnStop()
        {
            if(_quoteServer != null )
                _quoteServer.Stop();
        }

        protected override void OnPause() => _quoteServer.Suspend();

        protected override void OnContinue() => _quoteServer.Resume();
    }
}
