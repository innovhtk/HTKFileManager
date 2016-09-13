using System;
using System.IO;
using System.Windows.Forms;

namespace HTK_FileManager
{
    public partial class frmFileManager : Form
    {
        public frmFileManager()
        {
            InitializeComponent();
        }

        private void btAbrir_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);
            }
        }

        private void frmFileManager_Load(object sender, EventArgs e)
        {
            Archivo a = new Archivo()
            {
                aprobacion = Archivo.Aprobación.Aprobado,
             area = Archivo.Area.Desarrollo,
             extension = "sdf",
             nombre = "archivo_prueba",
             publico = Archivo.Publico.Externo,
             puestoRevisor = Archivo.Puesto.DirectorDeTecnologíaEImplementación,
             PuestoCreador = Archivo.Puesto.GerenteDeInnovación,
             region = Archivo.Region.Global,
             tipo = Archivo.TipoArchivo.Alcances,
             version = 1
            };
            
            textBox1.Text = new ArchivoDisplay(a).Estructura;
        }
    }
}
