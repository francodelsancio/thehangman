
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
    public class Player
    {
        private readonly WindowsMediaPlayer _player = new WindowsMediaPlayer();

    
        public void PlayMusic(Boolean play)
        {
            this._player.URL = "donkey-kong-country.mp3";

            if (play) _player.controls.play();
            else _player.controls.stop();
      

        }

        public void PlayWoosh(Boolean play)
        {
            this._player.URL = "mario-bros-hammer-throw.mp3";

            if (play) _player.controls.play();

            else _player.controls.stop();


        }


    }
}
