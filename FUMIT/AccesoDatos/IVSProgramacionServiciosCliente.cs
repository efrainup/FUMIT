﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface IVSProgramacionServiciosCliente : IOperacionesAccesoDatos<Entidades.Vsprogramacionservicioscliente>
    {
        IEnumerable<Entidades.Vsprogramacionservicioscliente> RecuperarPorClienteId(int clienteId);
    }
}
