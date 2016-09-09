using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace DentProy.Droid
{
	[Activity (Label = "DentProy.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button> (Resource.Id.myButton);
            
            var pieza1 = new DentProyPCL.BusinessLayer.Pieza(11) { };
            Toast toast = Toast.MakeText(this, "This is a test..."+pieza1.Impactacion, ToastLength.Short);

            button.Click += delegate {
				button.Text = string.Format ("{0} clicks!", count++);
                toast.Show();
			};
            //Definiendo superficies dentales
            //var pieza11 = new DentProyPCL.BusinessLayer.Pieza() {
            //    Numero = 11,
            //    AparatoOrtodontico="NON",

            //};
        }
	}
}


