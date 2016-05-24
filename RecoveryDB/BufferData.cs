using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    public class BufferData
    {
        public List<BufferRow> bufferRows = new List<BufferRow>();       
        public BufferData()
        {
        }
        public void AddToBufferData(int transactionID, int id, double salary)
        {
            var counter = FormController.transactionCounter;
            if (transactionID.Equals(0))
            {
                transactionID = counter;
            }

            if (RegisterExists(id)) {
                var currentRow = bufferRows.Single(x => x.ID == id);
                currentRow.Salary = salary;
                currentRow.TransactionID = transactionID;
            }
            else
            {
                var row = new BufferRow()
                {
                    ID = id,
                    Name = FormController.diskData.GetRowById(id).Name,
                    Salary = salary,
                    TransactionID = transactionID
                };
                bufferRows.Add(row);
            }
            
        }

        private bool RegisterExists(int id)
        {
            return bufferRows.Any(x => x.ID.Equals(id));
        }

        private bool TransactionExists(int transactionID)
        {
            return bufferRows.Any(x => x.TransactionID.Equals(transactionID));
        }

        public Dictionary<int, string> GetDictionaryTransactions()
        {
            var dict = new Dictionary<int, string>();
            dict.Add(0, "New");
            foreach(var x in bufferRows)
            {
                if(x.TransactionID > 0)
                {
                    if(!dict.Any(y => y.Key.Equals(x.TransactionID)))
                    {
                        dict.Add(x.TransactionID, "TA" + x.TransactionID);
                    }
                }
            }
            return dict;
        }

        public void UnlockTransaction(int transactionID)
        {
            foreach(var x in bufferRows)
            {
                if (x.TransactionID.Equals(transactionID))
                {
                    x.TransactionID = 0;
                }
            }
        }
    }
}
