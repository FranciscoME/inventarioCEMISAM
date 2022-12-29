
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comun.Objeto
{
    public class Articulo
    {
        int id;
        string claveCabms;
        int clavePresupuestal;
        string descripcion;
        string marca;
        string modelo;
        string ns;
        double costoUnitario;
        string nombreDelResguardatario;
        string estadoFisicoDelBien;
        string fechaDeAlta;
        bool donacion;
        bool baja;
        string fechaDeBaja;
        string notas;
        int fkUsuarios;
        bool etiqueta;
        string nombreImagen;
        

        public Articulo(int _id,string _claveCabms, int _clavePresupuestal, string _descripcion, string _marca, string _modelo, string _ns,
                        double _costoUnitario, string _nombreDelResguardatario, string _estadoFisicoDelBien, string _fechaAlta,
                        bool _donacion, bool _baja, string _fechaDeBaja, string _notas, int _fkUsuarios, bool _Etiqueta, string _nombreImagen)
        {
            id = _id;
            claveCabms = _claveCabms; clavePresupuestal = _clavePresupuestal; descripcion = _descripcion; marca = _marca;
            modelo = _modelo; ns = _ns; costoUnitario = _costoUnitario; nombreDelResguardatario = _nombreDelResguardatario;
            estadoFisicoDelBien = _estadoFisicoDelBien; fechaDeAlta = _fechaAlta; donacion = _donacion; baja = _baja;
            fechaDeBaja = _fechaDeBaja; notas = _notas; fkUsuarios = _fkUsuarios; Etiqueta = _Etiqueta; nombreImagen = _nombreImagen;
        }
        public Articulo()
        {
        
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string ClaveCabms
        {
            get { return claveCabms; }
            set { claveCabms = value; }
        }

        public int ClavePresupuestal
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

        public double CostoUnitario
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

        public bool Donacion
        {
            get { return donacion; }
            set { donacion = value; }
        }

        public bool Baja
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

        public int FkUsuarios
        {
            get { return fkUsuarios; }
            set { fkUsuarios = value; }
        }

        public bool Etiqueta
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
