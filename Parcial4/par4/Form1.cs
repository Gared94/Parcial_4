using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaPresentacion;



namespace par4
{
    public partial class Form1 : Form
    {
        manttHospital mh = new manttHospital();
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            mh.Hospital = int.Parse(txtCodigo.Text);
            mh.Nombre = txtNombre.Text;
            mh.Direccion = txtDireccion.Text;
            mh.Telefono = txtTelefono.Text;
            mh.Ncama = int.Parse(txtCama.Text);
            mh.insertarHospital();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
