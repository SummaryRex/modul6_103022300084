using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300084
{
    class SayaTubeVideo
    {
        private int id, playCount;
        private string title;
        Random rand = new Random();

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title != null && title != "", "Judul video tidak boleh kosong!");
            Debug.Assert(title.Length <= 200, "Judul video maksimal 200 karakter!");
            this.id = rand.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }
        public void IncreasePlayCount(int playCount)
        {
            Debug.Assert(playCount <= 25000000, "penambahan play count maksimal 25.000.000");
            try
            {
                checked
                {
                    this.playCount += playCount;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine($"Terjadi error overflow! {e.Message}");
                this.playCount = int.MaxValue;
            }
            System.Diagnostics.Debug.Assert(this.playCount >= 0, "Play Count tidak boleh negatif");
        }
        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("Play Count: " + this.playCount);
        }

        public int PlayCount => playCount;
        public string Title => title;
    }
}
