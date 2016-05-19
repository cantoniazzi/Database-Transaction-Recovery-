using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    public class Operation
    {
        public int registerID { get; set; }
        public double beforeImage { get; set; }
        public double afterImage { get; set; }

        public Operation(int id, double salary)
        {
            this.registerID = id;
            this.setBeforeImage(this.registerID);
            this.afterImage = salary;
        }

        public void setBeforeImage(int _id)
        {
            DiskData diskData = new DiskData();
            this.beforeImage = diskData.GetSalaryById(_id);
        }
    }
}
