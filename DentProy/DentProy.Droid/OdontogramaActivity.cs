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
        private int tipoUsuario = 1;//1 es adulto,0 es infante
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            // Create your application here
            SetContentView(Resource.Layout.Odontograma);
            var pieza11 = new Pieza(11);
            //Declarando botones de las piezas dentales, no olvidar los dientes de leche    
            DeclararPiezasDentales();
            DeclararBotonesDeControl();
            ConfigurarDentadura(tipoUsuario);
        }
        
        private void ConfigurarDentadura(int idPaciente)
        {
            if (idPaciente == 1)
            {
                var upperTempJaw = (HorizontalScrollView)FindViewById(Resource.Id.upperTempJaw);
                upperTempJaw.Visibility =ViewStates.Gone;
                var underTempJaw = (HorizontalScrollView)FindViewById(Resource.Id.underTempJaw);
                underTempJaw.Visibility = ViewStates.Gone;
            }
            if (idPaciente == 0)
            {
                var upperJaw = (HorizontalScrollView)FindViewById(Resource.Id.upperJaw);
                upperJaw.Visibility = ViewStates.Gone;
                var underJaw = (HorizontalScrollView)FindViewById(Resource.Id.underJaw);
                underJaw.Visibility = ViewStates.Gone;
            }
        }

        public void OnClick(View v)
        {
            Toast toast = Toast.MakeText(this, "You Clicked the button..." + v.Id.ToString(), ToastLength.Short);
            
            switch (v.Id) {
                case Resource.Id.LEY01:
                    toast = Toast.MakeText(this, "Seleccione el diente de inicio y el final..." + v.Id.ToString(), ToastLength.Short);
                    break;
                case Resource.Id.LEY02:
                    toast = Toast.MakeText(this, "Test sin declaracion" + v.Id.ToString(), ToastLength.Short);
                    break;
                case Resource.Id.LEY03:

                    break;
                case Resource.Id.LEY04:

                    break;
                case Resource.Id.LEY05:

                    break;

            }
            toast.Show();
        }
        #region
        private void DeclararBotonesDeControl()
        {
            var btnLEY01 = (Button)FindViewById(Resource.Id.LEY01);
            var btnLEY02 = (Button)FindViewById(Resource.Id.LEY02);
            var btnLEY03 = (Button)FindViewById(Resource.Id.LEY03);
            var btnLEY04 = (Button)FindViewById(Resource.Id.LEY04);
            var btnLEY05 = (Button)FindViewById(Resource.Id.LEY05);
            var btnLEY06 = (Button)FindViewById(Resource.Id.LEY06);
            var btnLEY07 = (Button)FindViewById(Resource.Id.LEY07);
            var btnLEY08 = (Button)FindViewById(Resource.Id.LEY08);
            var btnLEY09 = (Button)FindViewById(Resource.Id.LEY09);
            var btnLEY10 = (Button)FindViewById(Resource.Id.LEY10);
            var btnLEY11 = (Button)FindViewById(Resource.Id.LEY11);
            var btnLEY12 = (Button)FindViewById(Resource.Id.LEY12);
            btnLEY01.SetOnClickListener(this);
            btnLEY02.SetOnClickListener(this);
            btnLEY03.SetOnClickListener(this);
            btnLEY04.SetOnClickListener(this);
            btnLEY05.SetOnClickListener(this);
            btnLEY06.SetOnClickListener(this);
            btnLEY07.SetOnClickListener(this);
            btnLEY08.SetOnClickListener(this);
            btnLEY09.SetOnClickListener(this);
            btnLEY10.SetOnClickListener(this);
            btnLEY11.SetOnClickListener(this);
            btnLEY12.SetOnClickListener(this);
        }
        private void DeclararPiezasDentales()
        {
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
            //Declarando botones de los espacios dentales
            var btnEspacio1817 = (Button)FindViewById(Resource.Id.espacio1817);
            var btnEspacio1716 = (Button)FindViewById(Resource.Id.espacio1716);
            var btnEspacio1615 = (Button)FindViewById(Resource.Id.espacio1615);
            var btnEspacio1514 = (Button)FindViewById(Resource.Id.espacio1514);
            var btnEspacio1413 = (Button)FindViewById(Resource.Id.espacio1413);
            var btnEspacio1312 = (Button)FindViewById(Resource.Id.espacio1312);
            var btnEspacio1211 = (Button)FindViewById(Resource.Id.espacio1211);
            var btnEspacio1121 = (Button)FindViewById(Resource.Id.espacio1121);
            var btnEspacio2122 = (Button)FindViewById(Resource.Id.espacio2122);
            var btnEspacio2223 = (Button)FindViewById(Resource.Id.espacio2223);
            var btnEspacio2324 = (Button)FindViewById(Resource.Id.espacio2324);
            var btnEspacio2425 = (Button)FindViewById(Resource.Id.espacio2425);
            var btnEspacio2526 = (Button)FindViewById(Resource.Id.espacio2526);
            var btnEspacio2627 = (Button)FindViewById(Resource.Id.espacio2627);
            var btnEspacio2728 = (Button)FindViewById(Resource.Id.espacio2728);
            var btnEspacio3837 = (Button)FindViewById(Resource.Id.espacio3738);
            var btnEspacio3736 = (Button)FindViewById(Resource.Id.espacio3637);
            var btnEspacio3635 = (Button)FindViewById(Resource.Id.espacio3536);
            var btnEspacio3534 = (Button)FindViewById(Resource.Id.espacio3435);
            var btnEspacio3433 = (Button)FindViewById(Resource.Id.espacio3334);
            var btnEspacio3332 = (Button)FindViewById(Resource.Id.espacio3233);
            var btnEspacio3231 = (Button)FindViewById(Resource.Id.espacio3132);
            var btnEspacio3141 = (Button)FindViewById(Resource.Id.espacio4131);
            var btnEspacio4142 = (Button)FindViewById(Resource.Id.espacio4241);
            var btnEspacio4243 = (Button)FindViewById(Resource.Id.espacio4342);
            var btnEspacio4344 = (Button)FindViewById(Resource.Id.espacio4443);
            var btnEspacio4445 = (Button)FindViewById(Resource.Id.espacio4544);
            var btnEspacio4546 = (Button)FindViewById(Resource.Id.espacio4645);
            var btnEspacio4647 = (Button)FindViewById(Resource.Id.espacio4746);
            var btnEspacio4748 = (Button)FindViewById(Resource.Id.espacio4847);


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
            btnEspacio1817.SetOnClickListener(this);
            btnEspacio1716.SetOnClickListener(this);
            btnEspacio1615.SetOnClickListener(this);
            btnEspacio1514.SetOnClickListener(this);
            btnEspacio1413.SetOnClickListener(this);
            btnEspacio1312.SetOnClickListener(this);
            btnEspacio1211.SetOnClickListener(this);
            btnEspacio1121.SetOnClickListener(this);
            btnEspacio2122.SetOnClickListener(this);
            btnEspacio2223.SetOnClickListener(this);
            btnEspacio2324.SetOnClickListener(this);
            btnEspacio2425.SetOnClickListener(this);
            btnEspacio2526.SetOnClickListener(this);
            btnEspacio2627.SetOnClickListener(this);
            btnEspacio2728.SetOnClickListener(this);
            btnEspacio3837.SetOnClickListener(this);
            btnEspacio3736.SetOnClickListener(this);
            btnEspacio3635.SetOnClickListener(this);
            btnEspacio3534.SetOnClickListener(this);
            btnEspacio3433.SetOnClickListener(this);
            btnEspacio3332.SetOnClickListener(this);
            btnEspacio3231.SetOnClickListener(this);
            btnEspacio3141.SetOnClickListener(this);
            btnEspacio4142.SetOnClickListener(this);
            btnEspacio4243.SetOnClickListener(this);
            btnEspacio4344.SetOnClickListener(this);
            btnEspacio4445.SetOnClickListener(this);
            btnEspacio4546.SetOnClickListener(this);
            btnEspacio4647.SetOnClickListener(this);
            btnEspacio4748.SetOnClickListener(this);

        }
        #endregion
    }
}