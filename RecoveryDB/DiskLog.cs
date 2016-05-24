using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    public class DiskLog
    {
        public List<Transaction> transactionList = new List<Transaction>();

        public void CommitTransaction(int transactionID)
        {
            var transactionToAdd = FormController.bufferLog.transactionList.
                                    Single(x => x.transactionID.Equals(transactionID));
            transactionList.Add(transactionToAdd);
        }

        public List<string> listTransactions()
        {
            var list = new List<string>();

            foreach (var transaction in transactionList)
            {
                list.Add("<START TA" + transaction.transactionID + ">");
                foreach (var operation in transaction.operations)
                {
                    list.Add("<TA" + transaction.transactionID + ","
                        + transaction.tableName + ","
                        + operation.registerID + ", Salary, "
                        + operation.beforeImage + ","
                        + operation.afterImage + ">");
                }
                if (transaction.commited)
                {
                    list.Add("<END TA" + transaction.transactionID + ">");
                }
            }
            return list;
        }
    }
}
