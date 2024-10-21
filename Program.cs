// See https://aka.ms/new-console-template for more information

//Task 1
using HomeWork9;

partial class Program
{

    static void Main()
    {

        TxtFileWorker txtWorker = new TxtFileWorker();
        txtWorker.MaxSize = 128;
        txtWorker.Write();
        txtWorker.Read();
        txtWorker.Edit();
        txtWorker.Delete();
    }
}





//Task 2

FinanceOperations bank = new Bank();
        {
            if (bank.CheckUserHistory())
            {
                double totalPayment = bank.CalculateLoanPercent(12, 100);
                Console.WriteLine($"Bank loan total payment: {totalPayment}");
            }
            else
            {
                Console.WriteLine("Bank:Your history is blackened in the bank ");
            }

            FinanceOperations microFinance = new MicroFinance();
            if (microFinance.CheckUserHistory())
            {
                double totalPayment = microFinance.CalculateLoanPercent(12, 100);
                Console.WriteLine($"MicroFinance loan total payment: {totalPayment}");
            }


        }
    }
}
    