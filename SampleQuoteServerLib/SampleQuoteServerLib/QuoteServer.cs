using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SampleQuoteServerLib
{
    public class QuoteServer
    {
        private TcpListener listener;
        private int port;
        private string _fileName;
        private List<string> _quotes = new List<string>();
        private Random _random = new Random();
        private Task _listenerTask;

        public QuoteServer() : this("quotes.txt")
        {

        }

        public QuoteServer(string fileName) : this(fileName, 7890)
        {

        }

        public QuoteServer(string fileName, int port)
        {
            if (fileName == null)
                throw new ArgumentNullException(nameof(fileName));

            if (!File.Exists(fileName))
                throw new FileNotFoundException($"{nameof(fileName)}, Path: {fileName}");

            if (port < IPEndPoint.MinPort || port > IPEndPoint.MaxPort)
                throw new ArgumentOutOfRangeException("port not valid", nameof(port));

            _fileName = fileName;
            this.port = port;
        }

        public void Start()
        {
            ReadQuotes();
            _listenerTask = Task.Factory.StartNew(StartListener, TaskCreationOptions.LongRunning);
        }

        protected async Task StartListener()
        {
            try
            {
                IPAddress iPAddress = IPAddress.Any;
                listener = new TcpListener(iPAddress, port);
                listener.Start();

                while (true)
                {
                    using (Socket socket = await listener.AcceptSocketAsync())
                    {
                        string message = GetRandomQuoteOfTheDay();
                        var encoder = new UnicodeEncoding();
                        byte[] buffer = encoder.GetBytes(message);
                        socket.Send(buffer, buffer.Length, 0);
                    }
                }
            }
            catch (SocketException ex) {
                Trace.TraceError($"QuoteServer {ex.Message}");
                throw new SampleQuoteServerException("socket error", ex);
            }
        }

        public void Stop() => listener.Stop();

        public void Suspend() => listener.Stop();

        public void Resume() => Start();

        public void RefreshQuotes() => ReadQuotes();

        protected void ReadQuotes()
        {
            try
            {
                _quotes = File.ReadAllLines(_fileName).ToList();
                if (_quotes.Count == 0)
                    throw new SampleQuoteServerException("quote file is empty");
                _random = new Random();
            }
            catch (IOException ex)
            {
                throw new SampleQuoteServerException("I/O Error", ex);
            }
        }

        protected string GetRandomQuoteOfTheDay()
        {
            int index = _random.Next(0, _quotes.Count);
            return _quotes[index];
        }
    }


}
