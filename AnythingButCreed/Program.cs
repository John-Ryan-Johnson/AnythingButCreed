using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var creed1 = new Song("Creed", "Arms Wide Open");
            var creed2 = new Song("Creed", "Higher");
            var creed3 = new Song("Creed", "One Last Breath");
            var ACDC1 = new Song("ACDC", "Back In Black");
            var ACDC2 = new Song("ACDC", "Hell's Bell's");
            var ACDC3 = new Song("ACDC", "For Those About To Rock");
            var METALLICA1 = new Song("Metallica", "Fade To Black");
            var METALLICA2 = new Song("Metallica", "Wherever I May Roam");
            var METALLICA3 = new Song("Metallica", "The Memory Remains");
            var MOTLEYCRUE1 = new Song("Motley Crue", "Girls, Girls, Girls");
            var MOTLEYCRUE2 = new Song("Motley Crue", "Wildside");
            var MOTLEYCRUE3 = new Song("Motley Crue", "Kickstart My Heart");

            var goodSongs = new List<Song>();

            var allSongs = new List<Song>()
            {
                creed1,
                creed2,
                creed3,
                ACDC1,
                ACDC2,
                ACDC3,
                METALLICA1,
                METALLICA2,
                METALLICA3,
                MOTLEYCRUE1,
                MOTLEYCRUE2,
                MOTLEYCRUE3
            };

            goodSongs = allSongs.Where(Song => Song.Artist != "Creed").ToList();

            foreach (var song in goodSongs)
            {
                Console.WriteLine($"{song.Artist} : {song.Name}");
            }
        }
    }
}
