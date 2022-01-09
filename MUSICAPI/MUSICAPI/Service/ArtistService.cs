using MUSICAPI.Entity;
using MUSICAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MUSICAPI.Service
{
    public class ArtistService
    {
        DB data = new DB();
        public List<AstistObject> getListArtist()
        {
            List<Artist> artist = data.Artists.ToList();
            List<AstistObject> AOBJ = new List<AstistObject>();
            foreach (Artist item in artist)
            {
                AstistObject abjs = new AstistObject();
                abjs.ArtistId = item.ArtistId;
                abjs.ArtistName = item.ArtistName;
                abjs.ArtistImage = item.ArtistImage;
                abjs.ArtistCountry = item.ArtistCountry;
                AOBJ.Add(abjs);

            }
            return AOBJ;
        }
    }
}