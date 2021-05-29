using ServiciosBancarios.Datos;
using ServiciosBancarios.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiciosBancarios.Logica
{
    public class GiroBancarioBL
    {
        readonly GiroBancarioDL giroBancarioDL;

        public GiroBancarioBL()
        {
            this.giroBancarioDL = new GiroBancarioDL();
        }

        public List<GiroBancarioBE> GetList()
        {
            List<GiroBancarioBE> res = null;
            try
            {
                res = this.giroBancarioDL.GetList();
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
