using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UWPApp1
{

    internal class Program
    {
       
        static void Main()
        {
            Application.Start(p =>
            {
                new App();
            });
        }
    }
}
