using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe2.OOP.static_class_attribute
{
    internal class Song
    {
        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;

        public Song(String aTitle, string aArtist, int aDuration)
        {
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;
        }

        public int GetSongCount()
        {
            return songCount;
        }
    }
}
