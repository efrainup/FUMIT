using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator;
using FUMIT.Entidades;

namespace FUMIT.AccesoDatos
{
    public class MantenimientosRepositorio : AOperacionesBase<Entidades.Mantenimiento>, IMantenimientos
    {
        #region Propiedades
        public IMantenimientosEquipo ManteniminetosEquipoRepositorio { get; set; }
        public IEquipos EquiposRepositorio { get; set; }
        #endregion

        public MantenimientosRepositorio()
        {
            ManteniminetosEquipoRepositorio = ServiceLocator.Current.GetInstance<IMantenimientosEquipo>();
            EquiposRepositorio = ServiceLocator.Current.GetInstance<IEquipos>();
        }

        public Mantenimiento CrearMantenimientoDeEquipo(Mantenimiento mantenimiento, int equipoId)
        {
            using (DbContextTransaction transaction = dbContext.Database.BeginTransaction())
            {

                mantenimiento = Crear(mantenimiento);
                Equipo eqiupo = EquiposRepositorio.RecuperarPorId(equipoId);

                var mantenimientoEquipo = new Entidades.MantenimientosEquipo()
                {
                    MantenimientoId = mantenimiento.MantenimientoId,
                    Mantenimiento = mantenimiento,
                    EquipoId = equipoId,
                    Equipo = eqiupo
                };

                mantenimientoEquipo = ManteniminetosEquipoRepositorio.Crear(mantenimientoEquipo);

                transaction.Commit();

                return mantenimiento;
            }
        }

        public Mantenimiento CrearMantenimientoDeEquipo(Mantenimiento mantenimiento, string numeroEconomico)
        {
            using (DbContextTransaction transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    mantenimiento = Crear(mantenimiento);
                    Equipo eqiupo = EquiposRepositorio.RecuperarPorNumeroEconomico(numeroEconomico);

                    var mantenimientoEquipo = new Entidades.MantenimientosEquipo()
                    {
                        MantenimientoId = mantenimiento.MantenimientoId,
                        Mantenimiento = mantenimiento,
                        EquipoId = eqiupo.EquipoId,
                        Equipo = eqiupo
                    };

                    mantenimientoEquipo = ManteniminetosEquipoRepositorio.Crear(mantenimientoEquipo);

                    transaction.Commit();

                    return mantenimiento;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    transaction.Rollback();
                }
            }
        }

        public Mantenimiento CrearMantenimientoDeEquipo(Mantenimiento mantenimiento, Equipo equipo)
        {
            using (DbContextTransaction transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    mantenimiento = Crear(mantenimiento);

                    var mantenimientoEquipo = new Entidades.MantenimientosEquipo()
                    {
                        MantenimientoId = mantenimiento.MantenimientoId,
                        Mantenimiento = mantenimiento,
                        EquipoId = equipo.EquipoId,
                        Equipo = equipo
                    };

                    mantenimientoEquipo = ManteniminetosEquipoRepositorio.Crear(mantenimientoEquipo);

                    transaction.Commit();

                    return mantenimiento;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    transaction.Rollback();
                }
            }
        }

        public async Task<Mantenimiento> CrearMantenimientoDeEquipoAsync(Mantenimiento mantenimiento, int equipoId)
        {
            using (DbContextTransaction transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    mantenimiento = await CrearAsync(mantenimiento);
                    Equipo eqiupo = EquiposRepositorio.RecuperarPorId(equipoId);

                    var mantenimientoEquipo = new Entidades.MantenimientosEquipo()
                    {
                        MantenimientoId = mantenimiento.MantenimientoId,
                        Mantenimiento = mantenimiento,
                        EquipoId = equipoId,
                        Equipo = eqiupo
                    };

                    mantenimientoEquipo = await ManteniminetosEquipoRepositorio.CrearAsync(mantenimientoEquipo);

                    transaction.Commit();

                    return mantenimiento;
                }catch(Exception e)
                {
                    throw e;
                }
                finally
                {
                    transaction.Rollback();
                }
            }
        }

        public async Task<Mantenimiento> CrearMantenimientoDeEquipoAsync(Mantenimiento mantenimiento, string numeroEconomico)
        {
            using (DbContextTransaction transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    mantenimiento = await CrearAsync(mantenimiento);
                    Equipo eqiupo = EquiposRepositorio.RecuperarPorNumeroEconomico(numeroEconomico);

                    var mantenimientoEquipo = new Entidades.MantenimientosEquipo()
                    {
                        MantenimientoId = mantenimiento.MantenimientoId,
                        Mantenimiento = mantenimiento,
                        EquipoId = eqiupo.EquipoId,
                        Equipo = eqiupo
                    };

                    mantenimientoEquipo = await ManteniminetosEquipoRepositorio.CrearAsync(mantenimientoEquipo);

                    transaction.Commit();

                    return mantenimiento;
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw e;
                }
                
            }
        }

        public async Task<Mantenimiento> CrearMantenimientoDeEquipoAsync(Mantenimiento mantenimiento, Equipo equipo)
        {
            using (DbContextTransaction transaction = dbContext.Database.BeginTransaction())
            {
                try
                {
                    mantenimiento = await CrearAsync(mantenimiento);

                    var mantenimientoEquipo = new Entidades.MantenimientosEquipo()
                    {
                        MantenimientoId = mantenimiento.MantenimientoId,
                        Mantenimiento = mantenimiento,
                        EquipoId = equipo.EquipoId,
                        Equipo = equipo
                    };

                    mantenimientoEquipo = await ManteniminetosEquipoRepositorio.CrearAsync(mantenimientoEquipo);

                    transaction.Commit();

                    return mantenimiento;
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    transaction.Rollback();
                }
            }
        }

        public IEnumerable<Mantenimiento> RecuperarPorEquipo(int equipoId)
        {
            Equipo equipo = EquiposRepositorio.RecuperarPorId(equipoId);
            return equipo.Mantenimientosequipos.Select(s => s.Mantenimiento).ToArray();
        }

        public IEnumerable<Mantenimiento> RecuperarPorEquipo(string numeroEconomico)
        {
            Equipo equipo = EquiposRepositorio.RecuperarPorNumeroEconomico(numeroEconomico);
            return equipo.Mantenimientosequipos.Select(s => s.Mantenimiento).ToArray();
        }

        public IEnumerable<Mantenimiento> RecuperarPorEquipo(Equipo equipo)
        {
            return equipo.Mantenimientosequipos.Select(s => s.Mantenimiento).ToArray();
        }
    }
}
