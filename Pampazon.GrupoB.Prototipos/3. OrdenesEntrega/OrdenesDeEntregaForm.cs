﻿using Pampazon.GrupoB.Prototipos.OrdenesEntrega.DespachoOrdenEntrega;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class OrdenesDeEntregaForm : Form
    {
        public OrdenesDeEntregaModelo Modelo;
        public OrdenesDeEntregaForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotonCrearOrdenEntrega_Click(object sender, EventArgs e)
        {
            var formCrearOrdenEntrega = new CrearOrdenEntregaForm();
            //formGestionarStock.Modelo = modelo;
            formCrearOrdenEntrega.ShowDialog();
        }

        private void BotonActualizarOrdenEntrega_Click(object sender, EventArgs e)
        {
            var formActualizarOrdenEntrega = new DespachoOrdenEntregaForm();
            //formGestionarStock.Modelo = modelo;
            formActualizarOrdenEntrega.ShowDialog();
        }

        private void OrdenesDeEntregaForm_Load(object sender, EventArgs e)
        {
            Modelo = new();
        }
    }
}
