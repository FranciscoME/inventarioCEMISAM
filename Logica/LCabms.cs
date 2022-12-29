
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class LCabms
    {

        public List<Comun.Objeto.CABMS> consultaCabms()
        {
            AccesoADatos.Consulta.CabmsConsulta ADConsultaCabms = new AccesoADatos.Consulta.CabmsConsulta();
            return ADConsultaCabms.consultaCabms();
        }

        public List<Comun.Objeto.CABMS> consultaCabmsxCaracteristica(string caracteristica)
        {
            AccesoADatos.Consulta.CabmsConsulta ADConsultaCabms = new AccesoADatos.Consulta.CabmsConsulta();
            return ADConsultaCabms.consultaCabmsxCaracteristica(caracteristica);
        }
    }
}
