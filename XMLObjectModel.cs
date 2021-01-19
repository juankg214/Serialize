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
        public string Id { get; set; }

        [XmlElement(ElementName = "NumeroAfiliacionApolo")]
        public string NumeroAfiliacionApolo { get; set; }

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
        public string NumeroContrato { get; set; }

        [XmlElement(ElementName = "NumeroContratoCambioPlan")]
        public string NumeroContratoCambioPlan { get; set; }

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
        public DateTime? FechaFinVenta { get; set; }

        [XmlElement(ElementName = "Plan")]
        public PlanObject Plan { get; set; }

        public class PlanObject
        {
            [XmlElement(ElementName = "Codigo")]
            public string Codigo { get; set; }

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

        [XmlElement(ElementName = "CantidadBeneficiarios")]
        public string CantidadBeneficiarios { get; set; }

        [XmlArray("Beneficiarios")]
        [XmlArrayItem("Beneficiario")]
        public List<BeneficariosModel> Beneficiarios = new List<BeneficariosModel>();

        [XmlElement(ElementName = "AdicionalMaternidad")]
        public bool? AdicionalMaternidad { get; set; }

        [XmlElement(ElementName = "CoberturaMaternidad")]
        public CoberturaAdicionalModel CoberturaMaternidad { get; set; }

        [XmlElement(ElementName = "Liquidacion")]
        public LiquidacionModel Liquidacion { get; set; }

        [XmlElement(ElementName = "Asesor")]
        public AsesorModel Asesor { get; set; }

        [XmlElement(ElementName = "Nombre")]
        public string Nombre { get; set; }

        [XmlElement(ElementName = "CantidadDocumentos")]
        public string CantidadDocumentos { get; set; }

        [XmlElement(ElementName = "UtilizarDatosContacto")]
        public bool? UtilizarDatosContacto { get; set; }

        [XmlElement(ElementName = "CompartirDatosContacto")]
        public bool? CompartirDatosContacto { get; set; }

        [XmlElement(ElementName = "InformadoTratamientoDatos")]
        public bool? InformadoTratamientoDatos { get; set; }

        [XmlElement(ElementName = "MensajeAlerta")]
        public string MensajeAlerta { get; set; }

        [XmlElement(ElementName = "EstadoProceso")]
        public string EstadoProceso { get; set; }

        [XmlElement(ElementName = "ContratoImportado")]
        public bool? ContratoImportado { get; set; }

        [XmlElement(ElementName = "RechazoVigencia")]
        public string RechazoVigencia { get; set; }

        [XmlElement(ElementName = "ReconsRechazoVigencia")]
        public string ReconsRechazoVigencia { get; set; }

        [XmlElement(ElementName = "RechazoPlan")]
        public string RechazoPlan { get; set; }

        [XmlElement(ElementName = "TipoPreAprobacion")]
        public string TipoPreAprobacion { get; set; }

        [XmlElement(ElementName = "EstadoPreAprobacion")]
        public string EstadoPreAprobacion { get; set; }

        [XmlElement(ElementName = "FechaPreAprobacion")]
        public string FechaPreAprobacion { get; set; }

        [XmlElement(ElementName = "Editada")]
        public bool? Editada { get; set; }

        [XmlElement(ElementName = "MotivoFueraLinea")]
        public string MotivoFueraLinea { get; set; }

        [XmlElement(ElementName = "InclusionCambioPlan")]
        public string InclusionCambioPlan { get; set; }

        [XmlElement(ElementName = "NuevoEstadoSaludEsmeraldaAmbu")]
        public string NuevoEstadoSaludEsmeraldaAmbu { get; set; }

        [XmlElement(ElementName = "UtilizarCorreo")]
        public string UtilizarCorreo { get; set; }

        [XmlElement(ElementName = "CopiaHistoriaClinica")]
        public string CopiaHistoriaClinica { get; set; }

        [XmlElement(ElementName = "FueraLineaInico")]
        public string FueraLineaInico { get; set; }

        [XmlElement(ElementName = "FueraLineaConexion")]
        public string FueraLineaConexion { get; set; }

        [XmlArray("Documentos")]
        [XmlArrayItem("DocumentoAfiliacion")]
        public List<DocumentosModel> Documentos = new List<DocumentosModel>();

        public class AfiliadoObject
        {
            [XmlElement(ElementName = "Id")]
            public string Id { get; set; }

            [XmlElement(ElementName = "TipoIdentificacion")]
            public string TipoIdentificacion { get; set; }

            [XmlElement(ElementName = "NumeroIdentificacion")]
            public string NumeroIdentificacion { get; set; }

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
            public bool? EsBeneficiario { get; set; }

            [XmlElement(ElementName = "MedicoAdscrito")]
            public bool? MedicoAdscrito { get; set; }

            [XmlElement(ElementName = "LecturaCodBarras")]
            public bool? LecturaCodBarras { get; set; }


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

        public class BeneficariosModel
        {
            [XmlElement(ElementName = "Id")]
            public string Id { get; set; }

            [XmlElement(ElementName = "TipoIdentificacion")]
            public string TipoIdentificacion { get; set; }

            [XmlElement(ElementName = "NumeroIdentificacion")]
            public string NumeroIdentificacion { get; set; }

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

            [XmlElement(ElementName = "BebeColmedica")]
            public bool? BebeColmedica { get; set; }

            [XmlElement(ElementName = "Parentesco")]
            public ParentescoModel Parentesco { get; set; }

            [XmlElement(ElementName = "EstadoCivil")]
            public EstadoCivilModel EstadoCivil { get; set; }

            [XmlElement(ElementName = "DireccionResidencia")]
            public DatosDireccionModel DireccionResidencia { get; set; }

            [XmlElement(ElementName = "CiaPASAnterior")]
            public CiaPASAnteriorModel CiaPASAnterior { get; set; }

            [XmlElement(ElementName = "ExamenAdmision")]
            public bool? ExamenAdmision { get; set; }

            [XmlElement(ElementName = "EpsActual")]
            public string EpsActual { get; set; }

            [XmlElement(ElementName = "ValorPlenoMes")]
            public string ValorPlenoMes { get; set; }

            [XmlElement(ElementName = "ValorNetoMes")]
            public string ValorNetoMes { get; set; }

            [XmlElement(ElementName = "BeneficiarioNuevo")]
            public bool? BeneficiarioNuevo { get; set; }

            [XmlElement(ElementName = "BenefOtroPlanPrepagada")]
            public bool? BenefOtroPlanPrepagada { get; set; }

            [XmlElement(ElementName = "NumeroContratoSolicitud")]
            public string NumeroContratoSolicitud { get; set; }

            [XmlElement(ElementName = "LecturaCodBarras")]
            public bool? LecturaCodBarras { get; set; }

            [XmlElement(ElementName = "Consecutivo")]
            public string Consecutivo { get; set; }

            [XmlElement(ElementName = "InfoCompleta")]
            public bool? InfoCompleta { get; set; }

            public class ParentescoModel
            {
                [XmlElement(ElementName = "Id")]
                public string Id { get; set; }

                [XmlElement(ElementName = "Nombre")]
                public string Nombre { get; set; }
            }

            public class EstadoCivilModel
            {
                [XmlElement(ElementName = "Id")]
                public string Id { get; set; }

                [XmlElement(ElementName = "Nombre")]
                public string Nombre { get; set; }
            }

            public class CiaPASAnteriorModel
            {
                [XmlElement(ElementName = "Id")]
                public string Id { get; set; }

                [XmlElement(ElementName = "Codigo")]
                public string Codigo { get; set; }

                [XmlElement(ElementName = "FechaDesde")]
                public DateTime? FechaDesde { get; set; }

                [XmlElement(ElementName = "FechaHasta")]
                public DateTime? FechaHasta { get; set; }

                [XmlElement(ElementName = "BeneficioBebeColmedica")]
                public bool? BeneficioBebeColmedica { get; set; }

                [XmlElement(ElementName = "CertificadoAntiguedad")]
                public bool? CertificadoAntiguedad { get; set; }

                [XmlElement(ElementName = "VieneOtraMedPre")]
                public bool? VieneOtraMedPre { get; set; }
            }

        }

        public class CoberturaAdicionalModel
        {
            [XmlElement(ElementName = "IdMaternidad")]
            public string IdMaternidad { get; set; }

            [XmlElement(ElementName = "Identificaicon")]
            public string Identificaicon { get; set; }

            [XmlElement(ElementName = "FUR")]
            public DateTime? FUR { get; set; }

            [XmlElement(ElementName = "ValorCoberturaSinIva")]
            public string ValorCoberturaSinIva { get; set; }

            [XmlElement(ElementName = "ValorCoberturaConIva")]
            public string ValorCoberturaConIva { get; set; }

            [XmlElement(ElementName = "ValorCuota")]
            public string ValorCuota { get; set; }

            [XmlElement(ElementName = "NumeroMaximoCuotas")]
            public string NumeroMaximoCuotas { get; set; }

            [XmlElement(ElementName = "NumeroCuotas")]
            public string NumeroCuotas { get; set; }
        }

        public class LiquidacionModel
        {
            [XmlElement(ElementName = "IdLiquidacion")]
            public string IdLiquidacion { get; set; }

            [XmlElement(ElementName = "CodigoTarifa")]
            public string CodigoTarifa { get; set; }

            [XmlElement(ElementName = "ModalidadPago")]
            public string ModalidadPago { get; set; }

            [XmlElement(ElementName = "TarjetaMarcaCompartida")]
            public bool? TarjetaMarcaCompartida { get; set; }

            [XmlElement(ElementName = "AutorizaDebitoAutomatico")]
            public bool? AutorizaDebitoAutomatico { get; set; }

            [XmlElement(ElementName = "PorcDesModalidadPago")]
            public string PorcDesModalidadPago { get; set; }

            [XmlElement(ElementName = "DescuentoAnticipadoPOS")]
            public string DescuentoAnticipadoPOS { get; set; }

            [XmlElement(ElementName = "DescuentoPromocional")]
            public bool? DescuentoPromocional { get; set; }

            [XmlElement(ElementName = "TotalPlenoMes")]
            public string TotalPlenoMes { get; set; }

            [XmlElement(ElementName = "TotalNetoMes")]
            public string TotalNetoMes { get; set; }

            [XmlElement(ElementName = "ValorModalidadPago")]
            public string ValorModalidadPago { get; set; }

            [XmlElement(ElementName = "ValorCuotaInscripcion")]
            public string ValorCuotaInscripcion { get; set; }

            [XmlElement(ElementName = "ValorIVA")]
            public string ValorIVA { get; set; }

            [XmlElement(ElementName = "TotalPago")]
            public string TotalPago { get; set; }

            [XmlElement(ElementName = "RecibosCaja")]
            public RecibosCajaModel RecibosCaja { get; set; }

            [XmlElement(ElementName = "DebitoAutomatico")]
            public DebitoAutomaticoModel DebitoAutomatico { get; set; }

            [XmlElement(ElementName = "LiquidacionManual")]
            public bool? LiquidacionManual { get; set; }

            [XmlElement(ElementName = "TipoLiquidacionManual")]
            public string TipoLiquidacionManual { get; set; }

            public class RecibosCajaModel
            {
                [XmlElement(ElementName = "string")]
                public string numero { get; set; }
            }

            public class DebitoAutomaticoModel
            {
                [XmlElement(ElementName = "Id")]
                public string Id { get; set; }

                [XmlElement(ElementName = "FechaDiligenciamiento")]
                public DateTime? FechaDiligenciamiento { get; set; }

                [XmlElement(ElementName = "Ciudad")]
                public CiudadModelDebito Ciudad { get; set; }

                [XmlElement(ElementName = "Establecimiento")]
                public EstablecimientoModel Establecimiento { get; set; }

                [XmlElement(ElementName = "MedioPago")]
                public string MedioPago { get; set; }

                [XmlElement(ElementName = "TipoTarjetaCredito")]
                public string TipoTarjetaCredito { get; set; }

                [XmlElement(ElementName = "VencimientoTarjeta")]
                public DateTime? VencimientoTarjeta { get; set; }

                [XmlElement(ElementName = "DescuentoDesde")]
                public DateTime? DescuentoDesde { get; set; }

                [XmlElement(ElementName = "NumeroCuotas")]
                public string NumeroCuotas { get; set; }
                    
                [XmlElement(ElementName = "NumeroCuentaTarjeta")]
                public string NumeroCuentaTarjeta { get; set; }

                [XmlElement(ElementName = "NumeroContratoMP")]
                public string NumeroContratoMP { get; set; }

                [XmlElement(ElementName = "EntidadFinanciera")]
                public EntidadFinancieraModel EntidadFinanciera { get; set; }

                [XmlElement(ElementName = "TarjetaHabiente")]
                public TarjetaHabienteModel TarjetaHabiente { get; set; }


                public class CiudadModelDebito
                {
                    [XmlElement(ElementName = "IdCiudad")]
                    public string IdCiudad { get; set; }

                    [XmlElement(ElementName = "NombreCiudad")]
                    public string NombreCiudad { get; set; }
                }

                public class EstablecimientoModel
                {
                    [XmlElement(ElementName = "Id")]
                    public string Id { get; set; }

                    [XmlElement(ElementName = "Nombre")]
                    public string Nombre { get; set; }
                }

                public class EntidadFinancieraModel
                {
                         [XmlElement(ElementName = "Id")]
                    public string Id { get; set; }

                    [XmlElement(ElementName = "Nombre")]
                    public string Nombre { get; set; }
                    
                }

                public class TarjetaHabienteModel
                {
                    [XmlElement(ElementName = "Id")]
                    public string Id { get; set; }

                    [XmlElement(ElementName = "TipoIdentificacion")]
                    public string TipoIdentificacion { get; set; }

                    [XmlElement(ElementName = "NumeroIdentificacion")]
                    public string NumeroIdentificacion { get; set; }

                    [XmlElement(ElementName = "PrimerNombre")]
                    public string PrimerNombre { get; set; }

                    [XmlElement(ElementName = "SegundoNombre")]
                    public string SegundoNombre { get; set; }

                    [XmlElement(ElementName = "PrimerApellido")]
                    public string PrimerApellido { get; set; }

                    [XmlElement(ElementName = "SegundoApellido")]
                    public string SegundoApellido { get; set; }

                    [XmlElement(ElementName = "FechaNacimiento")]
                    public string FechaNacimiento { get; set; }

                    [XmlElement(ElementName = "Sexo")]
                    public string Sexo { get; set; }

                    [XmlElement(ElementName = "EsContratante")]
                    public bool? EsContratante { get; set; }

                    [XmlElement(ElementName = "DireccionCorrespondencia")]
                    public DatosDireccionModel DireccionCorrespondencia { get; set; }
                }
            }

        }

        public class AsesorModel
        {
            [XmlElement(ElementName = "Id")]
            public string Nombre { get; set; }

            [XmlElement(ElementName = "FechaNacimiento")]
            public DateTime? FechaNacimiento { get; set; }

            [XmlElement(ElementName = "Sexo")]
            public string Sexo { get; set; }

            [XmlElement(ElementName = "Clave")]
            public string Clave { get; set; }

            [XmlElement(ElementName = "CodigoOficina")]
            public string CodigoOficina { get; set; }

            [XmlElement(ElementName = "Telefono")]
            public string Telefono { get; set; }

            [XmlElement(ElementName = "AsesorExterno")]
            public bool? AsesorExterno { get; set; }
        }

        public class DocumentosModel
        {
            [XmlElement(ElementName = "Id")]
            public string Id { get; set; }

            [XmlElement(ElementName = "Tipo")]
            public string Tipo { get; set; }

            [XmlElement(ElementName = "EsBeneficiario")]
            public bool? EsBeneficiario { get; set; }

            [XmlElement(ElementName = "TipoIdentificacion")]
            public string TipoIdentificacion { get; set; }

            [XmlElement(ElementName = "Identificacion")]
            public string Identificacion { get; set; }
        }
    }

   
}
