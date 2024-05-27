﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pampazon.GrupoB.Prototipos.OrdenesPreparacion.ListarOrdenesPreparacion;

namespace Pampazon.GrupoB.Prototipos
{
    public partial class ListadoOrdenesPreparacionForm : Form
    {
        public ListadoOrdenesPreparacionModelo Modelo;
        public ListadoOrdenesPreparacionForm()
        {
            InitializeComponent();
        }

        private void BotonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListadoOrdenesPreparacionForm_Load(object sender, EventArgs e)
        {
            Modelo = new();

            foreach (var ordenrecepcion in Modelo.OrdenesPreparacion)
            {
                var fila = new ListViewItem();
                //hacer algo con la fila
                fila.Text = ordenrecepcion.IdOrdenPreparacion.ToString();
                fila.SubItems.Add(ordenrecepcion.IdCliente);
                fila.SubItems.Add(ordenrecepcion.DescripcionCliente);
                fila.SubItems.Add(ordenrecepcion.IdProducto);
                fila.SubItems.Add(ordenrecepcion.DescripcionProducto);
                fila.SubItems.Add(ordenrecepcion.Cantidad.ToString());
                fila.SubItems.Add(ordenrecepcion.FechaOrdenRecepcion.ToString());
                fila.SubItems.Add(ordenrecepcion.EstadoRecepcion.ToString());
                fila.SubItems.Add(ordenrecepcion.Prioridad);
                fila.Tag = ordenrecepcion;
                ListViewListaOrdenesPreparacion.Items.Add(fila);
            }
        }

        private void BotonLimpiar_Click(object sender, EventArgs e)
        {
            TxtIdOrdenPreparacion.Text = string.Empty;
            TxtIDCliente.Text = string.Empty;
            TxtFecha.Text = string.Empty;
            ComboBoxPrioridad.Text = string.Empty;
            ComboBoxEstado.Text = string.Empty;
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
