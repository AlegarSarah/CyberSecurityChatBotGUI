using System;
using System.IO;
using System.Media;

namespace CybersecurityChatbotGUI
{
    class AudioPlayer
    {
        public static void PlayVoiceGreeting()
        {
            try
            {
                string path = "greeting.wav";  //Added voice greeting implementation
                if (File.Exists(path))
                {
                    SoundPlayer player = new SoundPlayer(path);
                    player.Load();
                    player.Play();
                }
            }
            catch
            {
                 
            }
        }
    }
}
