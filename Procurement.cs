using System;
using System.Collections.Generic;

namespace programmingWF
{
    public class Procurement
    {
        private string barCode;
        private string organization;
        private string name;
        private string note;
        private string status = "Ожидание";
        private int count;
        private double cost;
        private DateTime date;

        public Procurement(string barCode, string organization, string name, string note, double cost, DateTime date, int count)
        {
            this.barCode = barCode;
            this.organization = organization;
            this.name = name;
            this.note = note;
            this.date = date;
            this.cost = cost;
            this.count = count;
        }

        public string BarCode => barCode;
        public string Organization => organization;
        public string Name => name;
        public string Note => note;
        public string Status => status;
        public double Cost => cost;
        public int Count => count;
        public DateTime Date => date;
    }
}
