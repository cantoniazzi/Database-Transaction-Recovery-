using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RecoveryDB;
using FluentAssertions;

namespace RecoveryDBTest
{
    [TestClass]
    public class TextFileTest
    {
        [TestMethod]
        public void ReadID()
        {
            var diskData = new DiskData();
            diskData.GetRowById(1).ID.Should().Be(1);
        }
        [TestMethod]
        public void ReadName()
        {
            var diskData = new DiskData();
            diskData.GetRowById(1).Name.Should().Be("Maria");
        }
        [TestMethod]
        public void ReadSalary()
        {
            var diskData = new DiskData();
            diskData.GetRowById(1).Salary.Should().Be(500);
        }

        [TestMethod]
        public void WriteSalary()
        {
            var diskData = new DiskData();
            diskData.SetSalaryById(3, 700.00);
            diskData.GetRowById(3).Salary.Should().Be(700.00);
        }
        [TestMethod]
        public void WriteName()
        {
            var diskData = new DiskData();
            diskData.SetNameById(3, "Pedro");
            diskData.GetRowById(3).Name.Should().Be("Pedro");
        }
    }
}
