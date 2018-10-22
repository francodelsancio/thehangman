
using System;
using WMPLib;

/*
Universidad Tecnológica Nacional
Facultad Regional Tucuman
Tecnicatura Superior En programación
Laboratorio de Cumputacion I
*/

namespace P3E00
{
    public static class MusicPlayer
    {
        private static readonly WindowsMediaPlayer _player = new WindowsMediaPlayer();
    
        public static void PlayMusic(Boolean play)
        {
            _player.URL = "donkey-kong-country.mp3";

            if (play) _player.controls.play();
            else _player.controls.stop();
      
        }

        public static void PlayWoosh(Boolean play)
        {
            _player.URL = "mario-bros-hammer-throw.mp3";

            if (play) _player.controls.play();
            else _player.controls.stop();

        }


    }
}
