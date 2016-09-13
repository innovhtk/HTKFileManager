using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;
using HTK_FileManager;

namespace HTK_FileManager
{
    public partial class MainForm : Form
    {
        public string Folder = "";
        public List<string> Files = new List<string>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btPuesto_Click(object sender, EventArgs e)
        {
            Configuracion configForm = new Configuracion();
            configForm.Show();
        }

        private void Folder_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = null;
            List<FileParts> fileParts = new List<FileParts>();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                var column0 = new DataGridViewCheckBoxColumn();
                column0.HeaderText = "Nombrar";
                var column = new DataGridViewComboBoxColumn();
                column.HeaderText = "Público";
                var column1 = new DataGridViewColumn(cell);
                column1.HeaderText = "Área";
                var column2 = new DataGridViewComboBoxColumn();
                column2.HeaderText = "Idioma";
                var column3 = new DataGridViewColumn(cell);
                column3.HeaderText = "Puesto";
                var column4 = new DataGridViewComboBoxColumn();
                column4.HeaderText = "Tipo";
                var column5 = new DataGridViewColumn(cell);
                column5.HeaderText = "Título";
                var column6 = new DataGridViewComboBoxColumn();
                column6.HeaderText = "Aprobación";
                var column7 = new DataGridViewColumn(cell);
                column7.HeaderText = "Versión";
                var column8 = new DataGridViewColumn(cell);
                column8.HeaderText = "Original";

                DataTable publico = new DataTable();
                DataTable area = new DataTable();
                DataTable idioma = new DataTable();
                DataTable puesto = new DataTable();
                DataTable tipo = new DataTable();
                DataTable titulo = new DataTable();
                DataTable aprobacion = new DataTable();
                DataTable version = new DataTable();
                DataTable original = new DataTable();

                publico.Columns.Add(new DataColumn("Value", typeof(string)));
                publico.Rows.Add("Interno");
                publico.Rows.Add("Externo");
                //area.Columns.Add(new DataColumn("Value", typeof(string)));
                //area.Rows.Add("AU");
                //area.Rows.Add("BE");
                //area.Rows.Add("COM");
                //area.Rows.Add("DEV");
                //area.Rows.Add("OP");
                area.Columns.Add(new DataColumn("Value", typeof(string)));
                idioma.Columns.Add(new DataColumn("Value", typeof(string)));
                idioma.Rows.Add("Español");
                idioma.Rows.Add("Inglés");
                idioma.Rows.Add("Alemán");
                idioma.Rows.Add("Francés");
                idioma.Rows.Add("Portugués");
                puesto.Columns.Add(new DataColumn("Value", typeof(string)));
                tipo.Columns.Add(new DataColumn("Value", typeof(string)));

                tipo.Rows.Add("Alcances (SCP)");
                tipo.Rows.Add("Capacitación (CAP)");
                tipo.Rows.Add("Cronograma (CRN)");
                tipo.Rows.Add("DataBase Dictionary (DBD)");
                tipo.Rows.Add("DataSheet (DTS)");
                tipo.Rows.Add("Diagramas (DGRM)");
                tipo.Rows.Add("Esquemáticos (SCH)");
                tipo.Rows.Add("Estándar (STD)");
                tipo.Rows.Add("Excel DataBase (EDB)");
                tipo.Rows.Add("Flujos (FLX)");
                tipo.Rows.Add("Formulario (FRM)");
                tipo.Rows.Add("Imágenes (IM)");
                tipo.Rows.Add("Informativo (INF)");
                tipo.Rows.Add("LayOut (GLAY)");
                tipo.Rows.Add("Layout (LAY)");
                tipo.Rows.Add("Manual (MAN)");
                tipo.Rows.Add("Meeting Scope (MSc)");
                tipo.Rows.Add("Minuta (MIN)");
                tipo.Rows.Add("Modelos3D (3D)");
                tipo.Rows.Add("Política (POL)");
                tipo.Rows.Add("Póliza (PCY)");
                tipo.Rows.Add("Position Contract (PoC)");
                tipo.Rows.Add("Product Breakdown Structure (PBS)");
                tipo.Rows.Add("Project Charter (PCh)");
                tipo.Rows.Add("Reporte de Avances (AREP)");
                tipo.Rows.Add("Request for Employee (RFE)");
                tipo.Rows.Add("Request for Information(RFI)");
                tipo.Rows.Add("Request for Qualifications (RFQ)");
                tipo.Rows.Add("RFQ – JobDescription (RFQ_JD)");
                tipo.Rows.Add("Seguimiento de Actividades (FLW)");
                tipo.Rows.Add("Sistemas y Flujos (SF)");
                tipo.Rows.Add("Support Report (SREP)");
                tipo.Rows.Add("Videos (VID)");
                tipo.Rows.Add("Work Report (WREP)");

