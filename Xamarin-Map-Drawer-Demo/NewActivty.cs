using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Com.Huawei.Hms.Maps;

namespace Xamarin_Map_Drawer_Demo
{

   /* class NewActivty : AppCompatActivity, IOnMapReadyCallback
    {
        private MapView mMapView;
        private HuaweiMap hMap;
        private MapFragment mapFragment;



        string[] permissions = {
                Android.Manifest.Permission.AccessCoarseLocation,
                Android.Manifest.Permission.AccessFineLocation,
                Android.Manifest.Permission.Internet };

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            mapFragment = FragmentManager.FindFragmentById<MapFragment>(Resource.Id.mapfragment_mapfragmentdemo);
            mapFragment.GetMapAsync(this);
            ActivityCompat.RequestPermissions(this, permissions, 100);

        }
        public void OnMapReady(HuaweiMap huaweiMap)
        {
            this.hMap = huaweiMap;
            hMap.UiSettings.MyLocationButtonEnabled = true;
            hMap.MyLocationEnabled = true;
        }

        private void addMarker()
        {
            Marker marker1;
            MarkerOptions marker1Options = new MarkerOptions()
                            .InvokePosition(new LatLng(41.0083, 28.9784))
                            .InvokeTitle("Marker Title #1")
                            .InvokeSnippet("Marker Desc #1");
            marker1 = hMap.AddMarker(marker1Options);
        }
    }*/
}