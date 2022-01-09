using MUSICAPI.Entity;
using MUSICAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MUSICAPI.Service
{
    public class TrackSongService
    {
        DB data = new DB();
        public List<TrackSongObject> getListTrackSong()
        {
            List<TrackSong> songs = data.TrackSongs.ToList();
            List<TrackSongObject> SOBJ = new List<TrackSongObject>();
            foreach (TrackSong item in songs)
            {
                TrackSongObject objs = new TrackSongObject();
                objs.SongId = item.SongId;
                objs.SongImage = item.SongImage;
                objs.SongName = item.SongName;
                objs.SongLocation = item.SongLocation;
                objs.SongDuration = item.SongDuration;
                objs.SongDate = item.SongDate.Value.ToShortDateString();
                objs.AlbumName = item.AlbumId == null ? "Unknown" : item.Album.AlbumName;
                objs.ArtistName = item.ArtistId == null ? "Unknown" : item.Artist.ArtistName;
                objs.GenreName = item.GenreId== null ? "Unknown" : item.Genre.GenreName;
                SOBJ.Add(objs);

            }
            return SOBJ;
        }
    }
}