 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comun.Objeto
{
    public class ArticuloConsulta
    {
        string id;
        string claveCabms;
        string clavePresupuestal;
        string descripcion;
        string marca;
        string modelo;
        string ns;
        string costoUnitario;
        string nombreDelResguardatario;
        string estadoFisicoDelBien;
        string fechaDeAlta;
        string donacion;
        string baja;
        string fechaDeBaja;
        string notas;
        string fkUsuarios;
        string etiqueta;
        string nombreImagen;

        public ArticuloConsulta()
        {

        }

        public ArticuloConsulta(string _id, string _claveCabms, string _clavePresupuestal, string _descripcion, string _marca, string _modelo, string _ns,
                        string _costoUnitario, string _estadoFisicoDelBien, string _fechaAlta,
                        string _donacion, string _baja, string _fechaDeBaja, string _notas, string _fkUsuarios, string _Etiqueta)
        {
            id = _id;
            claveCabms = _claveCabms; clavePresupuestal = _clavePresupuestal; descripcion = _descripcion; marca = _marca;
            modelo = _modelo; ns = _ns; costoUnitario = _costoUnitario;
            estadoFisicoDelBien = _estadoFisicoDelBien; fechaDeAlta = _fechaAlta; donacion = _donacion; baja = _baja;
            fechaDeBaja = _fechaDeBaja; notas = _notas; fkUsuarios = _fkUsuarios; Etiqueta = _Etiqueta; 
        }


        public ArticuloConsulta(string _id, string _claveCabms, string _clavePresupuestal, string _descripcion, string _marca, string _modelo, string _ns,
                        string _costoUnitario, string _estadoFisicoDelBien, string _fechaAlta, string _nombreDelResguardatario,
                        string _donacion, string _baja, string _fechaDeBaja, string _notas, string _fkUsuarios, string _Etiqueta, string _nombreImagen)
        {
            id = _id;
            claveCabms = _claveCabms; clavePresupuestal = _clavePresupuestal; descripcion = _descripcion; marca = _marca;
            modelo = _modelo; ns = _ns; costoUnitario = _costoUnitario; nombreDelResguardatario = _nombreDelResguardatario;
            estadoFisicoDelBien = _estadoFisicoDelBien; fechaDeAlta = _fechaAlta; donacion = _donacion; baja = _baja;
            fechaDeBaja = _fechaDeBaja; notas = _notas; fkUsuarios = _fkUsuarios; Etiqueta = _Etiqueta; nombreImagen= _nombreImagen ; 
        }

        public ArticuloConsulta(string _claveCabms, string _descripcion, string _clavePresupuestal)
        { claveCabms = _claveCabms; descripcion = _descripcion; clavePresupuestal = _clavePresupuestal; }

        public ArticuloConsulta(string _claveCabms, string _descripcion, string _costoUnitario, string _clavePresupuestal, string _nombreDelResguardatario,string _estadoFisicoDelBien)
            {
                
                claveCabms = _claveCabms;
                descripcion = _descripcion;
                costoUnitario = _costoUnitario;
                clavePresupuestal = _clavePresupuestal;
                nombreDelResguardatario = _nombreDelResguardatario;
                estadoFisicoDelBien = _estadoFisicoDelBien;       
            }



        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string ClaveCabms
        {
            get { return claveCabms; }
            set { claveCabms = value; }
        }

        public string ClavePresupuestal
        {
            get { return clavePresupuestal; }
            set { clavePresupuestal = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string NS
        {
            get { return ns; }
            set { ns = value; }
        }

        public string CostoUnitario
        {
            get { return costoUnitario; }
            set { costoUnitario = value; }
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

        public string FechaDeAlta
        {
            get { return fechaDeAlta; }
            set { fechaDeAlta = value; }
        }

        public string Donacion
        {
            get { return donacion; }
            set { donacion = value; }
        }

        public string Baja
        {
            get { return baja; }
            set { baja = value; }
        }

        public string FechaDeBaja
        {
            get { return fechaDeBaja; }
            set { fechaDeBaja = value; }
        }

        public string Notas
        {
            get { return notas; }
            set { notas = value; }
        }

        public string FkUsuarios
        {
            get { return fkUsuarios; }
            set { fkUsuarios = value; }
        }

        public string Etiqueta
        {
            get { return etiqueta; }
            set { etiqueta = value; }
        }

        public string NombreImagen
        {
            get { return nombreImagen; }
            set { nombreImagen = value; }
        }
    }
}
