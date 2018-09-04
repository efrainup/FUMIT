using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FUMIT.Formularios
{
    public class BaseUserControl : System.Windows.Forms.UserControl
    {
        public ExceptionManager FormExceptionManager { get; set; }

        public BaseUserControl()
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
