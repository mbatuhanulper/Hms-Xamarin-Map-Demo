using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using System;
using System.IO;
using Android.Content;
using Com.Huawei.Agconnect.Config;

namespace Xamarin_Map_Drawer_Demo
{
    class HmsLazyInputStream : LazyInputStream
    {
        public HmsLazyInputStream(Context context) : base(context)
        {
        }

        public override Stream Get(Context context)
        {

            try
            {
                return context.Assets.Open("agconnect-services.json");
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}