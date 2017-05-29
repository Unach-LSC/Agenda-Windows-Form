using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNACH.SI.AGENDA.APP.Usuarios
{
    public partial class UsuarioForm : Form
    {
        public UsuarioForm()
        {
            InitializeComponent();
        }
        #region Propiedades
        public bool esNuevo { get; set; }
    
        public string id
        { get { return this.Idtxt.Text; } set { this.Idtxt.Text = value; } }
        public string Login
        { get { return this.Logintxt.Text; } set { this.Logintxt.Text = value; } }
        public string Contraseña
        { get { return this.Contraseñatxt.Text; } set { this.Contraseñatxt.Text = value; } }
        public string NombreCompleto
        { get { return Nombretxt.Text; } set { this.Nombretxt.Text = value; } }
        #endregion
        private void Cancelarbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Guardarbtn_Click(object sender, EventArgs e)
        {

            if (Idtxt.Text != "" && Logintxt.Text != "" && Contraseñatxt.Text != "" && Nombretxt.Text != "")
            {
                try
                {
                    if (esNuevo == true)
                    {
                        AgendaBDDataSetTableAdapters.UsuariosTableAdapter pe = new AgendaBDDataSetTableAdapters.UsuariosTableAdapter();
                        pe.InsertUsuarioQuery(int.Parse(Idtxt.Text), Logintxt.Text, Contraseñatxt.Text, Nombretxt.Text);
                        this.Close();
                    }
                    else
                    {
                        AgendaBDDataSetTableAdapters.UsuariosTableAdapter pe = new AgendaBDDataSetTableAdapters.UsuariosTableAdapter();
                        pe.UpdateUsuarioQuery(int.Parse(Idtxt.Text), Logintxt.Text, Contraseñatxt.Text, Nombretxt.Text, int.Parse(Idtxt.Text));
                        this.Close();
                    }
                }
                catch (Exception exe)
                {

                    MessageBox.Show(exe.Message);
                }
                
            }

            else
            {
                MessageBox.Show("Campos vacios");
            }
        }
    }
}
