using System;

namespace music_records.Models
{
    public class MusicRecord
    {

        public MusicRecord(int id, string name, string label, int runTime, DateTime releaseDate, int tracks)
        {
            this.Id = id;
            this.Name = name;
            this.Label = label;
            this.RunTime = runTime;
            this.ReleaseDate = releaseDate;
            this.Tracks = tracks;

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public int RunTime { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int Tracks { get; set; }
    }
}