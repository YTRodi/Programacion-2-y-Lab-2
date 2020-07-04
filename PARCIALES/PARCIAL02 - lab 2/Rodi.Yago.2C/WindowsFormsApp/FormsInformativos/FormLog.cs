using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.FormsInformativos
{
    public partial class FormLog : Form
    {
        public FormLog()
        {
            InitializeComponent();
        }

        public RichTextBox RtbLog
        {
            get { return this.rtbMostrarLog; }
            set { this.rtbMostrarLog = value; }
        }

        private void pBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
