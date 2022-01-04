using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson2.Task1
{
    class BankBill
    {
        private readonly long _BillNumber;
        private readonly  double _Balance;
        private readonly BillTypes _TheBillTypes;
        private static long LastBillNumber;

        internal BankBill(): this(BillTypes.CompanyBill)
        {
            GenerateBillNumber();
            Console.Write("The Last Number is: "+LastBillNumber);
        }
        internal BankBill(BillTypes types) : this(5555, BillTypes.CompanyBill)
        {
            GenerateBillNumber();
            Console.Write("The Last Number is: " + LastBillNumber);
        }
        internal BankBill (int balance, BillTypes types)
        {
            _Balance = balance;
            _TheBillTypes = types;
            GenerateBillNumber();
            Console.Write("The Last Number is: " + LastBillNumber + " Balance: " +_Balance+" BillTypes: "+_TheBillTypes);
        }


        internal enum BillTypes{
             CompanyBill,
             PrivateBill
        }


        internal long GetBillNumber()
        {
            return _BillNumber;
        }

        internal double GetBalance()
        {
            return _Balance;
        }

        internal BillTypes GetBillTypes()
        {
            return _TheBillTypes;
        }

        internal long GenerateBillNumber()
        {
            return LastBillNumber++;
        }
    }
}
