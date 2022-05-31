using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WindowsFormsPersona
{
    public partial class FrmAltaPersona : Form
    {

        Persona persona = null;
        private bool nuevo = false;
        public FrmAltaPersona(bool nuevo)
        {
            InitializeComponent();
            Text = "Agregar Persona";
            this.nuevo = nuevo; 
            
        }
        public FrmAltaPersona(Persona persona, bool nuevo)
        {
            InitializeComponent();
            this.persona = persona;
            Text = "Modificar Persona";
            this.nuevo = nuevo;
        }


        private void FrmAltaPersona_Load(object sender, EventArgs e)
        {   
            EstadoCivilNegocio estadoNegocio = new EstadoCivilNegocio();        
            TipoDocNegocio tipoNegocio = new TipoDocNegocio();
            try
            {
                cboEstadoCivil.DataSource = estadoNegocio.listar();
                cboEstadoCivil.ValueMember = "Id";
                cboEstadoCivil.DisplayMember = "Nombre";

                cboTipoDocumento.DataSource = tipoNegocio.listar();
                cboTipoDocumento.ValueMember = "Id";
                cboTipoDocumento.DisplayMember = "Nombre";

                if (nuevo==false)
                {
                    txtApellido.Text=persona.Apellido;
                    txtNombres.Text = persona.Nombre;
                    cboTipoDocumento.SelectedValue = persona.TipoDocumento.Id;
                    txtDocumento.Enabled = false;
                    cboEstadoCivil.SelectedValue = persona.EstadoCivil.Id;
                    if (persona.Sexo == 1)
                    {
                        rbtFemenino.Checked = true;
                    }
                    else if (persona.Sexo == 2)
                    {
                        rbtMasculino.Checked = true;
                    }


                    if (persona.Fallecio == false)
                    {
                        chkFallecio.Checked = false;
                    }
                    else if (persona.Fallecio == true)
                    {
                        chkFallecio.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            PersonaNegocio personaNegocio = new PersonaNegocio();

            try
            {
                if (nuevo==true)
                    persona = new Persona();    
                persona.Apellido = txtApellido.Text;
                persona.Nombre = txtNombres.Text;
                persona.TipoDocumento = (TipoDocumento)cboTipoDocumento.SelectedItem;
                persona.EstadoCivil = (EstadoCivil)cboEstadoCivil.SelectedItem;
                if(rbtFemenino.Checked)
                {
                    persona.Sexo = 1;
                }
                else
                {
                    persona.Sexo = 2;
                }

                if(chkFallecio.Checked == true)
                {
                    persona.Fallecio = true;
                }
                else
                {
                    persona.Fallecio = false;   
                }

                if (nuevo==false)
                {

                    personaNegocio.Modificar(persona);
                    MessageBox.Show("Modificado Correctamente");
                   
                }
                else
                {
                    persona.Documento = Convert.ToInt32(txtDocumento.Text);
                    personaNegocio.Agregar(persona);
                    MessageBox.Show("Agregado Correctamente");
                }
               

                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();        
        }
    }
}
