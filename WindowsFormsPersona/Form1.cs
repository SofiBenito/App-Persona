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
    public partial class Form1 : Form
    {
        private List<Persona> personaList = new List<Persona>();
  

        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        //funcion para cargar al data gri view
        public void Cargar()
        {
            PersonaNegocio negocio = new PersonaNegocio();

            try
            {
                personaList = negocio.listar();
                dgvPersona.DataSource = personaList;            

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }


        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            
            FrmAltaPersona alta = new FrmAltaPersona(true);
            alta.ShowDialog();   
            Cargar();       
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            
            Persona seleccionada;
            seleccionada = (Persona)dgvPersona.CurrentRow.DataBoundItem;

            FrmAltaPersona modificar = new FrmAltaPersona (seleccionada,false);
            modificar.ShowDialog();
            Cargar();
        }

        private void BtnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void dgvPersona_SizeChanged(object sender, EventArgs e)
        {
            Persona seleccionada=(Persona)dgvPersona.CurrentRow.DataBoundItem;  
        }

        private void BtnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico =false)
        {
            PersonaNegocio negocio = new PersonaNegocio();
            Persona seleccionada;

            try
            {
                DialogResult Respuesta = MessageBox.Show("¿Seguro Que Quiere Eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (Respuesta == DialogResult.Yes)
                {
                    seleccionada = (Persona)dgvPersona.CurrentRow.DataBoundItem;
                    if (logico)
                        negocio.eliminarLogico(seleccionada.Documento);
                    else
                        negocio.Eliminar(seleccionada.Documento);
                    Cargar();
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?",
               "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2) == DialogResult.Yes)

                Close();
        }
    }
}
