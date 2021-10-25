using System.Collections;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using music_records.Managers;
using music_records.Models;

namespace music_records.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class MusicRecordController
    {
        private readonly MusicRecordManager manager = new MusicRecordManager();

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public IEnumerable<MusicRecord> Get()
        {
            return manager.Get_Records();
        }
    }
}