using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNACH.SI.AGENDA.APP
{
    public partial class LOGINFORM : Form
    {
        public LOGINFORM()
        {
            InitializeComponent();
        }

        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Aceptarbtn_Click(object sender, EventArgs e)
        {
            AgendaBDDataSetTableAdapters.UsuariosTableAdapter agendaDs = new AgendaBDDataSetTableAdapters.UsuariosTableAdapter();
            var usuario = agendaDs.GetUsuarioLogueado(Nombretxt.Text, Passwordtxt.Text);
            if (usuario.Count > 0)
            {
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña erronea");
            }
            
        }

        private void LOGINFORM_Load(object sender, EventArgs e)
        {

        }
    }
}
