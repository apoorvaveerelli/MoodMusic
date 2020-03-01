using System;
using System.Collections.Generic;
using Android.Media;
using Xamarin.Forms;

namespace Songs
{
    public partial class GreetPage1 : ContentPage
    {
        public GreetPage1()
        {
            InitializeComponent();
        }

        //private void InitializeComponent()
        //{
        //    throw new NotImplementedException();
        //}

        void PlayPop(System.Object sender, System.EventArgs e)
        {
            //string file = "popMusic/wideAwake.mps";
            DependencyService.Get<IAudio>().PlayAudioFile("wideAwake.mp3");
        }

        void PlayRap(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("rapGod.mp3");
        }

        void PlayRB(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("_just_the_way_you_are.mp3");
        }

        void Play2000(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("pokerFace.mp3");
        }

        void Play2010(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("firework.mp3");
        }

        //void PauseSong(System.Object sender, System.EventArgs e)
        //{

        //}

        //void ResumeSong(System.Object sender, System.EventArgs e)
        //{

        //}

        //void StopSong(System.Object sender, System.EventArgs e)
        //{

        //}

        public interface IAudio
        {
            void PlayAudioFile(String fileName);
        }

    }
}
