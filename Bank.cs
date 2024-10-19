using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9

{
    public interface FinanceOperations
    {
        double CalculateLoanPercent(int month, double AmountPerMonth);
        bool CheckUserHistory();
    }
    public class Bank : FinanceOperations
    {
        public bool CheckUserHistory()
        {
            Random random = new Random();
            return random.Next(0, 2) == 0;
        }
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            double totalAmount = month * AmountPerMonth;
            double interest = totalAmount * 0.05;
            return totalAmount + interest;
        }
    }
    public class MicroFinance : FinanceOperations
    {
        public bool CheckUserHistory()
        {
            return true;
        }
        public double CalculateLoanPercent(int month, double AmountPerMonth)
        {
            double totalAmount = month * AmountPerMonth;
            double interest = totalAmount * 0.10;
            double serviceFee = month * 4;
            return totalAmount + interest + serviceFee;
        }

    }
}