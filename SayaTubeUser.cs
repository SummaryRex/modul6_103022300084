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
            
            this.Username = Username;
            this.id = rand.Next(10000, 99999);
            this.uploadedVideos = new List<SayaTubeVideo>();
            Debug.Assert(this.uploadedVideos.Count == 0, "List video harus kosong saat inisialisasi");
            Debug.Assert(Username != null, "Username tidak boleh kosong!");
            Debug.Assert(Username.Length <= 100, "Username maksimal 100 karakter!");
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (var video in uploadedVideos)
            {
                Debug.Assert(video != null, "Video di list tidak boleh null");
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
            if (video.PlayCount >= int.MaxValue)
            {
                throw new ArgumentException("Video play count sudah maksimum");
            }
            this.uploadedVideos.Add(video);

            Debug.Assert(uploadedVideos.Contains(video), "Video harus dalam list setelah ditambahkan");
        }
        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User: " + this.Username);
            int count = Math.Min(uploadedVideos.Count, 8);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].Title}");
            }
            Debug.Assert(count <= 8, "Jumlah video maksimal yang di-print adalah 8");
        }
        public List<SayaTubeVideo> UploadedVideos => uploadedVideos;
    }
}
