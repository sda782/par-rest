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
    public class MusicRecordController : ControllerBase
    {
        private readonly MusicRecordManager manager = new MusicRecordManager();

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public IEnumerable<MusicRecord> Get([FromQuery] string name)
        {
            return manager.Get_Records(name);
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpPost]
        public ActionResult<MusicRecord> Add_Record([FromBody] MusicRecord record)
        {
            MusicRecord rec = manager.Add_Record(record);
            if (rec == null) return NotFound("No record :(");
            return Ok(rec);
        }
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpDelete("{id}")]
        public ActionResult Delete_Record(int id)
        {
            if (manager.Get_Record_by_id(id) == null) return NotFound("No record :(");
            manager.Delete_Record(id);
            return Ok();
        }
    }
}