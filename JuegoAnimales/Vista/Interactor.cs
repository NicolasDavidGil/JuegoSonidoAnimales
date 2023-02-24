using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    public static class Interactor
    {
        public static void EsperaLoad()
        {
            Thread.Sleep(6000);
        }
        public static void MostrarCargando(Form aux)
        {
            aux.Show();
        }
        public static void OcultarCargando(Form aux)
        {
            if (aux != null)
                aux.Close();
        }
    }
}
