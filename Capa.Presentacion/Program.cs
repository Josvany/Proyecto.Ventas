﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Capa.Presentacion
{
    static class Program
    {
        public static Guid UserIntId = Guid.Empty;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MasterContain());
        }
    }
}
