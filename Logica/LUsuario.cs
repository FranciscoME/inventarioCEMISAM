
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class LUsuario
    {
        public Comun.Objeto.Usuario obtenerUsuario(int idUsuario)
        {
            AccesoADatos.Consulta.ClientesConsulta consultaCliente = new AccesoADatos.Consulta.ClientesConsulta();
            return consultaCliente.obtenerUsuario(idUsuario);
        }

        public List<Comun.Objeto.Usuario> obtenerListaUsuarios()
        {
            AccesoADatos.Consulta.ClientesConsulta consultaListaClientes = new AccesoADatos.Consulta.ClientesConsulta();
            return consultaListaClientes.obtenerListaUsuarios();
        }

        public bool InsertarUsuario(Comun.Objeto.Usuario oUsuario)
        {
            AccesoADatos.Consulta.ClientesConsulta ADClientesConsulta = new AccesoADatos.Consulta.ClientesConsulta();
           return ADClientesConsulta.insertarUsuario(oUsuario);
        }

        public bool modificarUsuario(Comun.Objeto.Usuario oUsuario)
        {
            AccesoADatos.Consulta.ClientesConsulta ADUsuarios = new AccesoADatos.Consulta.ClientesConsulta();
            return ADUsuarios.modificarUsuario(oUsuario);
        }

        public bool eliminarUsuario(int IdUsuario)
        {
            AccesoADatos.Consulta.ClientesConsulta ADClientes = new AccesoADatos.Consulta.ClientesConsulta();
            return ADClientes.eliminarUsuario(IdUsuario);
        }
    }
}
