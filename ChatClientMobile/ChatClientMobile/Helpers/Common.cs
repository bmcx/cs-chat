using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChatClientMobile.Helpers
{
    class Common
    {
        public static void featureComingSoon()
        {
            var toastConfig = new ToastConfig("Feature will be added soon!");
            toastConfig.SetDuration(2000);
            toastConfig.SetBackgroundColor(System.Drawing.Color.FromArgb(242, 76, 101));
            UserDialogs.Instance.Toast(toastConfig);
        }
    }
}
