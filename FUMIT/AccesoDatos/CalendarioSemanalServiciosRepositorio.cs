using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUMIT.Entidades;


namespace FUMIT.AccesoDatos
{
    public class CalendarioSemanalServiciosRepositorio : AOperacionesBase<Entidades.UspCalendarioSemanalServiciosReturnModel>, ICalendarioSemanalServicios
    {
        public IEnumerable<UspCalendarioSemanalServiciosReturnModel> RecuperarCalendarioSemanal(DateTime fechaInicio, DateTime fechaFin)
        {
            FumitDbContext fumitDbContext = dbContext as FumitDbContext;
            return fumitDbContext.UspCalendarioSemanalServicios(fechaInicio, fechaFin);
        }
    }
}
