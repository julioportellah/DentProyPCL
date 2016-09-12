using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DentProyPCL.BusinessLayer
{
    public class DuplaDental
    {
        public int NumeroPiezaDerecha { get; set; }
        public int NumeroPiezaIzquierda { get; set; }
        public string CodigoEnfermedad { get; set; }
        public bool Diastema { get; set; }
        public bool Fusion { get; set; }
        public bool SuperNumerario { get; set; }
        public bool Transposicion { get; set; }
    }
}
