using AForge.Video;
using AForge.Video.DirectShow;
using Datos;
using Entidades;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ControlV2
{
    public partial class FrmRegistrarUsuario : Form
    {
        private VideoCaptureDevice camara = null;

        public FrmRegistrarUsuario()
        {
            InitializeComponent();
        }

        private void txtBxNúmeroDeCédula_TextChanged(object sender, EventArgs e)
        {
            if (txtBxNúmeroDeCédula.Text != "")
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void chckBxVerContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxVerContraseña.Checked)
                txtBxContraseña.PasswordChar = '\0';
            else
                txtBxContraseña.PasswordChar = '*';
        }

        private void txtBxNúmeroDeCédula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) | char.IsControl(e.KeyChar))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtBxNombres.TextLength == 0)
                txtBxNombres.BackColor = Color.LightPink;
            else if (txtBxApellidos.TextLength == 0)
                txtBxApellidos.BackColor = Color.LightPink;
            else if (txtBxNúmeroDeCédula.TextLength == 0)
                txtBxNúmeroDeCédula.BackColor = Color.LightPink;
            else if (txtBxEdad.TextLength == 0)
                txtBxEdad.BackColor = Color.LightPink;
            else if (txtBxPrefijoTeléfono.TextLength == 0)
                txtBxPrefijoTeléfono.BackColor = Color.LightPink;
            else if (txtBxTeléfono.TextLength == 0)
                txtBxTeléfono.BackColor = Color.LightPink;
            else if (txtBxDirección.TextLength == 0)
                txtBxDirección.BackColor = Color.LightPink;
            else if (txtBxCorreoElectrónico.TextLength == 0)
                txtBxCorreoElectrónico.BackColor = Color.LightPink;
            else if (txtBxNombreDeUsuario.TextLength == 0)
                txtBxNombreDeUsuario.BackColor = Color.LightPink;
            else if (txtBxContraseña.TextLength == 0)
                txtBxContraseña.BackColor = Color.LightPink;
            else
            {
                BaseDeDatosUsuarios usuarios = new BaseDeDatosUsuarios();
                usuarios.insertar(new Usuario(txtBxNombres.Text + ";" + txtBxApellidos.Text, txtBxNúmeroDeCédula.Text, (byte)cmbBxGénero.SelectedIndex,
                    short.Parse(txtBxEdad.Text), txtBxPrefijoTeléfono.Text + ";" + txtBxTeléfono.Text, txtBxDirección.Text,
                    txtBxCorreoElectrónico.Text, DateTime.Today, "foto.png", txtBxNombreDeUsuario.Text, txtBxContraseña.Text, (byte)cmbBxRol.SelectedIndex));
            }
        }
        
        private void capturar(object sender, NewFrameEventArgs e)
        {
            Bitmap imagen = (Bitmap)e.Frame.Clone();
            pctrBxFotografía.Image = imagen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                VideoCaptureDeviceForm camaras = new VideoCaptureDeviceForm();
                if (camaras.ShowDialog() == DialogResult.OK)
                {
                    camara = camaras.VideoDevice;
                    camara.NewFrame += new NewFrameEventHandler(capturar);
                    camara.Start();
                    btnImagen.Text = "Capturar";
                }
            }
            catch (Exception d)
            {
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (btnImagen.Text == "Capturar")
            {
                camara.Stop();
                MemoryStream flujo = new MemoryStream();
                pctrBxFotografía.Image.Save(flujo, ImageFormat.Png);
                btnImagen.Text = "...";
            }
            else
            {
                OpenFileDialog seleccionarArchivo = new OpenFileDialog();
                seleccionarArchivo.Filter = "Imagen (*.png)|*.png";
                seleccionarArchivo.FilterIndex = 1;
                seleccionarArchivo.Multiselect = false;
                if (seleccionarArchivo.ShowDialog() == DialogResult.OK)
                    pctrBxFotografía.Image = Image.FromFile(seleccionarArchivo.FileName);
            }
        }

        private void txtBxNombres_Enter_1(object sender, EventArgs e)
        {
            TextBox txtBx = sender as TextBox;
            if (txtBx.BackColor == Color.LightPink)
                txtBx.BackColor = Color.White;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (btnEditar.Text == "Editar")
            {
                BaseDeDatosUsuarios usuarios = new BaseDeDatosUsuarios();
                Usuario usuario = usuarios.conseguir(txtBxNúmeroDeCédula.Text);
                if (usuario != null)
                {
                    btnRegistrar.Enabled = btnEliminar.Enabled = false;
                    string[] nombreCompleto = usuario.Nombre.Split(';');
                    txtBxNombres.Text = nombreCompleto[0];
                    txtBxApellidos.Text = nombreCompleto[1];
                    cmbBxGénero.SelectedIndex = usuario.Género;
                    txtBxEdad.Text = usuario.Edad.ToString();
                    txtBxNúmeroDeCédula.Enabled = false;
                    string[] teléfonoCompleto = usuario.Teléfono.Split(';');
                    txtBxPrefijoTeléfono.Text = teléfonoCompleto[0];
                    txtBxTeléfono.Text = teléfonoCompleto[1];
                }
            }
            else
            {

            }
        }
    }
}
