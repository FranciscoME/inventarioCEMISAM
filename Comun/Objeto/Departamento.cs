
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comun.Objeto
{
    public class Departamento
    {
        string nombreDepartamento;
        int id;
        

        public Departamento( int _id,string _nombreDepartamento)
        {
            nombreDepartamento = _nombreDepartamento;
            id = _id;
        }
        

        public string NombreDepartamento
        {
            get 
            {
                return nombreDepartamento;
            }

            set
            {
                nombreDepartamento = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
