using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorDeDatos
{
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          ManejadorDeDatos.Core.Class1.CrearArchivo(textBox1.Text);
          this.Close();
        }
    }
}
