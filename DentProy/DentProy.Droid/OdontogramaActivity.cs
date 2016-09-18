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
using DentProy.BusinessLayer;

namespace DentProy.Droid
{
    [Activity(Label = "OdontogramaActivity")]
    public class OdontogramaActivity : Activity, View.IOnClickListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Odontograma);
            var pieza11 = new Pieza(11);
            //Declarando botones de la parte superior    
            var btnPieza11 = (Button)FindViewById(Resource.Id.pieza11);
            var btnPieza12 = (Button)FindViewById(Resource.Id.pieza12);
            var btnPieza13 = (Button)FindViewById(Resource.Id.pieza13);
            var btnPieza14 = (Button)FindViewById(Resource.Id.pieza14);
            var btnPieza15 = (Button)FindViewById(Resource.Id.pieza15);
            var btnPieza16 = (Button)FindViewById(Resource.Id.pieza16);
            var btnPieza17 = (Button)FindViewById(Resource.Id.pieza17);
            var btnPieza18 = (Button)FindViewById(Resource.Id.pieza18);
            var btnPieza21 = (Button)FindViewById(Resource.Id.pieza21);
            var btnPieza22 = (Button)FindViewById(Resource.Id.pieza22);
            var btnPieza23 = (Button)FindViewById(Resource.Id.pieza23);
            var btnPieza24 = (Button)FindViewById(Resource.Id.pieza24);
            var btnPieza25 = (Button)FindViewById(Resource.Id.pieza25);
            var btnPieza26 = (Button)FindViewById(Resource.Id.pieza26);
            var btnPieza27 = (Button)FindViewById(Resource.Id.pieza27);
            var btnPieza28 = (Button)FindViewById(Resource.Id.pieza28);
            var btnPieza31 = (Button)FindViewById(Resource.Id.pieza31);
            var btnPieza32 = (Button)FindViewById(Resource.Id.pieza32);
            var btnPieza33 = (Button)FindViewById(Resource.Id.pieza33);
            var btnPieza34 = (Button)FindViewById(Resource.Id.pieza34);
            var btnPieza35 = (Button)FindViewById(Resource.Id.pieza35);
            var btnPieza36 = (Button)FindViewById(Resource.Id.pieza36);
            var btnPieza37 = (Button)FindViewById(Resource.Id.pieza37);
            var btnPieza38 = (Button)FindViewById(Resource.Id.pieza38);
            var btnPieza41 = (Button)FindViewById(Resource.Id.pieza41);
            var btnPieza42 = (Button)FindViewById(Resource.Id.pieza42);
            var btnPieza43 = (Button)FindViewById(Resource.Id.pieza43);
            var btnPieza44 = (Button)FindViewById(Resource.Id.pieza44);
            var btnPieza45 = (Button)FindViewById(Resource.Id.pieza45);
            var btnPieza46 = (Button)FindViewById(Resource.Id.pieza46);
            var btnPieza47 = (Button)FindViewById(Resource.Id.pieza47);
            var btnPieza48 = (Button)FindViewById(Resource.Id.pieza48);

            btnPieza11.SetOnClickListener(this);
            btnPieza12.SetOnClickListener(this);
            btnPieza13.SetOnClickListener(this);
            btnPieza14.SetOnClickListener(this);
            btnPieza15.SetOnClickListener(this);
            btnPieza16.SetOnClickListener(this);
            btnPieza17.SetOnClickListener(this);
            btnPieza18.SetOnClickListener(this);
            btnPieza21.SetOnClickListener(this);
            btnPieza22.SetOnClickListener(this);
            btnPieza23.SetOnClickListener(this);
            btnPieza24.SetOnClickListener(this);
            btnPieza25.SetOnClickListener(this);
            btnPieza26.SetOnClickListener(this);
            btnPieza27.SetOnClickListener(this);
            btnPieza28.SetOnClickListener(this);
            btnPieza31.SetOnClickListener(this);
            btnPieza32.SetOnClickListener(this);
            btnPieza33.SetOnClickListener(this);
            btnPieza34.SetOnClickListener(this);
            btnPieza35.SetOnClickListener(this);
            btnPieza36.SetOnClickListener(this);
            btnPieza37.SetOnClickListener(this);
            btnPieza38.SetOnClickListener(this);
            btnPieza41.SetOnClickListener(this);
            btnPieza42.SetOnClickListener(this);
            btnPieza43.SetOnClickListener(this);
            btnPieza44.SetOnClickListener(this);
            btnPieza45.SetOnClickListener(this);
            btnPieza46.SetOnClickListener(this);
            btnPieza47.SetOnClickListener(this);
            btnPieza48.SetOnClickListener(this);
        }
        

        public void OnClick(View v)
        {
            Toast toast = Toast.MakeText(this, "You Clicked the button..." + v.Id.ToString(), ToastLength.Short);
            switch (v.Id) {

            }
        }
    }
}