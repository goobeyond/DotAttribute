using System;
using System.Collections.Generic;
using System.Text;

namespace DotAttribute.ConsoleClient
{
    class ChartJsData
    {
        public double[] data = new double[25];
        public string label { get; set; }
        public string borderColor { get; set; }
        public bool fill { get; set; }
    }
}
