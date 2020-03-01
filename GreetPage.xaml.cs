using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Songs
{
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();
        }

        void PlayPop(System.Object sender, System.EventArgs e)
        {
            string file = "popMusic/wideAwake.mps";
            DependencyService.Get<IAudio>().PlayAudioFile(file);
        }

        void PlayRap(System.Object sender, System.EventArgs e) {
            DependencyService.Get<IAudio>().PlayAudioFile("Rap/rapGod.mp3");
        }

        void PlayRB(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("rythm/_just_the_way_you_are.mp3");
        }

        void Play2000(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("2000s/pokerFace.mp3");
        }

        void Play2010(System.Object sender, System.EventArgs e)
        {
            DependencyService.Get<IAudio>().PlayAudioFile("2010/firework.mp3");
        }

        public interface IAudio
        {
            void PlayAudioFile(String fileName);
        }

    }
}
