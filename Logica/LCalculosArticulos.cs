
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class LCalculosArticulos
    {
        

        public int NumeroDeArticulos()
        {
            AccesoADatos.Consulta.CalculosArticulos ADCC = new AccesoADatos.Consulta.CalculosArticulos();
            return ADCC.NumeroDeArticulos();
        }

        public int ArticulosDonacion()
        {
            AccesoADatos.Consulta.CalculosArticulos ADCC = new AccesoADatos.Consulta.CalculosArticulos();
            return ADCC.NumeroDeArticulosDonacion();
        }

        public int ArticulosBaja()
        {
            AccesoADatos.Consulta.CalculosArticulos ADCC = new AccesoADatos.Consulta.CalculosArticulos();
            return ADCC.NumeroDeArticulosBaja();
        }

        public double costoTotalBienes()
        {
            AccesoADatos.Consulta.CalculosArticulos ADCC = new AccesoADatos.Consulta.CalculosArticulos();
            return ADCC.costoTotalBienes();
        }
    }
}
