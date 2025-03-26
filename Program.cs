using modul6_103022300084;
class Program
{
    static void Main(string[] args)
    {
        string namaPraktikan = "Fathian";
        var user = new SayaTubeUser(namaPraktikan);
        string[] judulFilm =
        {
            "Cars", "Toy Story", "Moana", "Tangled", "Mickey Mouse", "Your Name",
            "Ipar adalah maut", "Pengabdi mantan", "Interstellar", "2012" 
        };
        Random rand = new Random();
        foreach (string film in judulFilm)
        {
            string videoTitle = $"Review Film {judulFilm} oleh {namaPraktikan}";
            var video = new SayaTubeVideo(videoTitle);
            video.IncreasePlayCount(rand.Next(10000, 99999));
            user.AddVideo(video);
        }
        user.PrintAllVideoPlaycount();
        Console.WriteLine()
    }
}