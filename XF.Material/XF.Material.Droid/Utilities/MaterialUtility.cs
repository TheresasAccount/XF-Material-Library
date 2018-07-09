﻿using Android.App;
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XF.Material.Droid.Utilities;
using XF.Material.Utilities;

[assembly: Dependency(typeof(MaterialUtility))]
namespace XF.Material.Droid.Utilities
{
    public class MaterialUtility : IMaterialUtility
    {
        public void ChangeStatusBarColor(Color color)
        {
            var activity = (FormsAppCompatActivity)Material.Context;
            activity.SetStatusBarColor(color.ToAndroid());
        }
    }
}