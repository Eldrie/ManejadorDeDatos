﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crear nuevaPestaña = new Crear();
            nuevaPestaña.Show();
                       
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agregar nuevaPestaña = new Agregar();
            nuevaPestaña.Show();
        }
    }
}
