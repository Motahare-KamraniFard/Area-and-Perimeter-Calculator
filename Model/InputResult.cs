using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_and_Perimeter_Calculator.Model
{
    public class InputResult
    {
        public double? Value { get; set; }
        public bool IsExit { get; set; }

        public InputResult(double? value, bool isExit)
        {
            Value = value;
            IsExit = isExit;
        }
    }
}
