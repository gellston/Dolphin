using Notification.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class ToastMessageHelper
    {

        #region Private Property
        static private readonly INotificationManager notificationManager = new NotificationManager();
        #endregion

        public ToastMessageHelper()
        {

            
        }


        public static void ShowErrorMessage()
        {

        }

        public static void ShowSuccessMessage()
        {

        }
    }
}
