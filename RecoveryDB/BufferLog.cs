using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    class BufferLog
    {
        public List<Transaction> transactions = new List<Transaction>();

        public void AddToBufferLog(int id, double salary)
        {
            if (transactions.Count().Equals(0) || transactions.Last().commited)
            {
                var transaction = new Transaction(transactions.Count() + 1);
                transactions.Add(transaction);
            }
            transactions.Last().AddOperation(id, salary);
        }

        public List<string> listTransactions()
        {
            var list = new List<string>();

            foreach (var transaction in transactions)
            {
                list.Add("<START TA" + transaction.transactionID + ">");
                foreach (var operation in transaction.operations)
                {
                    list.Add("<" + transaction.transactionID + "," 
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
