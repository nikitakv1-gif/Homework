using System;

namespace musicshop
{
    class main
    {
        public static void Main( string[] args)
        {
            Store mylib = new Store("My Lib", "Во Рту МИРЭА");
            Audio audio1 = new Audio("1Name", "1Genre", "1Song", "1Studio", 10);
            Audio audio2 = new Audio("2Name", "2Genre", "2Song", "2Studio", 6);

            DVD video1 = new DVD("1Name", "1Genre", "1producer", "1FilmCompany", 160);
            DVD video2 = new DVD("2Name", "2Genre", "2producer", "2FilmCompany", 170);

            mylib.addaudio(audio1);
            mylib.addaudio(audio2);
            mylib.addvideo(video1);
            mylib.addvideo(video2);

            Console.WriteLine(mylib.ToString());

            audio1.Burn("3Name", "3Genre", "3Song", "3Studio", "12");

            Console.WriteLine(audio1.Name + " " +  audio1.DiskSize);
            Console.WriteLine(audio2.Name + " " +  audio2.DiskSize);
            Console.WriteLine(video1.Name + " " + video1.DiskSize);
            Console.WriteLine(video2.Name + " " + video2.DiskSize);
        }
    }
}
