using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecoveryDB
{
    class FormController
    {
        DiskData diskData = new DiskData();
        BufferLog bufferLog = new BufferLog();
        BufferData dataBuffer = new BufferData();

        //
        public void Execute(int transactionID, int id, double salary)
        {
            bufferLog.AddToBufferLog(transactionID, id, salary);
            dataBuffer.AddToBufferData(transactionID, id, salary);
        }

        public void Commit()
        {
            
        }

        public Dictionary<int, string> FillComboRegisters()
        {
            return diskData.GetDictionaryRegisters();
        }

        public Dictionary<int, string> FillComboTransactions()
        {
            return dataBuffer.GetDictionaryTransactions();
        }

        public List<string> FillListBufferLog()
        {
            return bufferLog.listTransactions();
        }

        public BindingList<Row> FillDiskDataList()
        {
            return new BindingList<Row>(diskData.diskRow);
        }

        public BindingList<Row> FillBufferDataList()
        {
            return new BindingList<Row>(dataBuffer.bufferRow);
        }

    }
}
