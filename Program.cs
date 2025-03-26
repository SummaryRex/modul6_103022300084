// See https://aka.ms/new-console-template for more information
using modul6_103022300084;
using System;



class program
{
    static void Main(string[] args)
    {

        SayaTubeUser user1 = new SayaTubeUser("Fathian");
        SayaTubeVideo v1 = new SayaTubeVideo("Cars");
        SayaTubeVideo v2 = new SayaTubeVideo("Toy Story");
        SayaTubeVideo v3 = new SayaTubeVideo("Tangled");
        SayaTubeVideo v4 = new SayaTubeVideo("Mickey Mouse");
        SayaTubeVideo v5 = new SayaTubeVideo("Interstellar");
        SayaTubeVideo v6 = new SayaTubeVideo("2012");
        SayaTubeVideo v7 = new SayaTubeVideo("Asprak adalah maut");
        SayaTubeVideo v8 = new SayaTubeVideo("Pengabdi Mantan");
        SayaTubeVideo v9 = new SayaTubeVideo("Conjuring");
        SayaTubeVideo v10 = new SayaTubeVideo("Ada Apa Dengan Cinta");

        Random rand = new Random();
        v1.IncreasePlayCount(rand.Next(10000, 99999));
        v2.IncreasePlayCount(rand.Next(10000, 99999));
        v3.IncreasePlayCount(rand.Next(10000, 99999));
        v4.IncreasePlayCount(rand.Next(10000, 99999));
        v5.IncreasePlayCount(rand.Next(10000, 99999));
        v6.IncreasePlayCount(rand.Next(10000, 99999));
        v7.IncreasePlayCount(rand.Next(10000, 99999));
        v8.IncreasePlayCount(rand.Next(10000, 99999));
        v9.IncreasePlayCount(rand.Next(10000, 99999));
        v10.IncreasePlayCount(rand.Next(10000, 99999));

        user1.AddVideo(v1);
        user1.AddVideo(v2);
        user1.AddVideo(v3);
        user1.AddVideo(v4);
        user1.AddVideo(v5);
        user1.AddVideo(v6);
        user1.AddVideo(v7);
        user1.AddVideo(v8);
        user1.AddVideo(v9);
        user1.AddVideo(v10);

        Console.WriteLine($"Review Film {v1.Gettitle()} oleh Fathian");
        v1.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine($"Review Film {v2.Gettitle()} oleh Fathian");
        v2.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine($"Review Film {v3.Gettitle()} oleh Fathian");
        v3.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine($"Review Film {v4.Gettitle()} oleh Fathian");
        v4.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine($"Review Film {v5.Gettitle()} oleh Fathian");
        v5.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine($"Review Film {v6.Gettitle()} oleh Fathian");
        v6.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine($"Review Film {v7.Gettitle()} oleh Fathian");
        v7.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine($"Review Film {v8.Gettitle()} oleh Fathian");
        v8.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine($"Review Film {v9.Gettitle()} oleh Fathian");
        v9.PrintVideoDetails();
        Console.WriteLine(" ");
        Console.WriteLine($"Review Film {v10.Gettitle()} oleh Fathian");
        v10.PrintVideoDetails();
        Console.WriteLine(" ");

        Console.WriteLine(" ");
        user1.PrintAllVideoPlaycount();

    }
}