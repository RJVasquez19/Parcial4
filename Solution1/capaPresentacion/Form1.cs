using capaNegocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        manttoHospital obj = new manttoHospital();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            obj.IdHospital = int.Parse(txtCodigo.Text);
            obj.NombreHospital = txtNombre.Text;
            obj.Direccion = txtDireccion.Text;
            obj.Telefono = txtTelefono.Text;
            obj.NumCama = int.Parse(txtNumCama.Text);

            obj.insertarHospital();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            obj.IdHospital = int.Parse(txtCodigo.Text);
            obj.deleteHospital();
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            obj.IdHospital = int.Parse(txtCodigo.Text);
            obj.NombreHospital = txtNombre.Text;
            obj.Direccion = txtDireccion.Text;
            obj.Telefono = txtTelefono.Text;
            obj.NumCama = int.Parse(txtNumCama.Text);
            obj.updateHospital();

        }
    }
}
