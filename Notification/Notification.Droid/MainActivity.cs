﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Notification.Droid.Services;
using CN.Jpush.Android.Api;

namespace Notification.Droid {

    [Activity(Label = "Notification", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity {
        protected override void OnCreate(Bundle bundle) {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());

            JPushInterface.SetDebugMode(true);
            JPushInterface.Init(this);
        }

        protected override void OnResume() {
            base.OnResume();

            JPushInterface.OnResume(this);
        }

        protected override void OnPause() {
            base.OnPause();

            JPushInterface.OnPause(this);
        }
    }
}

