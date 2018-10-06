using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace XOProject
{
    public class TradeAnalysis
    {
        decimal sum;
        private decimal _average;
        private decimal _maximum;
        private decimal _minimum;

        public decimal Sum { get => sum; set => sum = value; }

        public decimal Average { get => _average; set => _average = value; }

        public decimal Maximum { get => _maximum; set => _maximum = value; }

        public decimal Minimum { get => _minimum; set => _minimum = value; }

        public string Action { get; set; }

    }
}
