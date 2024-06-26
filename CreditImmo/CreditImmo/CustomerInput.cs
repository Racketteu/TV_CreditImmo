﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditImmo
{
    public class CustomerInput
    {
        private int Duration { get; set; }
        private decimal Amount { get; set; }
        private decimal NominalRate { get; set; }

        public CustomerInput(int duration, decimal amount, decimal nominalRate)
        {
            Duration = duration;
            Amount = amount;
            NominalRate = nominalRate;
        }

        public int GetDuration() { return Duration; }
        public decimal GetAmount() { return Amount; }
        public decimal GetNominalRate() { return NominalRate; }


        public bool CheckDuraction()
        {
            if (GetDuration() >= 108 && GetDuration() <= 300)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckAmount()
        {
            if (GetAmount() >= 50000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckNominalRate()
        {
            if (GetNominalRate() >= 0 && GetNominalRate() <= 100)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
