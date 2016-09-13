
using System.Collections.Generic;
namespace HTK_FileManager
{
    public class Archivo
    {
        public enum Publico
        {
            Interno,
            Externo
        }
        public enum Area
        {
            Auditoría,
            Bussines,
            Comercial,
            Desarrollo

        }
        public enum Idioma
        {
            Español,
            Inglés,
            Francés,
            Alemán,
            Portugés
        }
        public enum Puesto
        {
            DirectorGeneral,
            AsistenteDeDirector,
            GerenteDeAuditoría,
            EjecutivoDeAuditoría,
            DirectorDeVentasYMercadotecnia,
            GerenteEspecializadoDeSoluciones,
            EjecutivoEspecializadoDeServicioYAtención,
            EjecutivoEspecializadoDeSoluciones,
            GerenteDeMercadotecnia,
            CoordinadorEspecilizadoDeMediosYMarca,
            CoordinadorEspecializadoDeTranquilidad,
            GerenteDeComercioInternacionalEspecializadoDeSoluciones,
            AsistenteInternacionalEspecializadoDeSoluciones,
            DirectorDeOperaciones,
            GerenteDeLegal,
            EjecutivoDeLegal,
            GerenteDeFinanzas,
            EjecutivoDeContabilidad,
            EjecutivoDeCréditoYCuentas,
            GerenteDeAdministración,
            EjecutivoDeComprasYAlmacén,
            EjecutivoDeRecursosHumanos,
            DirectorDeTecnologíaEImplementación,
            GerenteDeImplementación,
            LíderDeImplementaciónEspecializada,
            LíderDeSoporteYTranquilidad,
            GerenteDeInnovación,
            LíderDeInnovación,
            LíderDeSoftwareYDatos,
            GerenteDeTI,
            LíderDeTI
        }
        public enum Region
        {
            Global,
            México
        }
        public enum TipoArchivo
        {
            Alcances,
            Capacitación,
            Cronograma,
            DataBaseDictionary,
            DataSheet,
            Diagramas,
            Esquemáticos,
            Estándar,
            ExcelDataBase,
            Flujos,
            Formulario,
            Imágenes,
            Informativo,
            LayOut,
            Layout,
            Manual,
            MeetingScope,
            Minuta,
            Modelo3D,
            Política,
            Póliza,
            PositionContract,
            Presentación,
            ProductBreakdownStructure,
            ProjectCharter,
            Proposal,
            ReporteAvances,
            RequestForEmployee,
            RequestForInformation,
            RequestForQualifications,
            Research,
            RFQ_JobDescription,
            Scan,
            SeguimientoDeActividades,
            SistemasYFlujos,
            SupportReport,
            Video,
            WorkReport
        }
        public enum Aprobación
        {
            Borrador,
            Aprobado
        }

