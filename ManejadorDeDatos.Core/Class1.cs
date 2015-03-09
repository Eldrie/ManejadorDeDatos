using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorDeDatos.Core
{
    public class Class1
    {
        public static void CrearArchivo(string nombreArchivo) {
            var BD = File.CreateText(nombreArchivo + ".txt");
            BD.Close();
        }

        public static void AgregarArchivos(string campos){

        }
    }
}
