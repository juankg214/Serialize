using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SerializeXML
{
    [XmlRoot(ElementName = "Afiliacion")]
    public class XMLObjectModel
    {
        [XmlElement(ElementName = "Id")]
        public int? Id { get; set; }

        [XmlElement(ElementName = "NumeroAfiliacionApolo")]
        public int? NumeroAfiliacionApolo { get; set; }

        [XmlElement(ElementName = "EstadoVenta")]
        public string EstadoVenta { get; set; }

        [XmlElement(ElementName = "TipoAfiliacion")]
        public string TipoAfiliacion { get; set; }

        [XmlElement(ElementName = "FechaSolicitud")]
        public DateTime? FechaSolicitud { get; set; }

        [XmlElement(ElementName = "TipoContrato")]
        public string TipoContrato { get; set; }

        [XmlElement(ElementName = "FamiliarTipo")]
        public string FamiliarTipo { get; set; }

        [XmlElement(ElementName = "NumeroContrato")]
        public int? NumeroContrato { get; set; }

        [XmlElement(ElementName = "NumeroContratoCambioPlan")]
        public int? NumeroContratoCambioPlan { get; set; }

        [XmlElement(ElementName = "FechaInicioVigencia")]
        public DateTime? FechaInicioVigencia { get; set; }

        [XmlElement(ElementName = "FechaInicioVigenciaAntigua")]
        public DateTime? FechaInicioVigenciaAntigua { get; set; }

        [XmlElement(ElementName = "EsFechaEmpalme")]
        public bool? EsFechaEmpalme { get; set; }

        [XmlElement(ElementName = "FechaFinVigencia")]
        public DateTime? FechaFinVigencia { get; set; }

        [XmlElement(ElementName = "NumeroFUAI")]
        public string NumeroFUAI { get; set; }

        [XmlElement(ElementName = "LiquidacionAfectada")]
        public string LiquidacionAfectada { get; set; }

        [XmlElement(ElementName = "CambioFechaVigencia")]
        public string CambioFechaVigencia { get; set; }

        [XmlElement(ElementName = "FechaFinVenta")]
        public string FechaFinVenta { get; set; }

        [XmlElement(ElementName = "Plan")]
        public PlanObject Plan { get; set; }

        public class PlanObject
        {
            [XmlElement(ElementName = "Codigo")]
            public int? Codigo { get; set; }

            [XmlElement(ElementName = "Nombre")]
            public string Nombre { get; set; }

            [XmlElement(ElementName = "Producto")]
            public ProductoObject Producto { get; set; }

            public class ProductoObject
            {
                [XmlElement(ElementName = "Id")]
                public string Id { get; set; }

                [XmlElement(ElementName = "Nombre")]
                public string Nombre { get; set; }
            }
        }

        [XmlElement(ElementName = "Anexo")]
        public string Anexo { get; set; }

        [XmlElement(ElementName = "Colectivo")]
        public ColectivoObject Colectivo { get; set; }

        public class ColectivoObject
        {
            [XmlElement(ElementName = "Codigo")]
            public string Codigo { get; set; }

            [XmlElement(ElementName = "Nombre")]
            public string Nombre { get; set; }
        }

        [XmlElement(ElementName = "Afiliado")]
        public AfiliadoObject Afiliado { get; set; }

        public class AfiliadoObject
        {
            [XmlElement(ElementName = "Id")]
            public int? Id { get; set; }

            [XmlElement(ElementName = "TipoIdentificacion")]
            public string TipoIdentificacion { get; set; }

            [XmlElement(ElementName = "NumeroIdentificacion")]
            public int? NumeroIdentificacion { get; set; }

            [XmlElement(ElementName = "PrimerNombre")]
            public string PrimerNombre { get; set; }

            [XmlElement(ElementName = "SegundoNombre")]
            public string SegundoNombre { get; set; }

            [XmlElement(ElementName = "PrimerApellido")]
            public string PrimerApellido { get; set; }

            [XmlElement(ElementName = "SegundoApellido")]
            public string SegundoApellido { get; set; }

            [XmlElement(ElementName = "FechaNacimiento")]
            public DateTime? FechaNacimiento { get; set; }

            [XmlElement(ElementName = "Sexo")]
            public string Sexo { get; set; }

            [XmlElement(ElementName = "DireccionResidencia")]
            public DatosDireccionModel DireccionResidencia { get; set; }

            [XmlElement(ElementName = "DireccionCorrespondencia")]
            public DatosDireccionModel DireccionCorrespondencia { get; set; }

            [XmlElement(ElementName = "EsBeneficiario")]
            public bool EsBeneficiario { get; set; }

            [XmlElement(ElementName = "MedicoAdscrito")]
            public bool MedicoAdscrito { get; set; }

            [XmlElement(ElementName = "LecturaCodBarras")]
            public bool LecturaCodBarras { get; set; }
        }

        public class DatosDireccionModel
        {
            [XmlElement(ElementName = "Direccion")]
            public string Direccion { get; set; }

            [XmlElement(ElementName = "Telefono")]
            public string Telefono { get; set; }

            [XmlElement(ElementName = "Ciudad")]
            public CiudadModel Ciudad { get; set; }

            [XmlElement(ElementName = "Mail")]
            public string Mail { get; set; }

            [XmlElement(ElementName = "Celular")]
            public string Celular { get; set; }

            public class CiudadModel
            {
                [XmlElement(ElementName = "IdCiudad")]
                public string IdCiudad { get; set; }

                [XmlElement(ElementName = "NombreCiudad")]
                public string NombreCiudad { get; set; }

                [XmlElement(ElementName = "Departamento")]
                public DepartamentoModel Departamento { get; set; }


                public class DepartamentoModel
                {
                    [XmlElement(ElementName = "IdDepartamento")]
                    public string IdDepartamento { get; set; }

                    [XmlElement(ElementName = "NombreDepartamento")]
                    public string NombreDepartamento { get; set; }
                }

            }

        }

    }

   
}
