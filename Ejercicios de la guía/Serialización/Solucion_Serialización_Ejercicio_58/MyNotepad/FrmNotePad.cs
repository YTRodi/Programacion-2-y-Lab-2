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
        private PuntoTxt pTxt = null;
        private string lastPath;
        public FrmNotePad()
        {
            InitializeComponent();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Elija el archivo";
            openFileDialog1.InitialDirectory = "C:\\Desktop";
            //string filtroOriginal = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            string filtro = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
            openFileDialog1.Filter = filtro;

            StreamReader sr = null;

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pDat = new PuntoDat("lele");
                    //if (File.Exists(openFileDialog1.FileName))
                    //{
                        //pDat = new PuntoDat();
                        pDat.Leer(openFileDialog1.FileName);
                        rTextBox.Text = pDat.Contenido;
                        //sr = new StreamReader(openFileDialog1.FileName);
                        //rTextBox.Text = sr.ReadToEnd();
                        //lastPath = openFileDialog1.FileName;
                    //}
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (!(sr is null))
                    sr.Close();
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            try
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    sw = new StreamWriter(lastPath);
                    sw.WriteLine(rTextBox.Text);
                }
                else
                {
                    this.abrirToolStripMenuItem_Click(sender, e);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (!(sw is null))
                {
                    //rTextBox.Text = string.Empty;
                    this.MsgArchivoGuardadoSuccess();
                    sw.Close();
                }
            }

        }
        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1.Title = "Elija el archivo";
            saveFileDialog1.InitialDirectory = "C:\\Desktop";
            string filtro = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat";
            openFileDialog1.Filter = filtro;

            StreamWriter sw = null;

            try
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(saveFileDialog1.FileName))
                    {
                        sw = new StreamWriter(saveFileDialog1.FileName);//,true);
                        sw.WriteLine(rTextBox.Text);
                    }
                    else
                    {
                        sw = new StreamWriter(saveFileDialog1.FileName);//,true);
                        sw.WriteLine(rTextBox.Text);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (!(sw is null))
                {
                    //rTextBox.Text = string.Empty;
                    this.MsgArchivoGuardadoSuccess();
                    sw.Close();
                }
            }

        }

        private void rTextBox_TextChanged(object sender, EventArgs e)
        {
            //tsCaracteres.Text = string.Empty;
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
