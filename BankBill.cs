using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrains.OOP.Lesson2.Task1
{
    class BankBill
    {
        internal long BillNumber {get; set; }
        internal double Balance {get; set; }

        internal enum BillTypes{
             CompanyBill,
             PrivateBill
        }
        private BillTypes _BillTypes;

        internal BillTypes CurrentBillTypes
        {
            get { return _BillTypes; }
            set { _BillTypes = value; }
        }
    }
}
