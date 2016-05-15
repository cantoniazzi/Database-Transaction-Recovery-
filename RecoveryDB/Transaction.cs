using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    class Transaction
    {
        public int registerID { get; set; }
        public double beforeImage { get; set; }
        public double afterImage { get; set; }

        public const string tableName = "funcionario";
        public const int transactionID = 1;

        public void setBeforeImage(int _id)
        {
            DiskData diskData = new DiskData();
            this.beforeImage = diskData.GetSalaryById(_id);
        }
        
    }
}
