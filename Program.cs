using System;

namespace CabInvoiceGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO CAB INVOICE GENERATOR PROJECT");
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double fare = invoiceGenerator.CalculateFare(3.0, 4);
            Console.WriteLine("Fare: "+ fare);
            
        }
    }
}