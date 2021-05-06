using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_Máquinas_de_Turing
{
    public partial class Proceso : Form
    {
        public Proceso()
        {
            InitializeComponent();           
        }

        #region Variables_Globales
        public static int posicionLista = 0;
        public static int contadorEjAuto = 0;
        public static int estadoActual = CargarTXT.mt.S;       
        public static bool terminado = false;
        public static bool error = false;   
        public static string mensajeLoop = "Parece que algo está saliendo mal, se habilitó la opción de cambiar a la ejecución paso a paso, para que puede examinar qué está ocurriendo";
        #endregion
        #region Botones_Básicos
        //REGRESA AL FROMS 1
        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            //Reiniciar valores
            posicionLista = 0;
            terminado = false;

            this.Close();
            this.Dispose();
            CargarTXT regresar = new CargarTXT
            {
                Visible = true
            };
        }
       
        //CIERRE DE APLICACIÓN
        private void BtnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();                      
        }
        
        //COMENZAR DE NUEVO
        private void BtnDeNuevo_Click(object sender, EventArgs e)
        {
            Comenzar_Denuevo();
        }
        #endregion
        #region Acciones_MT
        //VALIDACIÓN DE PALABRA A EVALUAR
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPalabra.Text == "")
            {                
                MessageBox.Show("Debe ingresar alguna palabra...");
            }
            else
            {
                if (CargarTXT.mt.Validar_Palabra(txtPalabra.Text))
                {
                    CargarTXT.mt.Agregar_Palabra(txtPalabra.Text);
                    txtPalabra.Enabled = false;
                    BtnIngresar.Enabled = false;
                    cBoxOpcion1.Enabled = true;
                    cBoxOpcion2.Enabled = true;
                    BtnHabilitar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Ingresó un palabra con una letra que no está dentro del alfabeto de la MT...");
                }               
            }
        }

        //HABILITA LA EJECUCIÓN SELECCIONADA
        private void BtnHabilitar_Click(object sender, EventArgs e)
        {
            if (cBoxOpcion1.Checked == true && cBoxOpcion2.Checked == true)
            {
                MessageBox.Show("Debe marcar solo una opción...");
            }
            else if (cBoxOpcion1.Checked == true && cBoxOpcion2.Checked == false)
            {
                MessageBox.Show("¡A elegido la ejecución automática!");
                BtnAutomatico.Enabled = true;
                cBoxOpcion1.Enabled = false;
                cBoxOpcion2.Enabled = false;
                BtnHabilitar.Enabled = false;
                estadoActual = CargarTXT.mt.S;
            }
            else if (cBoxOpcion1.Checked == false && cBoxOpcion2.Checked == true)
            {
                MessageBox.Show("¡A elegido la ejecución paso a paso!");
                BtnPasoAPaso.Enabled = true;
                cBoxOpcion1.Enabled = false;
                cBoxOpcion2.Enabled = false;
                BtnHabilitar.Enabled = false;
                BtnCambioAuto.Enabled = true;

                txtCintaActual.Text = Cinta_Actual();
                txtPosCabezal.Text = posicionLista.ToString();
                estadoActual = CargarTXT.mt.S;
                txtEstadoActual.Text = estadoActual.ToString();
                Transicion transicionActual = CargarTXT.mt.Buscar_Transicion(estadoActual, CargarTXT.mt.Palabra[posicionLista]);
                txtUltimaTrans.Text = transicionActual.F + "," + transicionActual.Escribir + "," + transicionActual.Mov.ToString();
            }
        }

        //EJECUCIÓN PASO A PASO
        private void BtnPasoAPaso_Click(object sender, EventArgs e)
        {
            Transicion transicionActual = CargarTXT.mt.Buscar_Transicion(estadoActual, CargarTXT.mt.Palabra[posicionLista]);

            if (transicionActual.Encontrada)
            {
                CargarTXT.mt.Palabra[posicionLista] = transicionActual.Escribir;
                estadoActual = transicionActual.F;

                switch (transicionActual.Mov)
                {
                    case 'D':
                        if (CargarTXT.mt.Palabra.Count - (posicionLista + 1) < 0)
                        {
                            CargarTXT.mt.Palabra.Add('_');
                        }
                        posicionLista += 1;
                        break;
                    case 'I':
                        posicionLista -= 1;
                        break;
                    case '0':
                        break;
                    case 'P':
                        BtnPasoAPaso.Enabled = false;
                        break;
                    default:
                        error = true;
                        terminado = true;
                        break;
                }
                if (error)
                {
                    BtnAutomatico.Enabled = false;
                    BtnPasoAPaso.Enabled = false;
                    MessageBox.Show("Parece que un movimiento de la cinta es incorrecto...");
                    Comenzar_Denuevo();
                }
                else
                {
                    if (Cinta_Actual().Length < txtCintaActual.MaxLength)
                    {
                        txtCintaActual.Text = Cinta_Actual();
                    }
                    else
                    {
                        txtCintaActual.Text = "La cinta es demasiado grande para ser mostrada...";
                    }

                    txtPosCabezal.Text = posicionLista.ToString();
                    txtEstadoActual.Text = estadoActual.ToString();

                    if (CargarTXT.mt.Palabra.Count - (posicionLista + 1) < 0)
                    {
                        CargarTXT.mt.Palabra.Add('_');
                    }

                    Transicion transicionActualAux = CargarTXT.mt.Buscar_Transicion(estadoActual, CargarTXT.mt.Palabra[posicionLista]);
                    txtUltimaTrans.Text = transicionActualAux.F + "," + transicionActualAux.Escribir + "," + transicionActualAux.Mov.ToString();
                }               
            }
            else
            {
                txtCintaActual.Text = txtCintaActual.Text;
                txtPosCabezal.Text = txtPosCabezal.Text;
                txtEstadoActual.Text = txtEstadoActual.Text;
                txtUltimaTrans.Text = txtUltimaTrans.Text;
                BtnPasoAPaso.Enabled = false;
                BtnCambioAuto.Enabled = false;
                MessageBox.Show("No existe ninguna transición para este caso...");
            }            
        }

        //EJECUCIÓN AUTOMÁTICA
        private void BtnAutomatico_Click(object sender, EventArgs e)
        {
            while (!terminado)
            {
                if (CargarTXT.mt.Palabra.Count - (posicionLista + 1) < 0)
                {
                    CargarTXT.mt.Palabra.Add('_');
                }

                Transicion transicionActual = CargarTXT.mt.Buscar_Transicion(estadoActual, CargarTXT.mt.Palabra[posicionLista]);
         
                if (transicionActual.Encontrada)
                {
                    CargarTXT.mt.Palabra[posicionLista] = transicionActual.Escribir;
                    estadoActual = transicionActual.F;

                    switch (transicionActual.Mov)
                    {
                        case 'D':
                            if (CargarTXT.mt.Palabra.Count - (posicionLista + 1) < 0)
                            {
                                CargarTXT.mt.Palabra.Add('_');
                            }
                            posicionLista += 1;
                            break;
                        case 'I':
                            posicionLista -= 1;
                            break;
                        case '0':                                                        
                            break;
                        case 'P':
                            terminado = true;
                            break;
                        default:
                            error = true;
                            terminado = true;
                            break;
                    }                                
                }
                else
                {
                    error = true;
                    terminado = true;
                }

                contadorEjAuto += 1;

                if (contadorEjAuto == 60000000)
                {
                    terminado = true;
                }
            }
            if (contadorEjAuto == 60000000)
            {
                MessageBox.Show(mensajeLoop);
                BtnCambioPaso.Enabled = true;
            }
            else if (error)
            {
                BtnAutomatico.Enabled = false;
                BtnPasoAPaso.Enabled = false;
                MessageBox.Show("Parece que un movimiento de la cinta es incorrecto...");
                Comenzar_Denuevo();
            }
            else
            {
                txtResultado.Text = Cinta_Actual();
            }
        }

        //CAMBIA PROCESO DE EJECUCIÓN "PASO A PASO" A "AUTOMÁTICA"
        private void BtnCambioAuto_Click(object sender, EventArgs e)
        {
            BtnPasoAPaso.Enabled = false;
            BtnCambioAuto.Enabled = false;
            BtnAutomatico.Enabled = true;           
        }

        //CAMBIA PROCESO DE EJECUCIÓN "AUTOMÁTICA" A "PASO A PASO"
        private void BtnCambioPaso_Click(object sender, EventArgs e)
        {
            BtnAutomatico.Enabled = false;
            BtnCambioPaso.Enabled = false;
            BtnPasoAPaso.Enabled = true;
            BtnCambioAuto.Enabled = true;
            
            if (Cinta_Actual().Length < txtCintaActual.MaxLength)
            {
                txtCintaActual.Text = Cinta_Actual();
            }
            else
            {
                txtCintaActual.Text = "La cinta es demasiado grande para ser mostrada...";
            }

            txtPosCabezal.Text = posicionLista.ToString();
            txtEstadoActual.Text = estadoActual.ToString();

            if (CargarTXT.mt.Palabra.Count - (posicionLista + 1) < 0)
            {
                CargarTXT.mt.Palabra.Add('_');
            }

            Transicion transicionActualAux = CargarTXT.mt.Buscar_Transicion(estadoActual, CargarTXT.mt.Palabra[posicionLista]);
            txtUltimaTrans.Text = transicionActualAux.F + "," + transicionActualAux.Escribir + "," + transicionActualAux.Mov.ToString();
        }
        #endregion
        #region Funciones
        public string Cinta_Actual()
        {
            List<char> palabra = CargarTXT.mt.Palabra;
            StringBuilder cintaActual = new StringBuilder();
            for (int i = 0; i < palabra.Count; i++)
            {
                cintaActual.Append(palabra[i].ToString());
            }
            return cintaActual.ToString();
        }
        public void Comenzar_Denuevo()
        {
            txtPalabra.Text = "";
            txtPalabra.Enabled = true;
            BtnIngresar.Enabled = true;
            cBoxOpcion1.Enabled = false;
            cBoxOpcion1.Checked = false;
            cBoxOpcion2.Enabled = false;
            cBoxOpcion2.Checked = false;
            BtnHabilitar.Enabled = false;
            txtResultado.Text = "";
            BtnAutomatico.Enabled = false;
            BtnCambioPaso.Enabled = false;
            txtCintaActual.Text = "";
            txtPosCabezal.Text = "";
            txtEstadoActual.Text = "";
            txtUltimaTrans.Text = "";
            BtnPasoAPaso.Enabled = false;
            BtnCambioAuto.Enabled = false;

            error = false;
            posicionLista = 0;
            terminado = false;
            estadoActual = CargarTXT.mt.S;
            contadorEjAuto = 0;
        }
        #endregion
    }
}