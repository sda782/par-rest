using System;
using System.Collections;
using System.Collections.Generic;
using music_records.Models;

namespace music_records.Managers
{
    public class MusicRecordManager
    {

        private static readonly List<MusicRecord> manager = new List<MusicRecord>(){
            new MusicRecord(1, "record 1", "amazing label", 70, DateTime.Now, 10)
        };

        public IEnumerable<MusicRecord> Get_Records()
        {
            return manager;
        }
    }
}