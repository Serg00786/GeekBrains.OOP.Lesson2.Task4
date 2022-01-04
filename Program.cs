using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson2.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankBill bankBill = new BankBill();
            bankBill.Balance = 1111;
            bankBill.BillNumber = 22222;
            bankBill.CurrentBillTypes = BankBill.BillTypes.CompanyBill;

            Console.ReadKey();
        }
    }
}
