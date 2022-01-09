using MUSICAPI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace MUSICAPI.Controllers
{
    public class TrackSongAPIController : ApiController
    {
        TrackSongService sv = new TrackSongService();
        [HttpGet]
        public async Task<IHttpActionResult> getSongList()
        {        
            return Ok(new { status = true, data = sv.getListTrackSong() });
        }
    }
}
