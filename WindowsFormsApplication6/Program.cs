using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace WindowsFormsApplication6
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {


            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("Stardust");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //var K = new DateTime(2014,10,15,08,17,0,DateTimeKind.Local);
            ////K = 17.09.2013 0:00:00;
            //DateTime k1 = K.AddDays(360);
            //if (DateTime.Now <= k1)
            //{
                Application.Run(new audentification());
            //}
            //else                                                                                                             { Application.Exit(); }
        }
    }
}
