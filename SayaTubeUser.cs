using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300084
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;
        Random rand = new Random();

        public SayaTubeUser(string Username)
        {
            Debug.Assert(Username != null && Username != "", "Username tidak boleh kosong!");
            Debug.Assert(Username.Length <= 100, "Username maksimal 100 karakter!");
            this.Username = Username;
            this.id = rand.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            Debug.Assert(this.uploadedVideos.Count == 0, "List video harus kosong saat inisialisasi");
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                total += video.PlayCount;
            }
            return total;
        }
        public void AddVideo(SayaTubeVideo video)
        {
            if (video == null)
            {
                throw new ArgumentNullException("Video tidak boleh kosong!");
            }
            this.uploadedVideos.Add(video);
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + this.Username);
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].Title}");
            }
        }
        public List<SayaTubeVideo> UploadedVideos => uploadedVideos;
    }
}
