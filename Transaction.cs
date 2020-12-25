using System;

namespace programmingWF
{
    public class Transaction
    {
        private string number;
        private string barCode;
        private DateTime date;
        private string organization;
        private string type;
        private double sum;
        private string status = "Ожидание";
        private string note;

        Transaction(string number, string barCode, DateTime date, string organization, string type, double sum,
            string status, string note)
        {
            this.number = number;
            this.barCode = barCode;
            this.date = date;
            this.organization = organization;
            this.type = type;
            this.sum = sum;
            this.status = status;
            this.note = note;
        }
        public string Number => number;
        public string BarCode => barCode;
        public DateTime Date => date;
        public string Organization => organization;
        public string Type => type;
        public double Sum => sum;
        public string Status => status;
        public string Note => note;
    }
}