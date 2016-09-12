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
    public class OdontogramaActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Odontograma);
            var pieza11 = new Pieza(11);
        }
    }
}