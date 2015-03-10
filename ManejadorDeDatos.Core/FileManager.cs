using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorDeDatos.Core
{
    public class FileManager
    {
        public static void CrearArchivo(string nombreArchivo) 
        {
            var BD = File.CreateText(nombreArchivo + ".txt");
            BD.Close();
        }

        public static void AgregarArchivos(string campos) 
        {//Recibe informacion de CrearArchivo

            string[] columnas;
            columnas = campos.Split(' ');
            for (int i = 0; i < columnas.Length; i++)
            {
                File.AppendAllText(campos, columnas[i] + "|");
            }
            File.AppendAllText(campos, "\r\n");
        }
        

        public static void InsertarArchivos()
        { //Recibe informacion de AgregarArchivos
            
        }

        public static void ObtenerArchivo(string rutaArchivo) 
        {
        
                string resultado;

                System.IO.StreamReader file = new System.IO.StreamReader(rutaArchivo);
                resultado = file.ReadToEnd();
    
        }
    }
}
