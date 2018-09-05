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
                    entidad.Equipo.Asignado = true;
                    await EquiposRepositorio.ActualizarAsync(entidad.Equipo);

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
                    entidad.Equipo.Asignado = true;
                    EquiposRepositorio.Actualizar(entidad.Equipo);

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
                    entidad.Equipo.Asignado = false;
                    await EquiposRepositorio.ActualizarAsync(entidad.Equipo);

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
                    entidad.Equipo.Asignado = false;
                    EquiposRepositorio.Actualizar(entidad.Equipo);

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
