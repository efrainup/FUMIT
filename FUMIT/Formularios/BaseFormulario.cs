using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.Formularios
{
    public class BaseFormulario : System.Windows.Forms.Form
    {
        public ExceptionManager FormExceptionManager { get; set; }

        public BaseFormulario()
        {
            Load += BaseUserControl_Load;
        }

        private void BaseUserControl_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                FormExceptionManager = CommonServiceLocator.ServiceLocator.Current.GetInstance<ExceptionManager>();
            }
        }
    }
}
