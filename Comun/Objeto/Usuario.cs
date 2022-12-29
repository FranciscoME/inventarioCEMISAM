
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comun.Objeto
{
    public class Usuario
    {
        int id;
        string rfc;
        string nombre;
        int fkDepartamento;

        public Usuario(int _id, string _rfc, string _nombre, int _fkDepartamento)
        {
            id = _id;            
            rfc = _rfc;
            nombre = _nombre;
            fkDepartamento = _fkDepartamento;
        }
        public Usuario()
        { 
        
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int FkDepartamento
        {
            get { return fkDepartamento; }
            set { fkDepartamento = value; }
        }
    }
}
