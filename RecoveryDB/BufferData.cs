using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    class BufferData
    {
        List<BufferRow> bufferRow = new List<BufferRow>();
        DiskData diskData = new DiskData();

        public void AddToBufferData(int id, double salary)
        {
            if (IDExists(id)) {
                bufferRow.Single(x => x.ID == id).Salary = salary;
            }
            else
            {
                var row = new BufferRow()
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
