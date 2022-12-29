
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public class LDepartamento
    {
        public bool insertarDepartamento(string nombreDepartamento)
        {
            AccesoADatos.Consulta.DepartamentoConsulta ADDepartamento = new AccesoADatos.Consulta.DepartamentoConsulta();
            return ADDepartamento.insertarDepartamento(nombreDepartamento);
        }

        public List<Comun.Objeto.Departamento> ObtenerDepartamentos()
        {
            AccesoADatos.Consulta.DepartamentoConsulta ADDepartamento = new AccesoADatos.Consulta.DepartamentoConsulta();
            return ADDepartamento.ObtenerDepartamentos();
        }

        public List<Comun.Objeto.Departamento> ObtenerDepartamento(int IdDepartamento)
        {
            AccesoADatos.Consulta.DepartamentoConsulta ADDepartamento = new AccesoADatos.Consulta.DepartamentoConsulta();
            return ADDepartamento.ObtenerDepartamento(IdDepartamento);
        }
    }
}
