using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.AccesoDatos
{
    public interface IMantenimientos : IOperacionesAccesoDatos<Entidades.Mantenimiento>
    {
        Entidades.Mantenimiento CrearMantenimientoDeEquipo(Entidades.Mantenimiento mantenimiento, int equipoId);
        Entidades.Mantenimiento CrearMantenimientoDeEquipo(Entidades.Mantenimiento mantenimiento, string numeroEconomico);
        Entidades.Mantenimiento CrearMantenimientoDeEquipo(Entidades.Mantenimiento mantenimiento, Entidades.Equipo equipo);
        Task<Entidades.Mantenimiento> CrearMantenimientoDeEquipoAsync(Entidades.Mantenimiento mantenimiento, int equipoId);
        Task<Entidades.Mantenimiento> CrearMantenimientoDeEquipoAsync(Entidades.Mantenimiento mantenimiento, string numeroEconomico);
        Task<Entidades.Mantenimiento> CrearMantenimientoDeEquipoAsync(Entidades.Mantenimiento mantenimiento, Entidades.Equipo equipo);
        IEnumerable<Entidades.Mantenimiento> RecuperarPorEquipo(int equipoId);
        IEnumerable<Entidades.Mantenimiento> RecuperarPorEquipo(string numeroEconomico);
        IEnumerable<Entidades.Mantenimiento> RecuperarPorEquipo(Entidades.Equipo equipo);
    }
}
