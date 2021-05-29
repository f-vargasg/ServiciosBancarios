using ServiciosBancarios.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Datos
{
    public class GiroBancarioDL : DataWorker
    {
        public List<GiroBancarioBE> GetList ()
        {
            string sql = "Select a.* " + Environment.NewLine +
                         "from  ba_ambsobregirotmp a " ;
            List<GiroBancarioBE> res = new List<GiroBancarioBE>();

            using (DbConnection connection = database.CreateOpenConnection())
            {
                using (DbCommand command = database.CreateCommand(sql, connection))
                {
                    using (IDataReader dr = command.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            GiroBancarioBE giroBancarioBE = new GiroBancarioBE
                            {
                                IndCliente = Convert.ToInt32(dr["IND_CLIENTE"]),
                                NumOrdpag = Convert.ToInt32(dr["NUM_ORDPAG"]),
                                CodTipordpagN = Convert.ToInt32(dr["COD_TIPORDPAG_N"]),
                                CodIntctaN = Convert.ToInt32(dr["COD_INTCTA_N"]),
                                DesCtacorr = Convert.ToString(dr["DES_CTACORR"]),
                                CodCtacorrV = Convert.ToString(dr["COD_CTACORR_V"]),
                                CodMonedaN = Convert.ToInt32(dr["COD_MONEDA_N"]),
                                DesMoneda = Convert.ToString(dr["DES_MONEDA"]),
                                CodMotivoN = (dr["COD_MOTIVO_N"] != DBNull.Value ? Convert.ToInt32(dr["COD_MOTIVO_N"]) : -1),
                                CodEjecutivoN = Convert.ToInt32(dr["COD_EJECUTIVO_N"]),
                                DesEjecutivo = Convert.ToString(dr["DES_EJECUTIVO"]),
                                CodCompaniaN = Convert.ToInt32(dr["COD_COMPANIA_N"]),
                                DesCompania = Convert.ToString(dr["DES_COMPANIA"]),
                                CodConceptoordN = Convert.ToInt32(dr["COD_CONCEPTOORD_N"]),
                                DesConceptoord = Convert.ToString(dr["DES_CONCEPTOORD"]),
                                CodBaintctaN = Convert.ToInt32(dr["COD_BAINTCTA_N"]),
                                TipBamovbancV = Convert.ToString(dr["TIP_BAMOVBANC_V"]),
                                NumBamovbanc = Convert.ToInt32(dr["NUM_BAMOVBANC"]),
                                CodInstrucpagV = Convert.ToString(dr["COD_INSTRUCPAG_V"]),
                                DesInstrucpag = Convert.ToString(dr["DES_INSTRUCPAG"]),
                                NumTranscons = Convert.ToInt32(dr["NUM_TRANSCONS"]),
                                FecEjecuci = Convert.ToDateTime(dr["FEC_EJECUCI"]),
                                MtoOrdpag = Convert.ToInt32(dr["MTO_ORDPAG"]),
                                DesBenefic = Convert.ToString(dr["DES_BENEFIC"]),
                                DesEfecto = Convert.ToString(dr["DES_EFECTO"]),
                                DesObserva = Convert.ToString(dr["DES_OBSERVA"]),
                                DesAnula = (dr["DES_ANULA"] != DBNull.Value ? Convert.ToString(dr["DES_ANULA"]) : string.Empty),
                                CodTransaccionN = Convert.ToInt32(dr["COD_TRANSACCION_N"]),
                                IndEsorigen = Convert.ToInt32(dr["IND_ESORIGEN"]),
                                CodRegistroN = Convert.ToDecimal(dr["COD_REGISTRO_N"]),
                                CodEstadoN = Convert.ToInt32(dr["COD_ESTADO_N"]),
                                CodCorrespbancN = (dr["COD_CORRESPBANC_N"] != DBNull.Value ? Convert.ToInt32(dr["COD_CORRESPBANC_N"]) : -1),
                                DesBanco = Convert.ToString(dr["DES_BANCO"]),
                                CodClienteN = Convert.ToInt32(dr["COD_CLIENTE_N"]),
                                NomCliente = Convert.ToString(dr["NOM_CLIENTE"]),
                                CodCuentaN = Convert.ToInt32(dr["COD_CUENTA_N"]),
                                NomCuenta = Convert.ToString(dr["NOM_CUENTA"]),
                                CodPersonaN = (dr["COD_PERSONA_N"] != DBNull.Value ? Convert.ToInt32(dr["COD_PERSONA_N"]) : -1),
                                CodTipgirobanV = Convert.ToString(dr["COD_TIPGIROBAN_V"]),
                                DesTipgiroban = Convert.ToString(dr["DES_TIPGIROBAN"]),
                                MtoLiquida = Convert.ToInt32(dr["MTO_LIQUIDA"]),
                                MtoTipcambio = Convert.ToInt32(dr["MTO_TIPCAMBIO"]),
                                CodPersonaN1 = (dr["COD_PERSONA_N1"] != DBNull.Value ? Convert.ToInt32(dr["COD_PERSONA_N1"]) : -1),
                                UsuTransito = (dr["USU_TRANSITO"] != DBNull.Value ? Convert.ToString(dr["USU_TRANSITO"]) : string.Empty),
                                IndPropiaN = Convert.ToInt32(dr["IND_PROPIA_N"]),
                                IndReqaprobacionN = Convert.ToInt32(dr["IND_REQAPROBACION_N"])
                            };
                            res.Add(giroBancarioBE);
                        }
                    }
                }
            }
            return res;
        }
    }
}
