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
using static Songs.iOS.AppDelegate;
using static Songs.iOS.Application;

[assembly: Dependency(typeof(AUdioService))]

namespace Songs.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        //public class AUdioService : IAudio
        //{
        //    public AUdioService() { }
        //    public void PlayAudioFile(string fileName)
        //    {
        //        string sFilePath = NSBundle.MainBundle.PathForResource(Path.GetFileNameWithoutExtension(fileName), Path.GetExtension(fileName));
        //        var url = NSUrl.FromString(sFilePath);
        //        var _player = AVAudioPlayer.FromUrl(url);
        //        _player.FinishedPlaying += (object sender, AVStatusEventArgs e) =>
        //        {
        //            _player = null;
        //        };
        //        _player.Play();
        //    }
        }
    }
