using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DentProyPCL.BusinessLayer
{
    public class Usuario:Persona
    {
        public int Pin { get; set; }

        public int NumeroCOP { get; set; }

        public int NumeroANR { get; set; }
    }
}
