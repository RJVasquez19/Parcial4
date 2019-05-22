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
    public partial class Form2 : Form
    {
        manttoSala obj = new manttoSala();

        public Form2()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

            obj.SalaCod = int.Parse(txtCodigo.Text);
            obj.CodHospital = int.Parse(txtDireccion.Text);
            obj.NombreSala = txtNombre.Text;
            obj.NumCama = int.Parse(txtNumCama.Text);

            obj.insertarSala();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            obj.SalaCod = int.Parse(txtCodigo.Text);

            obj.deleteSala();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            obj.SalaCod = int.Parse(txtCodigo.Text);
            obj.CodHospital = int.Parse(txtDireccion.Text);
            obj.NombreSala = txtNombre.Text;
            obj.NumCama = int.Parse(txtNumCama.Text);
            obj.updateSala();
        }
    }
}
