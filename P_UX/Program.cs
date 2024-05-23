using P_UX.Controller;
using P_UX.Views;
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
            MainView aMainView = new MainView();

            //Selection de billet
            TicketsSelection aTicketsSelection = new TicketsSelection();

            //Selection du tarif
            TypeOfRate aTypeOfRate = new TypeOfRate();

            //Prix du ticket
            TicketPrices aTicketPrices = new TicketPrices();

            //Résumé de la commande
            OrderResume aOrderResume = new OrderResume();

            //Paris visite
            ParisVisit aParisVisit = new ParisVisit();

            //Création du modele
            Model.Model aModel = new Model.Model();

            //Création du controller
            Controller.Controller aController = new Controller.Controller(aMainView, aTicketsSelection, aTypeOfRate, aTicketPrices, aOrderResume, aParisVisit, aModel);

            //Lance la vue principale
            Application.Run(aMainView);
        }
    }
}
