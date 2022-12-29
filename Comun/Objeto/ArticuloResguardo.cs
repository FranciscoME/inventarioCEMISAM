
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comun.Objeto
{
    public class ArticuloResguardo
    {
         string claveCabms;
        string clavePresupuestal;
        string descripcion;       
        string costoUnitario;
        string nombreDelResguardatario;
        string estadoFisicoDelBien;


        public ArticuloResguardo(string _claveCabms, string _descripcion, string _costoUnitario, string _clavePresupuestal, string _nombreDelResguardatario, string _estadoFisicoDelBien)
            {
                
                claveCabms = _claveCabms;
                descripcion = _descripcion;
                costoUnitario = _costoUnitario;
                clavePresupuestal = _clavePresupuestal;
                nombreDelResguardatario = _nombreDelResguardatario;
                estadoFisicoDelBien = _estadoFisicoDelBien;       
            }


        public string ClaveCabms
        {
            get { return claveCabms; }
            set { claveCabms = value; }
        }

       

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string CostoUnitario
        {
            get { return costoUnitario; }
            set { costoUnitario = value; }
        }

        public string ClavePresupuestal
        {
            get { return clavePresupuestal; }
            set { clavePresupuestal = value; }
        }

        

        public string NombreDelResguardatario
        {
            get { return nombreDelResguardatario; }
            set { nombreDelResguardatario = value; }
        }

        public string EstadoFisicoDelBien
        {
            get { return estadoFisicoDelBien; }
            set { estadoFisicoDelBien = value; }
        }
    }
}
