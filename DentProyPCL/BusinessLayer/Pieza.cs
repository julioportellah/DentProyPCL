using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentProyPCL.BusinessLayer
{
    public class Pieza:Diente
    {
        public Pieza(int numero) {
            this.Numero = numero;
            List<int> piezas5 = new List<int>(new[] {16,17,26,27,37,47,54,55,64,65,74,75,84,85});
            List<int> piezas6 = new List<int>(new[] {14,15,24,25,34,35,44,45,46,36 });
            List<int> piezas7 = new List<int>(new[] { 18,28,38,48});

            //Llenando superficies dentales
            if (numero % 10 <= 3)//Superficies de 4
            {
                this.SuperificieDental = new List<SuperficieDental>();
                SuperificieDental.Add(new SuperficieDental() { Numero = 1, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 2, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 3, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 4, Caries = false, Restauracion = "NON" });
            }
            else if (piezas5.Contains(numero))//Superficies de 5
            {
                this.SuperificieDental = new List<SuperficieDental>();
                SuperificieDental.Add(new SuperficieDental() { Numero = 1, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 2, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 3, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 4, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 5, Caries = false, Restauracion = "NON" });
            }
            else if (piezas6.Contains(numero))//Superficies de 6
            {
                this.SuperificieDental = new List<SuperficieDental>();
                SuperificieDental.Add(new SuperficieDental() { Numero = 1, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 2, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 3, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 4, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 5, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 6, Caries = false, Restauracion = "NON" });
            }
            else if (piezas7.Contains(numero))//Superficies de 7
            {
                this.SuperificieDental = new List<SuperficieDental>();
                SuperificieDental.Add(new SuperficieDental() { Numero = 1, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 2, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 3, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 4, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 5, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 6, Caries = false, Restauracion = "NON" });
                SuperificieDental.Add(new SuperficieDental() { Numero = 7, Caries = false, Restauracion = "NON" });
            }
            List<int> raices1 = new List<int>(new[] { 11,12,13,15,21,22,23,25,31,32,33,34,35,41,42,43,44,45,51,52,53,61,62,63,71,72,73 });
            List<int> raices2 = new List<int>(new[] { 14, 24,46,47,48,36,37,38,64,65,74,75 });
            List<int> raices3 = new List<int>(new[] {16,17,18,26,27,28,54,55,64,65});
            if (raices1.Contains(numero))
            {
                this.RaizDental = new List<RaizDental>();
                this.RaizDental.Add(new RaizDental() { Numero=1,Caries=false,TratamientoPulpar="NON"});
            }
            if (raices2.Contains(numero))
            {
                this.RaizDental = new List<RaizDental>();
                this.RaizDental.Add(new RaizDental() { Numero = 1, Caries = false, TratamientoPulpar = "NON" });
                this.RaizDental.Add(new RaizDental() { Numero = 2, Caries = false, TratamientoPulpar = "NON" });
            }
            if (raices3.Contains(numero))
            {
                this.RaizDental = new List<RaizDental>();
                this.RaizDental.Add(new RaizDental() { Numero = 1, Caries = false, TratamientoPulpar = "NON" });
                this.RaizDental.Add(new RaizDental() { Numero = 2, Caries = false, TratamientoPulpar = "NON" });
                this.RaizDental.Add(new RaizDental() { Numero = 3, Caries = false, TratamientoPulpar = "NON" });
            }
            this.AparatoOrtodontico = "NON";
            this.Corona = "NON";
            this.DesgasteOclusal = true;
            this.Ausente = false;
            this.Discromico = false;
            this.Ectopico = false;
            this.Clavija = false;
            this.Desviacion = "NON";
            this.Giroversion = "NON";
            this.Impactacion = "NON";
            this.Macrodoncia = false;
            this.Microdoncia = false;
            this.Migracion = "NON";
            this.Movilidad = 0;
            this.Protesis = "NON";
            this.RemanenteRadicular = false;
            this.Fractura.Existe = false;
        }

        public int Numero { get; set; }

        public string AparatoOrtodontico { get; set; } //IDS: NON, FIJ, REM

        public List<SuperficieDental> SuperificieDental { get; set; }

        public List<RaizDental> RaizDental { get; set; }

        public string Corona { get; set; }//ids: NON, CC,CF,CMC,3/4,4/5,7/8,CV,CJ

        public bool DesgasteOclusal { get; set; }//x

        public bool Ausente { get; set; }//x

        public List<DuplaDental> DuplaDental { get; set; }//falta

        public bool Discromico { get; set; }//x

        public bool Ectopico { get; set; }//x

        public bool Clavija { get; set; }//X

        //Debe haber un objeto que abarque las raices
        public string Desviacion { get; set; }//ids: NON, EXT,INT

        public bool Edentulo { get; set; }

        public FracturaDental Fractura { get; set; }//Debe ser convertido a una lista objeto
        //obj geminacion

        public string Giroversion { get; set; }//ids: NON,DER,IZQ

        public string Impactacion { get; set; }//NON,TOT,SEM

        public bool Implante { get; set; }//x

        public bool Macrodoncia { get; set; }//x

        public bool Microdoncia { get; set; }//x

        public string Migracion { get; set; }//NON,DER,IZQ

        public int Movilidad { get; set; }//0,1,2,3

        public string Protesis { get; set; }//NON,FIJ,REM,TOT

        public bool RemanenteRadicular { get; set; }//x

        public bool SemiImpactacion { get; set; }//x

    }
}
