﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class ProgramacionServiciosClienteRepositorio : AOperacionesBase<Programacionservicioscliente>, IProgramacionServiciosCliente
    {
        public IEnumerable<Programacionservicioscliente> RecuperarProgramacionServiciosClientePorIdCliente(int clienteId)
        {
            return dbSet.Where(w => !w.Borrado && w.ClienteId == clienteId).ToList();
        }

       
    }
}
