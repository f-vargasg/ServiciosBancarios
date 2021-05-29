using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.DTO
{
    public class GiroBancarioBE
    {
        public int IndCliente { get; set; }
        public int NumOrdpag { get; set; }
        public int CodTipordpagN { get; set; }
        public int CodIntctaN { get; set; }
        public string DesCtacorr { get; set; }
        public string CodCtacorrV { get; set; }
        public int CodMonedaN { get; set; }
        public string DesMoneda { get; set; }
        public int CodMotivoN { get; set; }
        public int CodEjecutivoN { get; set; }
        public string DesEjecutivo { get; set; }
        public int CodCompaniaN { get; set; }
        public string DesCompania { get; set; }
        public int CodConceptoordN { get; set; }
        public string DesConceptoord { get; set; }
        public int CodBaintctaN { get; set; }
        public string TipBamovbancV { get; set; }
        public int NumBamovbanc { get; set; }
        public string CodInstrucpagV { get; set; }
        public string DesInstrucpag { get; set; }
        public int NumTranscons { get; set; }
        public DateTime FecEjecuci { get; set; }
        public int MtoOrdpag { get; set; }
        public string DesBenefic { get; set; }
        public string DesEfecto { get; set; }
        public string DesObserva { get; set; }
        public string DesAnula { get; set; }
        public int CodTransaccionN { get; set; }
        public int IndEsorigen { get; set; }
        public decimal CodRegistroN { get; set; }
        public int CodEstadoN { get; set; }
        public int CodCorrespbancN { get; set; }
        public string DesBanco { get; set; }
        public int CodClienteN { get; set; }
        public string NomCliente { get; set; }
        public int CodCuentaN { get; set; }
        public string NomCuenta { get; set; }
        public int CodPersonaN { get; set; }
        public string CodTipgirobanV { get; set; }
        public string DesTipgiroban { get; set; }
        public int MtoLiquida { get; set; }
        public int MtoTipcambio { get; set; }
        public int CodPersonaN1 { get; set; }
        public string UsuTransito { get; set; }
        public int IndPropiaN { get; set; }
        public int IndReqaprobacionN { get; set; }
    }
}
