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
        }
    }
}
