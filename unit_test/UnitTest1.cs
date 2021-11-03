using Microsoft.VisualStudio.TestTools.UnitTesting;
using music_records.Managers;
using music_records.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace unit_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetRecord()
        {
            int expectedResult = 2;
            MusicRecordManager mrm = new MusicRecordManager();
            IEnumerable<MusicRecord> records = mrm.Get_Records();
            Assert.AreEqual(expectedResult, records.Count());

            //filter
            int expected2 = 1;
            string searchname = "record 1";
            IEnumerable<MusicRecord> records2 = mrm.Get_Records(searchname);
            Assert.AreEqual(expected2, records2.Count());

            //add method
            MusicRecord musicRecord = new MusicRecord(0, "record 3", "no label", 68, DateTime.Now, 12);
            int expected3 = 3;
            mrm.Add_Record(musicRecord);
            IEnumerable<MusicRecord> records3 = mrm.Get_Records();
            Assert.AreEqual(expected3, records3.Count());

            //delete method
            int expected4 = 2;
            mrm.Delete_Record(2);
            records = mrm.Get_Records();
            Assert.AreEqual(expected4, records.Count());
        }
    }
}
