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
        public void addaudio (Audio audio)
        {
            audios.Add(audio);
        }
        public void addvideo (DVD video)
        {
            videos.Add(video);
        }
        public void delaudio (Audio audio)
        {
            audios.Remove(audio);
        }
        public void delaudio (DVD video)
        {
            videos.Remove(video);
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
