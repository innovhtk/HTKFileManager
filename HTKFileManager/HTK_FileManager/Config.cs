using System.Collections.Generic;

namespace HTK_FileManager
{
    public static class Config
    {
        public static List<string> siglasDePuestos = new List<string>
        {
            "CEO.ACEO",
            "GCIES.AIES",
            "GM.CET",
            "GM.CEMM",
            "CEO.DOP",
            "CEO.DTI",
            "CEO.DVM",
            "CEO",
            "GAU.EAU",
            "GA.ECA",
            "GF.EC",
            "GF.ECC",
            "GL.EL",
            "GA.ERH",
            "GES.EESA",
            "GES.EES",
            "GES.EES",
            "GES.EES",
            "DOP.GA",
            "GAU",
            "DVM.GCIES",
            "DOP.GF",
            "DTI.GIM",
            "DTI.GIN",
            "DOP.GL",
            "DVM.GM",
            "DTI.GTI",
            "DVM.GES",
            "GIM.LIE",
            "GIM.LIE",
            "GIN.LI",
            "GIN.LSD",
            "GIM.LST",
            "GTI.LTI"
        };
        private static string puesto = "";

        public static string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        
        public static string ClavePuesto 
        { 
            get
            {
                string[] puestoPartes = Puesto.Contains(".")? Puesto.Split('.'): new string[]{Puesto,""};
                return  puestoPartes[1] != "" ? puestoPartes[0] + "G." + puestoPartes[1] : puestoPartes[0] + "G";
            }
        }
        private static string area = "";

        public static string Area
        {
            get { return area; }
            set { area = value; }
        }
        
        public static int index = 0;
    }
    public class ConfigHelper
    {
        public List<string> siglasDePuestos = new List<string>();
        private string puesto = "";
        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public string Area { get; set; }
        public int index = 0;
    }

}
