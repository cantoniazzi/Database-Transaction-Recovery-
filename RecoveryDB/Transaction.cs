using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    class Transaction
    {
        public int transactionID { get; set; }
        public bool commited { get; set; }
        public List<Operation> operations = new List<Operation>();

        private const string constTableName = "funcionario";

        public Transaction(int transactionID)
        {
            this.transactionID = transactionID;
        }
        public string tableName
        {
            get
            {
                return constTableName;
            }
        }
        public void AddOperation(int id, double salary)
        {
            operations.Add(new Operation(id, salary));
        }
        
        
        
    }
}
