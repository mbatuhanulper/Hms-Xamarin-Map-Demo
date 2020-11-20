using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Com.Huawei.Hms.Maps;
using Android;
using Com.Huawei.Hms.Maps.Internal;
using IOnMapReadyCallback = Com.Huawei.Hms.Maps.IOnMapReadyCallback;
using Android.Support.V4.App;
using Android.Content;
using System;
using Android.Content.PM;
using Com.Huawei.Agconnect.Config;
using Android.Support.V4.Content;
using Com.Huawei.Hms.Maps.Model;
using Android.Graphics;
using Com.Huawei.Hms.Maps.Util;
using Com.Huawei.Secure.Android.Common.Ssl;

namespace Xamarin_Map_Drawer_Demo
{
    [Activity(Label = "Map", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, IOnMapReadyCallback
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

    

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        public void OnMapReady(HuaweiMap map)
        {
            hMap = map;
            hMap.UiSettings.MyLocationButtonEnabled = true;
            hMap.MyLocationEnabled = true;

            addMarker(new LatLng(41.03472222, 28.90027778), "Home", "Home Sweet Home");
         
            Marker marker1;
            MarkerOptions marker1Options = new MarkerOptions()
                            .InvokePosition(new LatLng(40.985996056, 29.035333192))
                            .InvokeTitle("Stadium")
                            .InvokeSnippet("Fenerbahce Stadium");
            marker1 = hMap.AddMarker(marker1Options);

            hMap.SetInfoWindowAdapter(new CustomMapInfoWindow(this));

            //drawPolygone();
            //drawPolyline();
            //drawCircle();
            
            
        }

        private void addMarker(LatLng position, String title, String description)
        {
            Marker marker;
            MarkerOptions marker3Options = new MarkerOptions()
            .InvokePosition(position)
            .InvokeTitle(title)
            .InvokeSnippet(description);

            Bitmap bitmap1 = ResourceBitmapDescriptor.DrawableToBitmap(this, ContextCompat.GetDrawable(this, Resource.Drawable.markerblue));
            marker3Options.InvokeIcon(BitmapDescriptorFactory.FromBitmap(bitmap1));
            marker = hMap.AddMarker(marker3Options);
            hMap.MarkerDragStart += OnMarkerDragStart;
            hMap.MarkerDrag += OnMarkerDrag;
            hMap.MarkerDragEnd += OnMarkerDragEnd;

        }

        private void drawPolyline()
        {
            Polyline polyline2;
            PolylineOptions polyline2Options = new PolylineOptions()
                        .Add(new LatLng(41.03472222, 28.90027778), new LatLng(41.00166667, 28.97111111), new LatLng(41.00415, 29.012449), new LatLng(40.985996056, 29.035333192));
            polyline2Options.InvokeColor(Color.Red);
            polyline2Options.Clickable(true);
            polyline2 = hMap.AddPolyline(polyline2Options);
        }

        private void drawPolygone()
        {
            Polygon polygon1;
            PolygonOptions polygon1Options = new PolygonOptions()
                        .Add(new LatLng(41.01929, 28.967267), new LatLng(41.016785, 28.986971), new LatLng(41.014623, 28.999753), new LatLng(41.001917, 28.978743), new LatLng(41.002298, 28.954132));
            polygon1Options.InvokeFillColor(Color.Argb(60, 255, 200, 0));
            polygon1Options.InvokeStrokeColor(Color.Green);
            polygon1Options.InvokeStrokeWidth(30);
            polygon1Options.Clickable(true);
            polygon1Options.InvokeZIndex(2);
            polygon1 = hMap.AddPolygon(polygon1Options);

        }

        private void drawCircle()
        {
            Circle circle;
            LatLng circleLatLng = new LatLng(40.985996056, 29.035333192);
            CircleOptions circleOptions = new CircleOptions();
            circle = hMap.AddCircle(circleOptions);
            circleOptions.InvokeCenter(circleLatLng);
            circleOptions.InvokeRadius(1800);
            circleOptions.InvokeStrokeWidth(5);
            circleOptions.InvokeStrokeColor(Color.Blue);
            circleOptions.InvokeStrokeWidth(30);
            circleOptions.Clickable(true);
            circleOptions.InvokeZIndex(2);
            circle = hMap.AddCircle(circleOptions);
            circleOptions.Clickable(true);
            hMap.CircleClick += OnCircleClick;
        }

        public void OnCircleClick(object sender, HuaweiMap.CircleClickEventArgs e)
        {
            Toast.MakeText(this, $"Istanbul is blue!", ToastLength.Short).Show();
        }

        public void OnPolylineClick(object sender, HuaweiMap.PolylineClickEventArgs e)
        {
            Toast.MakeText(this, $"Route 1", ToastLength.Short).Show();
        }


        public void OnPolygonClick(object sender, HuaweiMap.PolygonClickEventArgs e)
        {
            Toast.MakeText(this, $"Historical Peninsula", ToastLength.Short).Show();
        }

        public void OnMarkerClick(object sender, HuaweiMap.MarkerClickEventArgs e)
        {
            Toast.MakeText(this, $"Marker Click Marker ID: {e.P0.Id}", ToastLength.Short).Show();
        }

        public void OnMarkerDragStart(object sender, HuaweiMap.MarkerDragStartEventArgs e)
        {
            Toast.MakeText(this, $"Drag Start Marker ID: {e.P0.Id}", ToastLength.Short).Show();
        }

        public void OnMarkerDrag(object sender, HuaweiMap.MarkerDragEventArgs e)
        {
            Toast.MakeText(this, $"Dragging Marker ID: {e.P0.Id}", ToastLength.Short).Show();
        }

        public void OnMarkerDragEnd(object sender, HuaweiMap.MarkerDragEndEventArgs e)
        {
            Toast.MakeText(this, $"Drag End Marker ID: {e.P0.Id}", ToastLength.Short).Show();
        }

    }
}