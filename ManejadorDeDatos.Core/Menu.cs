using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorDeDatos.Core
{
    public class Menu
    {
        public static void CrearArchivo(string nombreArchivo) {
            var BD = File.CreateText(nombreArchivo + ".txt");
            BD.Close();
        }

        public static void AgregarArchivos(string campos){
           
            string nameBD = campos;
            string[] columnas;
            columnas = campos.Split(' ');
            for (int i = 0; i < columnas.Length; i++)
            {
                File.AppendAllText(nameBD, columnas[i] + "|");
            }
            File.AppendAllText(nameBD, "\r\n");

        }
    }
}
