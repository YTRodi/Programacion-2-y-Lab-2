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
            string filtro = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";
            openFileDialog1.Filter = filtro;

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //pTxt = new PuntoTxt();
                    //rTextBox.Text = pTxt.Leer(openFileDialog1.FileName);

                    pDat = new PuntoDat();
                    PuntoDat pDatAux = new PuntoDat();
                    pDatAux = pDat.Leer(openFileDialog1.FileName);
                    rTextBox.Text = pDatAux.Contenido;

                    //sr = new StreamReader(openFileDialog1.FileName);
                    //rTextBox.Text = sr.ReadToEnd();
                    //lastPath = openFileDialog1.FileName;

                    //pDat = new PuntoDat();
                    //pDat = pDat.Leer(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                throw;
            }

            //try
            //{
            //    if (openFileDialog1.ShowDialog() == DialogResult.OK)
            //    {
            //        //pDat = new PuntoDat();
            //        pDat = new PuntoDat();
            //        //VALIDA SI EXISTE EL ARCHIVO EL METODO VALIDARARCHIVO DE LA CLASE ARCHIVO.CS

            //        if (File.Exists(openFileDialog1.FileName))
            //        {
            //            sr = new StreamReader(openFileDialog1.FileName);
            //            rTextBox.Text = sr.ReadToEnd();
            //            lastPath = openFileDialog1.FileName;

            //            //pDatAux.Contenido = rTextBox.Text;
            //            pDat.Leer(openFileDialog1.FileName);

            //            MessageBox.Show("Deserealizado con éxito",
            //                "Notificación",
            //                MessageBoxButtons.OK,
            //                MessageBoxIcon.Information);
            //        }
            //    }
            //}
            //catch (Exception)
            //{
            //    throw;
            //}
            //finally
            //{
            //    if (!(sr is null))
            //        sr.Close();
            //}
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
                    this.guardarComoToolStripMenuItem_Click(sender, e);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (!(sw is null))
                {
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
            string filtro = "txt files (*.txt)|*.txt|dat files (*.dat)|*.dat|All files (*.*)|*.*";
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

                        pDat = new PuntoDat(rTextBox.Text);
                        pDat.Guardar(saveFileDialog1.FileName, pDat);
                    }
                    else
                    {
                        sw = new StreamWriter(saveFileDialog1.FileName);//,true);
                        sw.WriteLine(rTextBox.Text);

                        pDat = new PuntoDat(rTextBox.Text);
                        pDat.Guardar(saveFileDialog1.FileName, pDat);
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
                    this.MsgArchivoGuardadoSuccess();
                    sw.Close();
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
