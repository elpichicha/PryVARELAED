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
    public partial class frmListaDoblmenteEnlazada : Form
    {
        public frmListaDoblmenteEnlazada()
        {
            InitializeComponent();
        }

        clsListaSimple FilaDePersona = new clsListaSimple();

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsNodo ObjNodo = new clsNodo();
            ObjNodo.Codigo = Convert.ToInt32(TXTcodigo.Text);
            ObjNodo.Nombre = TXTcodigo.Text;
            ObjNodo.Tramite = TXTtramite.Text;
            FilaDePersona.Agregar(ObjNodo);
            FilaDePersona.Recorrer(dgvListaDoble);
            FilaDePersona.Recorrer(LSTlistadoble);
            FilaDePersona.Recorrer(CMDcodigo);
            FilaDePersona.Recorrer();
            TXTcodigo.Text = "";
            TXTnombre.Text = "";
            TXTtramite.Text = "";
        }
    }
}
