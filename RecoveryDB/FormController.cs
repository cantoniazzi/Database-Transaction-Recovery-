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
        public static BufferData bufferData = new BufferData();
        public static DiskLog diskLog = new DiskLog();
        public static int transactionCounter;

        public static void Execute(int transactionID, int id, double salary)
        {
            //Manter essa ordem
            bufferLog.AddToBufferLog(transactionID, id, salary, GetsBeforeImage(id));
            bufferData.AddToBufferData(transactionID, id, salary);
        }

        private static double GetsBeforeImage(int id)
        {
            if (bufferData.bufferRows.Any(x => x.ID == id))
            {
                return bufferData.bufferRows.Single(x => x.ID.Equals(id)).Salary;
            }else
            {
                return diskData.GetSalaryById(id);
            }
        }

        public static void Commit(int transactionID)
        {
            bufferLog.CommitTransaction(transactionID);
            bufferData.UnlockTransaction(transactionID);
            diskLog.CommitTransaction(transactionID);
        }

        public static Dictionary<int, string> FillComboRegisters(int currentTransaction)
        {
            return diskData.GetDictionaryRegisters(bufferData.bufferRows, currentTransaction);
        }

        public static Dictionary<int, string> FillComboTransactions()
        {
            return bufferData.GetDictionaryTransactions();
        }

        public static List<string> FillListBufferLog()
        {
            return bufferLog.listTransactions();
        }

        public static List<string> FillListDiskLog()
        {
            return diskLog.listTransactions();
        }

        public static BindingList<Row> FillDiskDataList()
        {
            return new BindingList<Row>(diskData.diskRow);
        }

        public static BindingList<BufferRow> FillBufferDataList()
        {
            return new BindingList<BufferRow>(bufferData.bufferRows);
        }

    }
}
