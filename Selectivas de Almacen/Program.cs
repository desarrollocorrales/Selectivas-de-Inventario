﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Selectivas_de_Almacen.GUIs;

namespace Selectivas_de_Almacen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Principal());
        }
    }
}
