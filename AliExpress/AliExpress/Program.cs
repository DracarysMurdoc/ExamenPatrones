using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPaquetes;

namespace AliExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            LectorPaqueteria lector = new LectorPaqueteria();
            GestorPaquete gestorPaquete = new GestorPaquete(lector);


            ProcesadorPaquetes procesador = new ProcesadorPaquetes();


            



        }
    }
}