                titulo.Columns.Add(new DataColumn("Value", typeof(string)));
                aprobacion.Columns.Add(new DataColumn("Value", typeof(string)));
                aprobacion.Rows.Add("Borrador");
                aprobacion.Rows.Add("Aprobado");
                version.Columns.Add(new DataColumn("Value", typeof(string)));

                column.DataSource = publico;
                column.ValueMember = "Value";
                //column1.DataSource = area;
                //column1.ValueMember = "Value";
                column2.DataSource = idioma;
                column2.ValueMember = "Value";
                column4.DataSource = tipo;
                column4.ValueMember = "Value";
                column6.DataSource = aprobacion;
                column6.ValueMember = "Value";


                DataGridViewCheckBoxColumn doWork = new DataGridViewCheckBoxColumn();
                doWork.HeaderText = "Nombrar";
                doWork.FalseValue = "0";
                doWork.TrueValue = "1";
                dataGridView1.Columns.Insert(0, doWork);

                //dataGridView1.Columns.Add(column0);
                dataGridView1.Columns.Add(column);
                dataGridView1.Columns.Add(column1);
                dataGridView1.Columns.Add(column2);
                dataGridView1.Columns.Add(column3);
                dataGridView1.Columns.Add(column4);
                dataGridView1.Columns.Add(column5);
                dataGridView1.Columns.Add(column6);
                dataGridView1.Columns.Add(column7);
                dataGridView1.Columns.Add(column8);

                Folder = folderBrowserDialog1.SelectedPath + "\\";

                DirectoryInfo directory = new DirectoryInfo(Folder);
                FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

                var filtered = files.Select(f => f)
                                    .Where(f => (f.Attributes & FileAttributes.Hidden) == 0);
                var filtered2 = filtered.Select(g => g)
                    .Where(g => !g.FullName.Contains(@"\.")
                    &&!g.FullName.Contains(".exe")
                    &&!g.FullName.Contains(".deploy")
                    &&!g.FullName.Contains(".csproj")
                    &&!g.FullName.Contains(".sln")
                    &&!g.FullName.Contains(".cs")
                    &&!g.FullName.Contains(".user")
                    &&!g.FullName.Contains(".pfx")
                    &&!g.FullName.Contains(".resx")
                    &&!g.FullName.Contains(".application")
                    &&!g.FullName.Contains(".config")
                    &&!g.FullName.Contains(".manifest")
                    &&!g.FullName.Contains(".pdb")
                    && !g.FullName.Contains(".sdf")
                    && !g.FullName.Contains(".cd")
                    && !g.FullName.Contains(".sql")
                    && !g.FullName.Contains(".asmx")
                    && !g.FullName.Contains(".vbproj")
                    && !g.FullName.Contains(".dll")
                    );

                Files = new List<string>();
                foreach (var f in filtered2)
                {
                    if (!f.FullName.Contains("I-") && !f.FullName.Contains("O-"))
                    {
                        Files.Add(f.FullName);
                    }
                    else if (!f.FullName.Contains("G."))
                    {
                        Files.Add(f.FullName);
                    }
                }

                Files = Files.OrderBy(x => x).ToList();

