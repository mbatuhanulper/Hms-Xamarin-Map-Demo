package crc640b44d20cc1f5bfaf;


public class MainActivity
	extends android.support.v7.app.AppCompatActivity
	implements
		mono.android.IGCUserPeer,
		com.huawei.hms.maps.OnMapReadyCallback
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"n_onRequestPermissionsResult:(I[Ljava/lang/String;[I)V:GetOnRequestPermissionsResult_IarrayLjava_lang_String_arrayIHandler\n" +
			"n_onMapReady:(Lcom/huawei/hms/maps/HuaweiMap;)V:GetOnMapReady_Lcom_huawei_hms_maps_HuaweiMap_Handler:Com.Huawei.Hms.Maps.IOnMapReadyCallbackInvoker, XHmsMaps-4.0.1.300\n" +
			"";
		mono.android.Runtime.register ("Xamarin_Map_Drawer_Demo.MainActivity, Xamarin-Map-Drawer-Demo", MainActivity.class, __md_methods);
	}


	public MainActivity ()
	{
		super ();
		if (getClass () == MainActivity.class)
			mono.android.TypeManager.Activate ("Xamarin_Map_Drawer_Demo.MainActivity, Xamarin-Map-Drawer-Demo", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);


	public void onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2)
	{
		n_onRequestPermissionsResult (p0, p1, p2);
	}

	private native void n_onRequestPermissionsResult (int p0, java.lang.String[] p1, int[] p2);


	public void onMapReady (com.huawei.hms.maps.HuaweiMap p0)
	{
		n_onMapReady (p0);
	}

	private native void n_onMapReady (com.huawei.hms.maps.HuaweiMap p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
