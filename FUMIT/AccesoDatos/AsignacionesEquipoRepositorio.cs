using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class AsignacionesEquipoRepositorio : AOperacionesBase<Entidades.Asignacionesequipo>, IAsignacionesEquipo
    {
        #region Propiedades
        public IEquipos EquiposRepositorio { get; set; }
        #endregion

        public AsignacionesEquipoRepositorio()
        {
            EquiposRepositorio = CommonServiceLocator.ServiceLocator.Current.GetInstance<IEquipos>();
        }

        #region Metodos
        public IEnumerable<Asignacionesequipo> RecuperarEquiposPorCliente(int ClienteId)
        {
            return dbSet.Where(w => w.Borrado == false && w.ClienteId == ClienteId).ToArray();
        }

        public IEnumerable<Asignacionesequipo> RecuperarEquiposPorCliente(Cliente cliente)
        {
            return cliente.Asignacionesequipos.Where(w => w.Borrado == false).ToArray();
        }

        public async override Task<Asignacionesequipo> CrearAsync(Asignacionesequipo entidad)
        {
            using (DbContextTransaction transaccion = dbContext.Database.BeginTransaction())
            {
                try
                {
                    //Actualizar el estado del equipo a asignado
                    Equipo equipo = EquiposRepositorio.RecuperarPorId(entidad.EquipoId);
                    equipo.Asignado = true;
                    await EquiposRepositorio.ActualizarAsync(equipo);

                    entidad = await base.CrearAsync(entidad);
                    transaccion.Commit();

                    return entidad;
                }catch(Exception excepcion)
                {
                    transaccion.Rollback();
                    throw excepcion;
                }
            }
        }

        public override Asignacionesequipo Crear(Asignacionesequipo entidad)
        {
            using (DbContextTransaction transaccion = dbContext.Database.BeginTransaction())
            {
                try
                {
                    //Actualizar el estado del equipo a asignado
                    Equipo equipo = EquiposRepositorio.RecuperarPorId(entidad.EquipoId);
                    equipo.Asignado = true;
                    EquiposRepositorio.Actualizar(equipo);

                    entidad = base.Crear(entidad);
                    transaccion.Commit();

                    return entidad;
                }
                catch (Exception excepcion)
                {
                    transaccion.Rollback();
                    throw excepcion;
                }
            }
        }

        public async override Task EliminarAsync(Asignacionesequipo entidad)
        {
            using (DbContextTransaction transaccion = dbContext.Database.BeginTransaction())
            {
                try
                {
                    //Se desasigna el equipo
                    Equipo equipo = EquiposRepositorio.RecuperarPorId(entidad.EquipoId);
                    equipo.Asignado = false;
                    await EquiposRepositorio.ActualizarAsync(equipo);

                    await base.EliminarAsync(entidad);
                    transaccion.Commit();
                }
                catch (Exception e)
                {
                    transaccion.Rollback();
                    throw e;
                }
            }
        }

        public override void Eliminar(Asignacionesequipo entidad)
        {
            using (DbContextTransaction transaccion = dbContext.Database.BeginTransaction())
            {
                try
                {
                    //Se desasigna el equipo
                    Equipo equipo = EquiposRepositorio.RecuperarPorId(entidad.EquipoId);
                    equipo.Asignado = false;
                    EquiposRepositorio.Actualizar(equipo);

                    base.Eliminar(entidad);
                    transaccion.Commit();
                }
                catch (Exception e)
                {
                    transaccion.Rollback();
                    throw e;
                }
            }
        }
        #endregion
    }
}
