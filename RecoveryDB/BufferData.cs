using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    class BufferData
    {
        DiskData diskData = new DiskData();
        public List<Row> bufferRow = new List<Row>();
        
        public BufferData()
        {
        }
        public void AddToBufferData(int transactionID, int id, double salary)
        {
            if (IDExists(id)) {
                bufferRow.Single(x => x.ID == id).Salary = salary;
            }
            else
            {
                var row = new Row()
                {
                    ID = id,
                    Name = diskData.GetRowById(id).Name,
                    Salary = salary
                };
                bufferRow.Add(row);
            }
            
        }

        private bool IDExists(int id)
        {
            return bufferRow.Any(x => x.ID == id);
        }

        public Dictionary<int, string> GetDictionaryTransactions()
        {
            var dict = new Dictionary<int, string>();
            dict.Add(0, "New");
            bufferRow.ForEach(x => dict.Add(x.ID, "TA" + x.ID));
            return dict;
        }
    }
}
