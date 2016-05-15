using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecoveryDB
{
    public class DiskData
    {
        public List<DiskRow> diskRow = new List<DiskRow>();
        string filePath = "DiskData.txt";
        public DiskData()
        {
            LoadDiskData();
        }
        private StreamReader streamReader
        {
            get
            {
                return new StreamReader(filePath);
            }
        }

        private StreamWriter streamWriter
        {
            get
            {
                return new StreamWriter(filePath, false);
            }
        }

        private void LoadDiskData()
        {
            diskRow.Clear();
            var reader = streamReader;
            string currentLine;
            while((currentLine = reader.ReadLine()) != null)
            {
                var split = currentLine.Split(',');

                int id = int.Parse(split[0]);
                string name = split[1];
                double salary = double.Parse(split[2]);

                var row = new DiskRow()
                {
                    ID = id,
                    Name = name,
                    Salary = salary
                };

                diskRow.Add(row);
            }
            reader.Close();
        }

        private void SaveDiskData()
        {
            var writer = streamWriter;
            diskRow.ForEach(x => writer.WriteLine(x.ID + "," + x.Name + "," + x.Salary));
            writer.Close();
        }

        public DiskRow GetRowById(int id)
        {
            LoadDiskData();
            return diskRow.Single(x => x.ID.Equals(id));
        }

        public double GetSalaryById(int id)
        {
            LoadDiskData();
            return diskRow.Single(x => x.ID.Equals(id)).Salary;
        }

        public void SetSalaryById(int id, double salary)
        {
            diskRow.Single(x => x.ID.Equals(id)).Salary = salary;
            SaveDiskData();
            LoadDiskData();
        }
        public void SetNameById(int id, string name)
        {
            diskRow.Single(x => x.ID.Equals(id)).Name = name;
            SaveDiskData();
            LoadDiskData();
        }

        public Dictionary<string, int> GetDictionaryRegisters()
        {
            var dict = new Dictionary<string, int>();
            LoadDiskData();
            diskRow.ForEach(x => dict.Add(x.Name, x.ID));
            return dict;
        }

    }
}
