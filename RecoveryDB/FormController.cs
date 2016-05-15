﻿using System;
using System.Collections.Generic;
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
        BufferData bufferData = new BufferData();

        //
        public void Execute(int id, double salary)
        {
            bufferLog.AddToBufferLog(id, salary);
            bufferData.AddToBufferData(id, salary);
        }

        public void Commit()
        {
            
        }

        public Dictionary<int, string> fillComboRegisters()
        {
            return diskData.GetDictionaryRegisters();
        }

        public List<string> fillListBufferLog()
        {
            return bufferLog.listTransactions();
        }

        public List<ListViewItem> FillDiskDataList()
        {
            return diskData.GetListItems();
        }

    }
}