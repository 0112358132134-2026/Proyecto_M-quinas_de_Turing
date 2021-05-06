using System;
using System.Media;
using System.Windows.Forms;

namespace Proyecto_Máquinas_de_Turing
{
    public partial class CargarTXT : Form
    {
        public CargarTXT()
        {
            InitializeComponent();
            //SoundPlayer musica = new SoundPlayer(@"C:\Users\68541\Desktop\cancion.wav");
            //musica.Play();
        }

        #region Variables_Globales
        public static MT mt = new MT();
        public static FunMet fm = new FunMet();
        #endregion
        #region Procesos  
        //CARGA DE ARCHIVO
        private void Cargar_txt_Click(object sender, EventArgs e)
        {
            OpenFileDialog cargar = new OpenFileDialog();
            if (cargar.ShowDialog() == DialogResult.OK)
            {
                string extensión = cargar.FileName.Substring(cargar.FileName.Length - 3,3);
                
                if (extensión.Equals("txt"))
                {
                    txtArchivo.Text = "¡Formato válido!";                    
                    string [] contenido = System.IO.File.ReadAllLines(cargar.FileName);

                    bool llenado = fm.LlenarMT(contenido, mt);
                    if (llenado)
                    {
                        txtArchivo.Text = "";
                        Proceso seguir = new Proceso();
                        this.Visible = false;
                        seguir.Show();
                    }
                    else
                    {
                        mt = new MT();
                        txtArchivo.Text = "Formato inválido...";
                    }                   
                }
                else
                {
                    txtArchivo.Text = "Ingrese un archivo txt...";
                }
            }
            else
            {
                txtArchivo.Text = "Ingrese algún archivo...";
            }
        }

        //CIERRE DE APLICACIÓN
        private void BtnExit1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();            
        }
        #endregion
    }
}