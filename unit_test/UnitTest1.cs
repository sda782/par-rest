using Microsoft.VisualStudio.TestTools.UnitTesting;
using music_records.Managers;
using music_records.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
        }
    }
}
