using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryVARELAED
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        clsCola FilaDePersona = new clsCola();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(TXTcodigo2.Text);
            ObjNodo.Nombre = TXTnombre.Text;
            ObjNodo.Tramite = TXTtramite.Text;
            FilaDePersona.Agregar(ObjNodo);
            FilaDePersona.Recorrer(dgvCola);
            FilaDePersona.Recorrer(LSTcola);
            FilaDePersona.Recorrer();
            TXTcodigo.Text = "";
            TXTcodigo.Text = "";
            TXTtramite.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (FilaDePersona.Primero != null)
            {
                LBLcodigo2.Text = FilaDePersona.Primero.Codigo.ToString();
                LBLcodigo2.Text = FilaDePersona.Primero.Nombre;
               LBLtramite2.Text = FilaDePersona.Primero.Tramite;
                FilaDePersona.Eliminar();
                FilaDePersona.Recorrer(dgvCola);
                FilaDePersona.Recorrer(lstCola);
                FilaDePersona.Recorrer();
            }
            else
            {
                lbleliminar.Text = "";
                lblNombreEliminar.Text = "";
                lblTramiteEliminar.Text = "";
            }
        }
    }
}
