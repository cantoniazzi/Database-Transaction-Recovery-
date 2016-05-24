using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecoveryDB
{
    public static class FormController
    {
        public static DiskData diskData = new DiskData();
        public static BufferLog bufferLog = new BufferLog();
        public static BufferData dataBuffer = new BufferData();

        //
        public static void Execute(int transactionID, int id, double salary)
        {
            bufferLog.AddToBufferLog(transactionID, id, salary);
            dataBuffer.AddToBufferData(transactionID, id, salary);
        }

        public static void Commit()
        {
            
        }

        public static Dictionary<int, string> FillComboRegisters(int currentTransaction)
        {
            return diskData.GetDictionaryRegisters(dataBuffer.bufferRow,currentTransaction);
        }

        public static Dictionary<int, string> FillComboTransactions()
        {
            return dataBuffer.GetDictionaryTransactions();
        }

        public static List<string> FillListBufferLog()
        {
            return bufferLog.listTransactions();
        }

        public static BindingList<Row> FillDiskDataList()
        {
            return new BindingList<Row>(diskData.diskRow);
        }

        public static BindingList<BufferRow> FillBufferDataList()
        {
            return new BindingList<BufferRow>(dataBuffer.bufferRow);
        }

    }
}
