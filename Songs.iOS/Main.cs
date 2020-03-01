using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using AudioToolbox;
using Foundation;
using AVFoundation;
using Xamarin.Forms;
using UIKit;
using static Songs.GreetPage1;
using static Songs.iOS.Application;

[assembly: Dependency(typeof(AUdioService))]
namespace Songs.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        { 
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            UIApplication.Main(args, "AppDelegate", "AppDelegate");}
        public class AUdioService : IAudio
        {
            public AUdioService() { }
            public void PlayAudioFile(string fileName)
            {
                string sFilePath = NSBundle.MainBundle.PathForResource(Path.GetFileNameWithoutExtension(fileName), Path.GetExtension(fileName));
                var url = NSUrl.FromString(sFilePath);
                var _player = AVAudioPlayer.FromUrl(url);
                _player.FinishedPlaying += (object sender, AVStatusEventArgs e) =>
                {
                    _player = null;
                };
                _player.Play();
            }
        }
    }
}
