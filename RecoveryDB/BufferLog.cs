﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    class BufferLog
    {
        public List<Transaction> transactionList = new List<Transaction>();

        public void AddToBufferLog(int transactionID, int id, double salary)
        {

            if (transactionID.Equals(0))
            {
                var transaction = new Transaction(transactionList.Count() + 1);
                transaction.AddOperation(id, salary);
                transactionList.Add(transaction);
            }
            else
            {
                transactionList.Single(x => x.transactionID.Equals(transactionID)).AddOperation(id, salary);
            }
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