        public Publico publico { get; set; }
        public Area area { get; set; }
        public Idioma idioma { get; set; }
        public Puesto puestoRevisor { get; set; }
        public Region region { get; set; }
        public Puesto PuestoCreador { get; set; }
        public TipoArchivo tipo { get; set; }
        public string nombre { get; set; }
        public Aprobación aprobacion { get; set; }
        public int version { get; set; }
        public string extension { get; set; }

    }
    public class ArchivoDisplay
    {
        public string Publico { get; set; }
        public string Area { get; set; }
        public string Idioma { get; set; }
        public string PuestoRevisor { get; set; }
        public string Region { get; set; }
        public string PuestoCreador { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Aprobacion { get; set; }
        public string Version { get; set; }
        public string Dir { get; set; }
        private string extension = "";
        public string Extension
        {
            get
            {
                return extension;
            }
            set
            {
                if (value.Contains("."))
                {
                    extension = value.Split('.')[1];
                }
                else
                {
                    extension = value;
                }
            }
        }
        private List<string> InicialesPuestos = new List<string>
        {
            "CEO",
            "CEO.ACEO",
            "GAU",
            "GAU.EAU",
            "CEO.DVM",
            "DVM.GES",
            "GES.EESA",
            "GES.EES",
            "DVM.GM",
            "GM.CEMM",
            "GM.CET",
            "DVM.GCIES",
            "GCIES.AIES",
            "CEO.DOP",
            "DOP.GL",
            "GL.EL",
            "DOP.GF",
            "GF.EC",
            "GF.ECC",
            "DOP.GA",
            "GA.ECA",
            "GA.ERH",
            "CEO.DTI",
            "DTI.GIM",
            "GIM.LIE",
            "GIM.LST",
            "DTI.GIN",
            "GIN.LI",
            "GIN.LSD",
            "DTI.GTI",
            "GTI.LTI"
        };
        public ArchivoDisplay(Archivo archivo)
        {
            switch (archivo.publico)
            {
                case Archivo.Publico.Interno:
                    Publico = "I";
                    break;
                case Archivo.Publico.Externo:
                    Publico = "O";
                    break;
                default:
                    break;
            }
            switch (archivo.area)
            {
                case Archivo.Area.Auditoría:
                    Area = "AU";
                    break;
                case Archivo.Area.Bussines:
                    Area = "BE";
                    break;
                case Archivo.Area.Comercial:
                    Area = "COM";
                    break;
                case Archivo.Area.Desarrollo:
                    Area = "DEV";
                    break;
                default:
                    break;
            }
            switch (archivo.idioma)
            {
                case Archivo.Idioma.Español:
                    Idioma = "s";
                    break;
                case Archivo.Idioma.Inglés:
                    Idioma = "e";
                    break;
                case Archivo.Idioma.Francés:
                    Idioma = "f";
                    break;
                case Archivo.Idioma.Alemán:
                    Idioma = "g";
                    break;
                case Archivo.Idioma.Portugés:
                    Idioma = "p";
                    break;
                default:
                    break;
            }
            #region revisor-prueba
            //switch (archivo.puestoRevisor)
            //{
            //    case Archivo.Puesto.DirectorGeneral:
            //        PuestoRevisor = InicialesPuestos[0];
            //        break;
            //    case Archivo.Puesto.AsistenteDeDirector:
            //        PuestoRevisor = InicialesPuestos[1];
            //        break;
            //    case Archivo.Puesto.GerenteDeAuditoría:
            //        PuestoRevisor = InicialesPuestos[2];
            //        break;
            //    case Archivo.Puesto.EjecutivoDeAuditoría:
            //        PuestoRevisor = InicialesPuestos[3];
            //        break;
            //    case Archivo.Puesto.DirectorDeVentasYMercadotecnia:
            //        PuestoRevisor = InicialesPuestos[4];
            //        break;
            //    case Archivo.Puesto.GerenteEspecializadoDeSoluciones:
            //        PuestoRevisor = InicialesPuestos[5];
            //        break;
            //    case Archivo.Puesto.EjecutivoEspecializadoDeServicioYAtención:
            //        PuestoRevisor = InicialesPuestos[6];
            //        break;
            //    case Archivo.Puesto.EjecutivoEspecializadoDeSoluciones:
            //        PuestoRevisor = InicialesPuestos[7];
            //        break;
            //    case Archivo.Puesto.GerenteDeMercadotecnia:
            //        PuestoRevisor = InicialesPuestos[8];
            //        break;
            //    case Archivo.Puesto.CoordinadorEspecilizadoDeMediosYMarca:
            //        PuestoRevisor = InicialesPuestos[9];
            //        break;
            //    case Archivo.Puesto.CoordinadorEspecializadoDeTranquilidad:
            //        PuestoRevisor = InicialesPuestos[10];
            //        break;
            //    case Archivo.Puesto.GerenteDeComercioInternacionalEspecializadoDeSoluciones:
            //        PuestoRevisor = InicialesPuestos[11];
            //        break;
            //    case Archivo.Puesto.AsistenteInternacionalEspecializadoDeSoluciones:
            //        PuestoRevisor = InicialesPuestos[12];
            //        break;
            //    case Archivo.Puesto.DirectorDeOperaciones:
            //        PuestoRevisor = InicialesPuestos[13];
            //        break;
            //    case Archivo.Puesto.GerenteDeLegal:
            //        PuestoRevisor = InicialesPuestos[14];
            //        break;
            //    case Archivo.Puesto.EjecutivoDeLegal:
            //        PuestoRevisor = InicialesPuestos[15];
            //        break;
            //    case Archivo.Puesto.GerenteDeFinanzas:
            //        PuestoRevisor = InicialesPuestos[16];
            //        break;
            //    case Archivo.Puesto.EjecutivoDeContabilidad:
            //        PuestoRevisor = InicialesPuestos[17];
            //        break;
            //    case Archivo.Puesto.EjecutivoDeCréditoYCuentas:
            //        PuestoRevisor = InicialesPuestos[18];
            //        break;
            //    case Archivo.Puesto.GerenteDeAdministración:
            //        PuestoRevisor = InicialesPuestos[19];
            //        break;
            //    case Archivo.Puesto.EjecutivoDeComprasYAlmacén:
            //        PuestoRevisor = InicialesPuestos[20];
            //        break;
            //    case Archivo.Puesto.EjecutivoDeRecursosHumanos:
            //        PuestoRevisor = InicialesPuestos[21];
            //        break;
            //    case Archivo.Puesto.DirectorDeTecnologíaEImplementación:
            //        PuestoRevisor = InicialesPuestos[22];
            //        break;
            //    case Archivo.Puesto.GerenteDeImplementación:
            //        PuestoRevisor = InicialesPuestos[23];
            //        break;
            //    case Archivo.Puesto.LíderDeImplementaciónEspecializada:
            //        PuestoRevisor = InicialesPuestos[24];
            //        break;
            //    case Archivo.Puesto.LíderDeSoporteYTranquilidad:
            //        PuestoRevisor = InicialesPuestos[25];
            //        break;
            //    case Archivo.Puesto.GerenteDeInnovación:
            //        PuestoRevisor = InicialesPuestos[26];
            //        break;
            //    case Archivo.Puesto.LíderDeInnovación:
            //        PuestoRevisor = InicialesPuestos[27];
            //        break;
            //    case Archivo.Puesto.LíderDeSoftwareYDatos:
            //        PuestoRevisor = InicialesPuestos[28];
            //        break;
            //    case Archivo.Puesto.GerenteDeTI:
            //        PuestoRevisor = InicialesPuestos[29];
            //        break;
            //    case Archivo.Puesto.LíderDeTI:
            //        PuestoRevisor = InicialesPuestos[30];
            //        break;
            //    default:
            //        break;
            //}
            #endregion
            switch (archivo.region)
            {
                case Archivo.Region.Global:
                    Region = "G";
                    break;
                case Archivo.Region.México:
                    Region = "M";
                    break;
                default:
                    break;
            }
            switch (archivo.PuestoCreador)
            {
                case Archivo.Puesto.DirectorGeneral:
                    PuestoCreador = InicialesPuestos[0].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[0].Split('.')[0];
                    break;
                case Archivo.Puesto.AsistenteDeDirector:
                    PuestoCreador = InicialesPuestos[1].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[1].Split('.')[0];
                    break;
                case Archivo.Puesto.GerenteDeAuditoría:
                    PuestoCreador = InicialesPuestos[2].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[2].Split('.')[0];
                    break;
                case Archivo.Puesto.EjecutivoDeAuditoría:
                    PuestoCreador = InicialesPuestos[3].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[3].Split('.')[0];
                    break;
                case Archivo.Puesto.DirectorDeVentasYMercadotecnia:
                    PuestoCreador = InicialesPuestos[4].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[4].Split('.')[0];
                    break;
                case Archivo.Puesto.GerenteEspecializadoDeSoluciones:
                    PuestoCreador = InicialesPuestos[5].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[5].Split('.')[0];
                    break;
                case Archivo.Puesto.EjecutivoEspecializadoDeServicioYAtención:
                    PuestoCreador = InicialesPuestos[6].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[6].Split('.')[0];
                    break;
                case Archivo.Puesto.EjecutivoEspecializadoDeSoluciones:
                    PuestoCreador = InicialesPuestos[7].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[7].Split('.')[0];
                    break;
                case Archivo.Puesto.GerenteDeMercadotecnia:
                    PuestoCreador = InicialesPuestos[8].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[8].Split('.')[0];
                    break;
                case Archivo.Puesto.CoordinadorEspecilizadoDeMediosYMarca:
                    PuestoCreador = InicialesPuestos[9].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[9].Split('.')[0];
                    break;
                case Archivo.Puesto.CoordinadorEspecializadoDeTranquilidad:
                    PuestoCreador = InicialesPuestos[10].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[10].Split('.')[0];
                    break;
                case Archivo.Puesto.GerenteDeComercioInternacionalEspecializadoDeSoluciones:
                    PuestoCreador = InicialesPuestos[11].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[11].Split('.')[0];
                    break;
                case Archivo.Puesto.AsistenteInternacionalEspecializadoDeSoluciones:
                    PuestoCreador = InicialesPuestos[12].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[12].Split('.')[0];
                    break;
                case Archivo.Puesto.DirectorDeOperaciones:
                    PuestoCreador = InicialesPuestos[13].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[13].Split('.')[0];
                    break;
                case Archivo.Puesto.GerenteDeLegal:
                    PuestoCreador = InicialesPuestos[14].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[14].Split('.')[0];
                    break;
                case Archivo.Puesto.EjecutivoDeLegal:
                    PuestoCreador = InicialesPuestos[15].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[15].Split('.')[0];
                    break;
                case Archivo.Puesto.GerenteDeFinanzas:
                    PuestoCreador = InicialesPuestos[16].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[16].Split('.')[0];
                    break;
                case Archivo.Puesto.EjecutivoDeContabilidad:
                    PuestoCreador = InicialesPuestos[17].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[17].Split('.')[0];
                    break;
                case Archivo.Puesto.EjecutivoDeCréditoYCuentas:
                    PuestoCreador = InicialesPuestos[18].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[18].Split('.')[0];
                    break;
                case Archivo.Puesto.GerenteDeAdministración:
                    PuestoCreador = InicialesPuestos[19].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[19].Split('.')[0];
                    break;
                case Archivo.Puesto.EjecutivoDeComprasYAlmacén:
                    PuestoCreador = InicialesPuestos[20].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[20].Split('.')[0];
                    break;
                case Archivo.Puesto.EjecutivoDeRecursosHumanos:
                    PuestoCreador = InicialesPuestos[21].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[21].Split('.')[0];
                    break;
                case Archivo.Puesto.DirectorDeTecnologíaEImplementación:
                    PuestoCreador = InicialesPuestos[22].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[22].Split('.')[0];
                    break;
                case Archivo.Puesto.GerenteDeImplementación:
                    PuestoCreador = InicialesPuestos[23].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[23].Split('.')[0];
                    break;
                case Archivo.Puesto.LíderDeImplementaciónEspecializada:
                    PuestoCreador = InicialesPuestos[24].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[24].Split('.')[0];
                    break;
                case Archivo.Puesto.LíderDeSoporteYTranquilidad:
                    PuestoCreador = InicialesPuestos[25].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[25].Split('.')[0];
                    break;
                case Archivo.Puesto.GerenteDeInnovación:
                    PuestoCreador = InicialesPuestos[26].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[26].Split('.')[0];
                    break;
                case Archivo.Puesto.LíderDeInnovación:
                    PuestoCreador = InicialesPuestos[27].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[27].Split('.')[0];
                    break;
                case Archivo.Puesto.LíderDeSoftwareYDatos:
                    PuestoCreador = InicialesPuestos[28].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[28].Split('.')[0];
                    break;
                case Archivo.Puesto.GerenteDeTI:
                    PuestoCreador = InicialesPuestos[29].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[29].Split('.')[0];
                    break;
                case Archivo.Puesto.LíderDeTI:
                    PuestoCreador = InicialesPuestos[30].Split('.')[1];
                    PuestoRevisor = InicialesPuestos[30].Split('.')[0];
                    break;
                default:
                    break;
            }
            switch (archivo.tipo)
            {
                case Archivo.TipoArchivo.Alcances:
                    Tipo = "SCP";
                    break;
                case Archivo.TipoArchivo.Capacitación:
                    Tipo = "CAP";
                    break;
                case Archivo.TipoArchivo.Cronograma:
                    Tipo = "CRN";
                    break;
                case Archivo.TipoArchivo.DataBaseDictionary:
                    Tipo = "DBD";
                    break;
                case Archivo.TipoArchivo.DataSheet:
                    Tipo = "DTS";
                    break;
                case Archivo.TipoArchivo.Diagramas:
                    Tipo = "DGRM";
                    break;
                case Archivo.TipoArchivo.Esquemáticos:
                    Tipo = "SCH";
                    break;
                case Archivo.TipoArchivo.Estándar:
                    Tipo = "STD";
                    break;
                case Archivo.TipoArchivo.ExcelDataBase:
                    Tipo = "EDB";
                    break;
                case Archivo.TipoArchivo.Flujos:
                    Tipo = "FLX";
                    break;
                case Archivo.TipoArchivo.Formulario:
                    Tipo = "FRM";
                    break;
                case Archivo.TipoArchivo.Imágenes:
                    Tipo = "IM";
                    break;
                case Archivo.TipoArchivo.Informativo:
                    Tipo = "INF";
                    break;
                case Archivo.TipoArchivo.LayOut:
                    Tipo = "GLAY";
                    break;
                case Archivo.TipoArchivo.Layout:
                    Tipo = "LAY";
                    break;
                case Archivo.TipoArchivo.Manual:
                    Tipo = "MAN";
                    break;
                case Archivo.TipoArchivo.MeetingScope:
                    Tipo = "MSc";
                    break;
                case Archivo.TipoArchivo.Minuta:
                    Tipo = "MIN";
                    break;
                case Archivo.TipoArchivo.Modelo3D:
                    Tipo = "3D";
                    break;
                case Archivo.TipoArchivo.Política:
                    Tipo = "POL";
                    break;
                case Archivo.TipoArchivo.Póliza:
                    Tipo = "PCY";
                    break;
                case Archivo.TipoArchivo.PositionContract:
                    Tipo = "PoC";
                    break;
                case Archivo.TipoArchivo.Presentación:
                    Tipo = "PRE";
                    break;
                case Archivo.TipoArchivo.ProductBreakdownStructure:
                    Tipo = "PBS";
                    break;
                case Archivo.TipoArchivo.ProjectCharter:
                    Tipo = "PCh";
                    break;
                case Archivo.TipoArchivo.ReporteAvances:
                    Tipo = "AREP";
                    break;
                case Archivo.TipoArchivo.RequestForEmployee:
                    Tipo = "RFE";
                    break;
                case Archivo.TipoArchivo.RequestForInformation:
                    Tipo = "RFI";
                    break;
                case Archivo.TipoArchivo.RequestForQualifications:
                    Tipo = "RFQ";
                    break;
                case Archivo.TipoArchivo.Research:
                    Tipo = "RES";
                    break;
                case Archivo.TipoArchivo.RFQ_JobDescription:
                    Tipo = "RFQ_JD";
                    break;
                case Archivo.TipoArchivo.Scan:
                    Tipo = "SCN";
                    break;
                case Archivo.TipoArchivo.SeguimientoDeActividades:
                    Tipo = "FLW";
                    break;
                case Archivo.TipoArchivo.SistemasYFlujos:
                    Tipo = "SF";
                    break;
                case Archivo.TipoArchivo.SupportReport:
                    Tipo = "SREP";
                    break;
                case Archivo.TipoArchivo.Video:
                    Tipo = "VID";
                    break;
                case Archivo.TipoArchivo.WorkReport:
                    Tipo = "WREP";
                    break;
                case Archivo.TipoArchivo.Proposal:
                    Tipo = "PROP";
                    break;
                default:
                    break;
            }
            Nombre = archivo.nombre;
            switch (archivo.aprobacion)
            {
                case Archivo.Aprobación.Borrador:
                    Aprobacion = "A";
                    break;
                case Archivo.Aprobación.Aprobado:
                    Aprobacion = "B";
                    break;
                default:
                    break;
            }
            Version = archivo.version.ToString();
        }
        public string Estructura
        {
            get
            {
                return Publico + "-" + Area + Idioma + "-" + PuestoRevisor + Region + "." + PuestoCreador + "-" + Tipo + "-" + Nombre + "-" + Aprobacion + Version + "." + Extension;
            }
        }
    }
}
