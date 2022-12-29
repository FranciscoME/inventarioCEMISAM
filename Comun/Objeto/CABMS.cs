
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comun.Objeto
{
    public class CABMS
    {
        int id;
        string clave;
        string descripcion;
       

        public CABMS(int _id, string _clave, string _descripcion)
        {
            id = _id;
            clave = _clave;
            descripcion = _descripcion;
            

        }

        

        public int ID
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

        public string Clave
        {
            get
            {
                return clave;
            }
            set
            {
                clave = value;
            }

        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        
    }
}
