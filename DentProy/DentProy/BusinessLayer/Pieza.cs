using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentProyPCL.BusinessLayer
{
    public class Pieza:Diente
    {
        public int Numero { get; set; }

        public string AparatoOrtodontico { get; set; }

        public List<SuperficieDental> SuperificieDental { get; set; }

        public string Corona { get; set; }

        public bool DesgasteOclusal { get; set; }

        public bool Ausente { get; set; }

        public List<DuplaDental> DuplaDental { get; set; }

        public bool Discromico { get; set; }

        public bool Ectopico { get; set; }

        public bool Clavija { get; set; }

        public string Desviacion { get; set; }

        public string Edentulo { get; set; } //Puede afectar a la mand superior o inf
        //Codigo de mandibula 'sup', 'inf', 'tod'
        public bool Fractura { get; set; }
        //obj geminacion

        public bool Giroversion { get; set; }

        public bool Impactacion { get; set; }

        public bool Implante { get; set; }

        public bool Macrodoncia { get; set; }

        public bool Migracion { get; set;}

        public int Movilidad { get; set; }

        public string Protesis { get; set; }

        public bool RemanenteRadicular { get; set; }

        public bool SemiImpactacion { get; set; }
        
        public bool TratamientoPulpar { get; set; }

    }
}
