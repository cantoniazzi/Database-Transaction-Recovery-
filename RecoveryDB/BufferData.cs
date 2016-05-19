using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    public class BufferData
    {
        DiskData diskData = new DiskData();
        public List<BufferRow> bufferRow = new List<BufferRow>();
        
        public BufferData()
        {
        }
        public void AddToBufferData(int transactionID, int id, double salary)
        {
            if (transactionID.Equals(0))
            {
                if (bufferRow.Count().Equals(0))
                {
                    transactionID = 1;
                }else
                {
                    transactionID = bufferRow.Max(x => x.TransactionID);
                }
            }
            if (RegisterExists(id)) {
                bufferRow.Single(x => x.ID == id).Salary = salary;
            }
            else
            {
                var row = new BufferRow()
                {
                    ID = id,
                    Name = diskData.GetRowById(id).Name,
                    Salary = salary,
                    TransactionID = transactionID
                };
                bufferRow.Add(row);
            }
        }

        private bool RegisterExists(int id)
        {
            return bufferRow.Any(x => x.ID.Equals(id));
        }

        private bool TransactionExists(int transactionID)
        {
            return bufferRow.Any(x => x.TransactionID.Equals(transactionID));
        }

        public Dictionary<int, string> GetDictionaryTransactions()
        {
            var dict = new Dictionary<int, string>();
            dict.Add(0, "New");
            FormController.bufferLog.transactionList.ForEach(x => dict.Add(x.transactionID, "TA" + x.transactionID));
            return dict;
        }
    }
}
