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
            bufferRow = diskData.diskRow;
        }
        public void AddToBufferData(int id, double salary)
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

    }
}
