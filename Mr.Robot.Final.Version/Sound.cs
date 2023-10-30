using System;
using System.Collections.Generic;
using System.Text;


namespace Mr.Robot.Final.Version
{
    class Sound
    {
        private System.Media.SoundPlayer myPlayer;

        public Sound()
        {
            myPlayer = new System.Media.SoundPlayer();
        }
        public void PlayBackGroundMusic(string directory)
        {
            myPlayer.SoundLocation = directory;
            myPlayer.Play();
        }
        public void StopMusic()
        {
            myPlayer.Stop();
        }
    }
}
