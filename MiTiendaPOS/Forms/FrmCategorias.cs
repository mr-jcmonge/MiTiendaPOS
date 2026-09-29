using MiTiendaPOS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiTiendaPOS.Forms
{
    public partial class FrmCategorias : Form
    {
        private readonly CategoriaService _servicio = new();
        private int _idSeleccionado = 0;//para registro nuevo
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            CargarCategorias();
            LimpiarFormulario();
        }

        private void CargarCategorias()
        {
            dgvCategorias.DataSource = _servicio.Listar(txtBuscar.Text)
                .Select(c => new {c.Id, c.Nombre})
                .ToList();
        }
        private void LimpiarFormulario()
        {
            _idSeleccionado = 0; 
            txtNombre.Clear();
            btnEliminar.Enabled = false;
            dgvCategorias.ClearSelection();
            txtNombre.Focus();
        }
    }
}
