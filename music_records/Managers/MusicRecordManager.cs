using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using music_records.Models;

namespace music_records.Managers
{
    public class MusicRecordManager
    {
        private static int nextId = 0;
        private static readonly List<MusicRecord> manager = new List<MusicRecord>(){
            new MusicRecord(nextId++, "record 1", "amazing label", 70, DateTime.Now, 10),
            new MusicRecord(nextId++, "record 2", "shit label", 50, DateTime.Now, 15)
        };

        public IEnumerable<MusicRecord> Get_Records(string name = "")
        {
            IEnumerable<MusicRecord> records = manager;
            if (!string.IsNullOrEmpty(name))
            {
                records = records.Where(i => i.Name == name);
            }
            return records;
        }
    }
}