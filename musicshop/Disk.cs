using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace musicshop
{
    public class Disk : IStoreItem
    {
        public string Name { get; set;}
        public string Genre { get; set;}
        public int BurnCount {get; set;}
        public double Priсe { get; set;}
        public virtual int DiskSize {get;}
        public Disk(string name, string genre)
        {
            Name = name;
            Genre = genre;
        }
        public virtual void Burn(params string[] values){}

        public void DiscountPrice(int persent)
        {
            Console.WriteLine(Priсe*(1-(persent)/100));

        }
    }
    public class Audio : Disk
    {
        public string Artist {get; set;}
        public string RecordingStudio {get; set;}
        public int SongsNumber {get; set;}
        public Audio(string name, string genre, string artist, string recordingStudio, int songsNumber) : base(name, genre)
        {
            Artist = artist;
            RecordingStudio = recordingStudio;
            SongsNumber = songsNumber;
        }
        public override int DiskSize { get =>SongsNumber*8;}
        public override void Burn(params string[] values)
        {
            // непонял значение какого поля должен переопределять
            BurnCount++;
        }
        public override string ToString()
        {
            return $"{Name}, {Genre}, {Artist}, {RecordingStudio}, {SongsNumber}, {BurnCount}\n";
        }
    }
    public class DVD : Disk
    {
        public string Producer {get; set;}
        public string FilmCompany {get; set;}
        public int MinutesCount {get; set;}

        public DVD(string name, string genre, string producer, string filmCompany, int minutesCount) : base(name,genre)
        {
            Producer = producer;
            FilmCompany = filmCompany;
            MinutesCount = minutesCount;
        }
        public override int DiskSize { get => (MinutesCount / 64) * 2;}
        public override void Burn(params string[] values)
        {
            BurnCount++;
        }
        public override string ToString()
        {
            return $"{Name}, {Genre}, {Producer}, {FilmCompany}, {MinutesCount}, {BurnCount}\n";
        }
    }
}
