using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListContestants
{
    public class Contestant
    {
        public int UniqueNumber { get; set; }
        public double Results { get; set; }

        public Contestant(int uniqueNumber, double results)
        {
            this.UniqueNumber = uniqueNumber;
            this.Results = results;
        }

        public override string ToString()
        {
            return $"Contestant #{this.UniqueNumber} - Results: {this.Results}";
        }
    }
}
