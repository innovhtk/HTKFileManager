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
using System.Xml.Serialization;

namespace HTK_FileManager
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {
            DeserializeFromXML();
            cbPuesto.SelectedIndex = Config.index;
            cbArea.Text = Config.Area;
        }

        private void cbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.Puesto = Config.siglasDePuestos[cbPuesto.SelectedIndex];
            Config.index = cbPuesto.SelectedIndex;
            lbSiglas.Text = Config.ClavePuesto;

        }
        public void SerializeToXML(ConfigHelper config)
        {
            try
            {
                config = new ConfigHelper { Puesto = Config.Puesto, siglasDePuestos = Config.siglasDePuestos , index = Config.index, Area = Config.Area};
                XmlSerializer serializer = new XmlSerializer(typeof(ConfigHelper));
                TextWriter textWriter = new StreamWriter(@"config.xml");
                serializer.Serialize(textWriter, config);
                textWriter.Close();
            }
            catch (Exception) { }
        }
        static void DeserializeFromXML()
        {
            try
            {
                ConfigHelper config;
                XmlSerializer deserializer = new XmlSerializer(typeof(ConfigHelper));
                TextReader textReader = new StreamReader(@"config.xml");
                config = (ConfigHelper)deserializer.Deserialize(textReader);
                textReader.Close();
                Config.Puesto = config.Puesto;
                Config.index = config.index;
                Config.Area = config.Area;
            }
            catch (Exception) { }
        }

        private void Configuracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Guardar(object sender, EventArgs e)
        {
            this.Close();
            SerializeToXML(new ConfigHelper { Puesto = Config.Puesto, siglasDePuestos = Config.siglasDePuestos, index = Config.index, Area = Config.Area});
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Config.Area = cbArea.Text;
        }
    }
}
