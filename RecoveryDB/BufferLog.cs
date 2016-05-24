using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    public class BufferLog
    {
        public List<Transaction> transactionList = new List<Transaction>();

        public void AddToBufferLog(int transactionID, int id, double salary, double beforeImage)
        {
            if (transactionID.Equals(0))
            {
                var transaction = new Transaction(FormController.transactionCounter + 1);
                transaction.AddOperation(id, salary, beforeImage);
                transactionList.Add(transaction);
                FormController.transactionCounter++;
            }
            else
            {
                transactionList.Single(x => x.transactionID.Equals(transactionID)).AddOperation(id, salary, beforeImage);
            }
        }

        public void CommitTransaction(int transactionID)
        {
            transactionList.Single(x => x.transactionID.Equals(transactionID)).commited = true;
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
                        + operation.registerID + ",Salary," 
                        + operation.beforeImage + "," 
                        + operation.afterImage + ">");
                }
                if (transaction.commited)
                {
                    list.Add("<END TA" + transaction.transactionID + ">");
                    list.Add("<COMMIT TA" + transaction.transactionID + ">");
                }
            }
            return list;
        }
    }
}
