using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace musicshop
{
    public class Store
    {
        public string StoreName;
        public string Address;
        public List<Audio> audios;
        public List<DVD> videos;

        public Store(string storeName, string address)
        {
            StoreName = storeName;
            Address = address;
            audios  = new List<Audio>();
            videos = new List<DVD>();
        }
        public static Store operator +(Store str, Audio audio)
        {
            str.audios.Add(audio);
            return str;
        }
        public static Store operator +(Store str, DVD video)
        {
            str.videos.Add(video);
            return str;
        }
        public static Store operator -(Store str, Audio audio)
        {
            str.audios.Remove(audio);
            return str;
        }
        public static Store operator -(Store str, DVD video)
        {
            str.videos.Remove(video);
            return str;
        }
        public override string ToString()
        {
            string result = "Песни\n";
            foreach (Audio i in audios)
            {
                result += i.ToString();
            }
            result += "Видео\n";
            foreach (DVD i in videos)
            {
                result += i.ToString();
            }
            return result;
        }
    }
}
