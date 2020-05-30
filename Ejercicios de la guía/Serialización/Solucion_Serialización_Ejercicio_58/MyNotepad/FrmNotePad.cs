using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{
    public partial class FrmNotePad : Form
    {
        private PuntoDat pDat = null;
        private PuntoDat pDatAux = null;
        private PuntoTxt pTxt = null;
        //private string lastPath;
        //private string lastPath = string.Empty;
        string filePath = string.Empty;

        public FrmNotePad()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filtro = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";
            OpenFileDialog opFD = new OpenFileDialog();
            opFD.Title = "Elija el archivo";
            opFD.InitialDirectory = "C:\\Desktop";
            opFD.Filter = filtro;

            try
            {
                if (opFD.ShowDialog() == DialogResult.OK)
                {
                    filePath = opFD.FileName;
                    try
                    {
                        if (Path.GetExtension(filePath) is ".txt")
                        {
                            pTxt = new PuntoTxt();
                            rTextBox.Text = pTxt.Leer(filePath);
                        }
                        else
                        {
                            pDat = new PuntoDat();
                            pDat = pDat.Leer(filePath);
                            rTextBox.Text = pDat.Contenido;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            try
            {
                if(File.Exists(filePath))
                {
                    if (Path.GetExtension(filePath) is ".txt")
                    {
                        pTxt = new PuntoTxt();
                        if (pTxt.Guardar(filePath, rTextBox.Text))
                        {
                            MessageBox.Show("Archivo .txt guardado con éxito");
                        }
                        else
                        {
                            MessageBox.Show("el archivo .txt no existe");
                        }
                        //rTextBox.Text = string.Empty;
                    }
                    else
                    {
                        pDat = new PuntoDat();
                        pDatAux = new PuntoDat();
                        pDatAux.Contenido = rTextBox.Text;
                        if (pDat.GuardarComo(filePath, pDatAux))
                        {
                            MessageBox.Show("Archivo .dat guardado con éxito");
                        }
                        else
                        {
                            MessageBox.Show("el archivo .dat no existe");
                        }
                    }
                }
                else
                {
                    this.guardarComoToolStripMenuItem_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filtro = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";
            SaveFileDialog svFD = new SaveFileDialog();
            svFD.Title = "Elija el archivo";
            svFD.InitialDirectory = "C:\\Desktop";
            svFD.Filter = filtro;

            if (svFD.ShowDialog() == DialogResult.OK)
            {
                filePath = svFD.FileName;
                try
                {
                    if (Path.GetExtension(filePath) is ".txt")
                    {
                        pTxt = new PuntoTxt();
                        if (pTxt.GuardarComo(filePath, rTextBox.Text))
                        {
                            MessageBox.Show("Archivo .txt guardado con éxito");
                        }
                        else
                        {
                            MessageBox.Show("el archivo .txt no existe");
                        }
                        rTextBox.Text = string.Empty;
                    }
                    else
                    {
                        pDat = new PuntoDat();
                        pDatAux = new PuntoDat();
                        pDatAux.Contenido = rTextBox.Text;
                        if (pDat.GuardarComo(filePath, pDatAux))
                        {
                            MessageBox.Show("Archivo .dat guardado con éxito");
                        }
                        else
                        {
                            MessageBox.Show("el archivo .dat no existe");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void rTextBox_TextChanged(object sender, EventArgs e)
        {
            tsCaracteres.Text = $"{rTextBox.Text.Length} caracteres.";
        }

        public void MsgArchivoGuardadoSuccess()
        {
            MessageBox.Show("Archivo guardado con éxito",
                       "Notificación",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information);
        }
    }
}
