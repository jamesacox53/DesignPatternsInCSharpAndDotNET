using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section21State
{
    public class CombinationLock
    {
        private int[] combination;
        private string combinationString;

        public CombinationLock(int[] combination)
        {
            this.combination = combination;
            this.combinationString = string.Join("", combination.Select(i => i.ToString()));
            this.Status = "LOCKED";
        }

        public string Status;

        public void EnterDigit(int digit)
        {
            if (this.Status == "ERROR" || this.Status == "OPEN")
                return;

            if (this.Status == "LOCKED")
                this.Status = "";

            this.Status += digit;

            if (this.Status == combinationString)
            {
                this.Status = "OPEN";
                return;
            }

            if (!this.combinationString.StartsWith(Status))
            {
                this.Status = "ERROR";
                return;
            }
        }
    }
}
