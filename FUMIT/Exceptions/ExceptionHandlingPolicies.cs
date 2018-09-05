using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FUMIT.Exceptions
{
    public static class ExceptionHandlingPolicies
    {
        static List<ExceptionPolicyDefinition> policies = new List<ExceptionPolicyDefinition>();
        public const string CrearActualizarEntidadesDesdeUI = "CrearActualizarEntidadesDesdeUI";


        public static ExceptionManager InicializarPoliticas()
        {
            //LoggingConfiguration conf = ;
            //conf.AddLogSource("General", System.Diagnostics.SourceLevels.Error,true, new System.Diagnostics.EventLogTraceListener());
            //LogWriter logWriter = new LogWriterFactory().Create();


            policies.Add(new ExceptionPolicyDefinition(CrearActualizarEntidadesDesdeUI, new ExceptionPolicyEntry[] {
                new ExceptionPolicyEntry(typeof(System.Data.Entity.Validation.DbEntityValidationException),PostHandlingAction.None,new IExceptionHandler[]{
                    new NotificarUsuarioEFValidationExceptionHandler()
                }),
                new ExceptionPolicyEntry(typeof(Exception),PostHandlingAction.None,new IExceptionHandler[]{
                    //new LoggingExceptionHandler("General",10,System.Diagnostics.TraceEventType.Error,"Ocurrió una excepción no controlada",10,typeof(Exception),logWriter),
                    new NotificarUsuarioMessageBoxExceptionHandler()
                })
                //,
                //new ExceptionPolicyEntry(typeof(ArgumentNullException),PostHandlingAction.None,new IExceptionHandler[]{
                //    new NotificarUsuarioMessageBoxExceptionHandler()
                //})

            }));

            return new ExceptionManager(policies);
        }
    }
    

    class NotificarUsuarioEFValidationExceptionHandler : IExceptionHandler
    {
        public Exception HandleException(Exception exception, Guid handlingInstanceId)
        {
            System.Data.Entity.Validation.DbEntityValidationException excepcionValidacion = exception as System.Data.Entity.Validation.DbEntityValidationException;
            
                string Mensaje = "";
                foreach (System.Data.Entity.Validation.DbEntityValidationResult validacion in excepcionValidacion.EntityValidationErrors)
                {

                    foreach (DbValidationError errorvalidacion in validacion.ValidationErrors)
                    {
                        Mensaje += $"•{errorvalidacion.ErrorMessage}";
                        //this.Controls[0].DataBindings.Add()
                    }

                }

                //Se notifica al usuario a través de MessageBox
                System.Windows.Forms.MessageBox.Show(Mensaje, "Errores de validacion");

            return excepcionValidacion;
        }
    }

    class NotificarUsuarioMessageBoxExceptionHandler : IExceptionHandler
    {
        public Exception HandleException(Exception exception, Guid handlingInstanceId)
        {
            System.Windows.Forms.MessageBox.Show("Se produjo un error. Favor de intentar nuevamente", "Error");
            return exception;
        }
    }
}
