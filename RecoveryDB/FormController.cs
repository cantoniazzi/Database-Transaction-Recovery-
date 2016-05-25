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

        //Se na mesma transação for alterado a mesma linha, BeforeImage = Valor respectivo no BufferData
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
            //se a transação já existe no disk log, apaga e escreve de novo
            //ex: commit em uma transação já no disk log via checkpoint
            if (diskLog.transactionList.Any(x => x.transactionID == transactionID))
            {
                diskLog.transactionList.Remove(diskLog.transactionList.Single(z => z.transactionID == transactionID));
            }
            bufferLog.CommitTransaction(transactionID);
            bufferData.UnlockTransaction(transactionID);
            diskLog.CommitTransaction(transactionID);
        }

        public static void Checkpoint()
        {
            BufferLogToDiskLog();
            BufferDataToDiskData();
        }

        private static void BufferDataToDiskData()
        {
            foreach(var x in bufferData.bufferRows)
            {
                diskData.SetSalaryById(x.ID, x.Salary);
            }
        }

        private static void BufferLogToDiskLog()
        {
            //pega as transações não commitadas
            var transactionsToAdd = bufferLog.transactionList.Where(x => x.commited == false).ToList();

            foreach (var x in transactionsToAdd)
            {
                //se a transação já existe no disk log, apaga e escreve de novo
                if(diskLog.transactionList.Any(y => y.transactionID == x.transactionID))
                {
                    diskLog.transactionList.Remove(diskLog.transactionList.Single(z => z.transactionID == x.transactionID));
                }
                diskLog.transactionList.Add(x);
            }
        }

        //REVISAR
        public static void Recovery()
        {
            var commitedList = diskLog.transactionList.Where(x => x.commited == true).ToList();
            var nonCommitedList = diskLog.transactionList.Where(x => x.commited == false).ToList();

            Redo(commitedList);
            Undo(nonCommitedList);
        }
        //REVISAR
        private static void Redo(List<Transaction> transactionList)
        {
            foreach (var transaction in transactionList)
            {
                foreach (var operation in transaction.operations)
                {
                    diskData.SetSalaryById(operation.registerID, operation.afterImage);
                }
            }
        }
        //REVISAR
        private static void Undo(List<Transaction> transactionList)
        {
            for (var i = transactionList.Count() - 1; i >= 0; i--)
            {
                for (var j = transactionList[i].operations.Count() - 1; j >= 0; j--)
                {
                    var currentOperation = transactionList[i].operations[j];
                    diskData.SetSalaryById(currentOperation.registerID, currentOperation.beforeImage);
                }
            }
        }
        public static void WipeMemory()
        {
            bufferData.bufferRows.Clear();
            bufferLog.transactionList.Clear();
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

        public static BindingList<BufferRow> FillDataBufferList()
        {
            return new BindingList<BufferRow>(bufferData.bufferRows);
        }

    }
}