                foreach (string file in Files)
                {
                    string[] dirparts = file.Split('\\');
                    string Titulo = dirparts[dirparts.Length - 1];
                    if (Titulo.Contains("I-")||Titulo.Contains("O-"))
                    {
                        string ex = Titulo.Split('.')[Titulo.Split('.').Length - 1];
                        Titulo = Titulo.Split('-')[Titulo.Split('-').Length - 2] + "." + ex;   
                    }
                    //Titulo = UppercaseWords(Titulo.ToLowerInvariant());
                    dataGridView1.Rows.Add
                        (
                            0,
                            "Interno",
                            Config.Area,
                            "Español",
                            Config.ClavePuesto,
                            "Informativo (INF)",
                            Titulo,
                            "Borrador",
                            1,
                            file
                        );
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Folder != null && Folder != "")
            {
                if (checkBox1.Checked)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                        row.Cells[0].Value = true;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = false;
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                        row.Cells[0].Value = false;

                }
            }

        }
        static string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();
            // Handle the first letter in the string.
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            // Scan through the letters, checking for spaces.
            // ... Uppercase the lowercase letters following spaces.
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        private void Minusculas(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == 1)
                {
                    try
                    {
                        File.Move(Folder + row.Cells[6].Value.ToString(), Folder + row.Cells[6].Value.ToString().ToLowerInvariant().Replace(" - ", "_").Replace('-', '_').Replace(' ', '_'));
                        row.Cells[6].Value = row.Cells[6].Value.ToString().ToLowerInvariant().Replace(" - ", "_").Replace('-', '_').Replace(' ', '_');
                    }
                    catch (Exception) { }
                }
                
            }
        }

        private void btMayusculas_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == 1)
                {
                    try
                    {
                        File.Move(Folder + row.Cells[6].Value.ToString(), Folder + UppercaseWords(row.Cells[6].Value.ToString().ToLowerInvariant().Replace(" - ", "_").Replace('-', '_').Replace(' ', '_')));
                        row.Cells[6].Value = UppercaseWords(row.Cells[6].Value.ToString().ToLowerInvariant().Replace(" - ", "_").Replace('-', '_').Replace(' ', '_'));
                    }
                    catch (Exception) { } 
                }
                
            }
        }

        private void Nombrar(object sender, EventArgs e)
        {
            int total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == 1)
                {
                    total++;
                }
            }
            int real = total;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                string nombreCompleto = "";
                try
                {
                    if (Convert.ToInt32(row.Cells[0].Value) == 1)
                    {
                        if (row.Cells[1].Value.ToString() == "Interno")
                            nombreCompleto += "I-";
                        else
                            nombreCompleto += "O-";

                        nombreCompleto += row.Cells[2].Value.ToString();//Area

                        switch (row.Cells[3].Value.ToString())
                        {
                            case "Español":
                                nombreCompleto += "s-";
                                break;
                            case "Inglés":
                                nombreCompleto += "e-";
                                break;
                            case "Alemán":
                                nombreCompleto += "g-";
                                break;
                            case "Portugués":
                                nombreCompleto += "p-";
                                break;
                            case "Francés":
                                nombreCompleto += "f-";
                                break;
                        }
                        nombreCompleto += row.Cells[4].Value.ToString() + "-";//Puesto
                        nombreCompleto += Regex.Match(row.Cells[5].Value.ToString(), @"\(([^)]*)\)").Groups[1].Value + "-";
                        string[] nombrearchivo = row.Cells[6].Value.ToString().Split('.');
                        string n = "";
                        string extension = "";
                        if (nombrearchivo.Length > 2)
                        {
                            for (int i = 0; i < nombrearchivo.Length - 2; i++)
                            {
                                n += nombrearchivo[i];
                            }
                        }
                        else
                        {
                            n = nombrearchivo[0];
                        }
                        extension = nombrearchivo[nombrearchivo.Length - 1];
                        nombreCompleto += n + "-";
                        nombreCompleto += row.Cells[7].Value.ToString() == "Borrador" ? "A" : "B";
                        nombreCompleto += row.Cells[8].Value.ToString();
                        nombreCompleto += "." + extension;
                        string original = row.Cells[row.Cells.Count - 1].Value.ToString();
                        string ffolder = "";
                        string[] parts = original.Split('\\');
                        for (int i = 0; i < original.Split('\\').Length - 1; i++)
                        {
                            ffolder += parts[i] +"\\";
                        }
                        try
                        {
                            File.Move(original, ffolder + nombreCompleto);
                            dataGridView1.Rows.Remove(row);
                        }
                        catch (Exception)
                        {
                        }
                        
                    }
                }
                catch (Exception) { real--; }

            }
            MessageBox.Show("Se han nombrado " + real.ToString() + " archivo(s) de " + total.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToInt32(row.Cells[0].Value) == 1)
                {
                    try
                    {
                        File.Move(Folder + row.Cells[6].Value.ToString(), Folder + row.Cells[6].Value.ToString().ToUpperInvariant().Replace(" - ", "_").Replace('-', '_').Replace(' ', '_'));
                        row.Cells[6].Value = row.Cells[6].Value.ToString().ToUpperInvariant().Replace(" - ", "_").Replace('-', '_').Replace(' ', '_');
                    }
                    catch (Exception) { }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //var renamer = new HTK_FileRenamer.MainForm();
            //renamer.Show();
        }

        private void Main_ResizeEnd(object sender, EventArgs e)
        {
            dataGridView1.Height = this.Height - 157;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
                dataGridView1.Height = this.Height - 157;
            if (this.WindowState == FormWindowState.Maximized)
            {
                dataGridView1.Height = this.Height - 157;
            }
            base.OnSizeChanged(e);
        }


    }
}
