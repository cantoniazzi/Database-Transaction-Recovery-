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

        public Operation(int id, double afterImage, double beforeImage)
        {
            this.registerID = id;
            this.beforeImage = beforeImage;
            this.afterImage = afterImage;
        }
    }
}
