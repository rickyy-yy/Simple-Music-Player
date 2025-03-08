using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Music_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayMusic("moon.wav");
            Console.WriteLine("Music is Playing!");
            Console.ReadLine();
        }

        public static void PlayMusic(string filepath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filepath;
            musicPlayer.Play();
        }
    }
}
