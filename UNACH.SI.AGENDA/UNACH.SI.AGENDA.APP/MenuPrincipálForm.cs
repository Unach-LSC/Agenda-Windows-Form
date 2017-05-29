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
    public partial class MenuPrincipálForm : Form
    {
        public MenuPrincipálForm()
        {
            InitializeComponent();
        }
        UsuarioClass _usuario = new UsuarioClass();

        private void MenuPrincipálForm_Load(object sender, EventArgs e)
        {
            cargarLogin();
            cargarUsuario();
        }

        private void Usuariosdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Usuariosdgv.Rows[e.RowIndex];             
                    _usuario.id = int.Parse(row.Cells["IdColumn"].Value.ToString());
                    _usuario.Login = row.Cells["LoginColumn"].Value.ToString();
                    _usuario.Contraseña = row.Cells["ContraseñaColumn"].Value.ToString();
                    _usuario.NombreCompleto = row.Cells["NombreColumn"].Value.ToString();
                    Nombrelabel.Text = _usuario.NombreCompleto;
            }
        }

        private void cargarUsuario()
        {
            Usuariosdgv.AutoGenerateColumns = false;
            AgendaBDDataSetTableAdapters.UsuariosTableAdapter agendaDs = new AgendaBDDataSetTableAdapters.UsuariosTableAdapter();
            Usuariosdgv.DataSource = agendaDs.GetData();
        }

        private void cargarLogin()
        {
            LOGINFORM login = new LOGINFORM();
            login.ShowDialog();
        }
       
        private void buscarbtn_Click(object sender, EventArgs e)
        {
            AgendaBDDataSetTableAdapters.UsuariosTableAdapter agendaDs = new AgendaBDDataSetTableAdapters.UsuariosTableAdapter();
            Usuariosdgv.DataSource = agendaDs.GetDataUsuarioPorNombre(buscartxt.Text);
        }

        private void Nuevobtn_Click(object sender, EventArgs e)
        {     
            Usuarios.UsuarioForm use = new Usuarios.UsuarioForm();
            use.esNuevo = true;
            use.ShowDialog();
            cargarUsuario();
        }

        private void Modificarbtn_Click(object sender, EventArgs e)
        {
            if (_usuario != null)
            {
                Usuarios.UsuarioForm _editarusuario = new Usuarios.UsuarioForm();
                _editarusuario.esNuevo = false;
                _editarusuario.id = _usuario.id.ToString();
                _editarusuario.Login = _usuario.Login;
                _editarusuario.Contraseña = _usuario.Contraseña;
                _editarusuario.NombreCompleto = _usuario.NombreCompleto;
                _editarusuario.ShowDialog();
                cargarUsuario();
            }
              
           
        }

        private void Eliminarbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Realmente eliminaras?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                try
                {
                    if (_usuario != null)
                    {
                        AgendaBDDataSetTableAdapters.UsuariosTableAdapter agendaDs = new AgendaBDDataSetTableAdapters.UsuariosTableAdapter();
                        agendaDs.DeleteUsuarioQuery(_usuario.id);
                        cargarUsuario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
      

        
    }
    public class UsuarioClass
    {
        public int id { get; set; }
        public string Login { get; set; }
        public string Contraseña { get; set; }
        public string NombreCompleto { get; set; }

    }
}
