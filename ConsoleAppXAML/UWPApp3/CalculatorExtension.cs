using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UWPApp3
{
    public enum Operation
    { 
        Add,
        Subtract,
        Multiply,
        Divide
    }

    [MarkupExtensionReturnTypeAttribute(ReturnType =typeof(string))]
    internal class CalculatorExtension : MarkupExtension
    {
        public CalculatorExtension() { }

        public double X {  get; set; }
        public double Y { get; set; }

        public Operation Operation { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            
        }
    }
}
