using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_UX
{
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //création de la vue principale
            MainView aView = new MainView();

            //Selection de billet
            TicketsSelection aticketsSelection = new TicketsSelection();

            //Création du modele
            Model.Model aModel = new Model.Model();

            //Création du controller
            Controller.Controller aController = new Controller.Controller(aView, aticketsSelection, aModel);

            Application.Run(aView);
        }
    }
}
