using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.Logging.Formatters;
using Microsoft.Practices.EnterpriseLibrary.Logging.TraceListeners;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
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
            TextFormatter formatterF = new TextFormatter("Timestamp:...");

            var flatFileTraceListener = new FlatFileTraceListener(@"c:\fumit.log");
            

            var eventLog = new EventLog("Application", ".", "Enterprise Library Logging");
            var eventLogTraceListener = new FormattedEventLogTraceListener(eventLog);


            LoggingConfiguration conf = new LoggingConfiguration();
            conf.AddLogSource("General", System.Diagnostics.SourceLevels.All,true, flatFileTraceListener);
            conf.SpecialSources.LoggingErrorsAndWarnings.AddTraceListener(eventLogTraceListener);
            conf.SpecialSources.LoggingErrorsAndWarnings.AddTraceListener(flatFileTraceListener);
            
            LogWriter logWriter = new LogWriter(conf); //new LogWriterFactory().Create();
            
            //var v = new  RollingFlatFileTraceListener("",)
            //logWriter.Configure((A) => A.AddLogSource("General", new System.Diagnostics.ConsoleTraceListener(), eventLogTraceListener));


            policies.Add(new ExceptionPolicyDefinition(CrearActualizarEntidadesDesdeUI, new ExceptionPolicyEntry[] {
                new ExceptionPolicyEntry(typeof(System.Data.Entity.Validation.DbEntityValidationException),PostHandlingAction.None,new IExceptionHandler[]{
                    new NotificarUsuarioEFValidationExceptionHandler()
                }),
                new ExceptionPolicyEntry(typeof(Exception),PostHandlingAction.None,new IExceptionHandler[]{
                    new LoggingExceptionHandler("Error",10,System.Diagnostics.TraceEventType.Error,"Ocurrió una excepción no controlada",10,typeof(TextExceptionFormatter),logWriter),
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
                        Mensaje += $"•{errorvalidacion.ErrorMessage}\r\n";
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

    class CustomFormatter : Microsoft.Practices.EnterpriseLibrary.ExceptionHandling.ExceptionFormatter
    {
        TextWriter mytextWriter;
        Exception myexception;
        public CustomFormatter(TextWriter textWriter,Exception exception, Guid guid) : base(exception,guid)
        {
            mytextWriter = textWriter;
            myexception = exception;
        }

        protected override void WriteAdditionalInfo(NameValueCollection additionalInformation)
        {
            for (int i = 0; i < additionalInformation.Count; i++)
            {
                mytextWriter.WriteLine(additionalInformation.GetKey(i) +": "+ additionalInformation.GetValues(i));
            }
        }

        protected override void WriteDateTime(DateTime utcNow)
        {
            mytextWriter.WriteLine(utcNow);
        }

        protected override void WriteDescription()
        {
            mytextWriter.WriteLine("Ocurrio una escepcion");
        }

        protected override void WriteExceptionType(Type exceptionType)
        {
            mytextWriter.WriteLine(exceptionType.ToString());
        }

        protected override void WriteFieldInfo(FieldInfo fieldInfo, object value)
        {
            mytextWriter.WriteLine(fieldInfo.Name + value);
        }

        protected override void WriteHelpLink(string helpLink)
        {
            mytextWriter.WriteLine(helpLink);
        }

        protected override void WriteMessage(string message)
        {
            mytextWriter.WriteLine(message);
        }

        protected override void WritePropertyInfo(PropertyInfo propertyInfo, object value)
        {
            mytextWriter.WriteLine(propertyInfo.Name + value);
        }

        protected override void WriteSource(string source)
        {
            mytextWriter.WriteLine(source);
        }

        protected override void WriteStackTrace(string stackTrace)
        {
            mytextWriter.WriteLine(stackTrace);
        }
    }
}
