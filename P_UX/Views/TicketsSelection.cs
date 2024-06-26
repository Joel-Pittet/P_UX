﻿///Auteur: Joël Pittet
///Date: 30.05.2024
///Lieu: ETML - VENNES
///Description: Vue pour choisir le type de billet souhaité
///

using System;
using System.Resources;
using System.Windows.Forms;

namespace P_UX
{
    public partial class TicketsSelection : Form
    {
        /// <summary>
        /// Controller par défaut
        /// </summary>
        public Controller.Controller Controller { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public TicketsSelection()
        {
            InitializeComponent();
        }

        #region Tickets Disponibles

        /// <summary>
        /// Affiche la vue des tarifs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTicketT_Click(object sender, EventArgs e)
        {
            Controller.NameTicketSelected = "Billet t+";

            Controller.ShowTypeOfRate(btnTicketT.Name);
        }

        /// <summary>
        /// Affiche la vue des tarifs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTicketParisRegion_Click(object sender, EventArgs e)
        {
            Controller.NameTicketSelected = "Billet Paris Region";

            Controller.ShowTypeOfRate(btnTicketParisRegion.Name);
        }

        /// <summary>
        /// Affiche la vue des tarifs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTicketDisney_Click(object sender, EventArgs e)
        {
            Controller.NameTicketSelected = "Billet Disneyland Paris";

            Controller.ShowTypeOfRate(btnTicketDisney.Name);
        }

        /// <summary>
        /// Affiche la vue des tarifs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTicketParisVisit_Click(object sender, EventArgs e)
        {
            Controller.NameTicketSelected = "Billet Paris Visite";

            Controller.ShowTypeOfRate(btnTicketParisVisit.Name);
        }


        /// <summary>
        /// Affiche la vue des tarifs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTicketAirport_Click(object sender, EventArgs e)
        {
            Controller.NameTicketSelected = "Billet Aéroport";

            Controller.ShowTypeOfRate(btnTicketAirport.Name);
        }

        /// <summary>
        /// Affiche la vue des tarifs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTicketMobilis_Click(object sender, EventArgs e)
        {
            Controller.NameTicketSelected = "Billet Mobilis";

            Controller.ShowTypeOfRate(btnTicketMobilis.Name);
        }


        #endregion

        #region Footer

        #region Boutons Langues

        /// <summary>
        /// Change la langue de l'interface: Français
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFRA_Click(object sender, EventArgs e)
        {
            Controller.SwitchCurrentLanguage(P_UX.Controller.Controller.Language.FRA);
        }

        /// <summary>
        /// Change la langue de l'interface: Anglais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnANG_Click(object sender, EventArgs e)
        {
            Controller.SwitchCurrentLanguage(P_UX.Controller.Controller.Language.ENG);
        }

        /// <summary>
        /// Change la langue de l'interface: Espagnol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnESP_Click(object sender, EventArgs e)
        {
            Controller.SwitchCurrentLanguage(P_UX.Controller.Controller.Language.ESP);
        }

        /// <summary>
        /// Change la langue de l'interface: Allemand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDEU_Click(object sender, EventArgs e)
        {
            Controller.SwitchCurrentLanguage(P_UX.Controller.Controller.Language.DEU);
        }

        /// <summary>
        /// Change la langue de l'interface: Italien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnITA_Click(object sender, EventArgs e)
        {
            Controller.SwitchCurrentLanguage(P_UX.Controller.Controller.Language.ITA);
        }

        #endregion

        #region Bouton retour et annuler

        /// <summary>
        /// Bouton retour, affiche la page principale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Controller.ShowMainView();
        }

        /// <summary>
        /// Affiche la page principale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Controller.CancelButton(this);
        }

        #endregion

        /// <summary>
        /// Parcourt chaque controls et traduit le nom dans la langue demandée
        /// </summary>
        /// <param name="resManagerTraduction"></param>
        public void ChangeLanguageOfControls(ResourceManager resManagerTraduction)
        { 
            foreach (Control control in Controls)
            {
                if (resManagerTraduction.GetString(control.Name) != null)
                {
                    control.Text = resManagerTraduction.GetString(control.Name);
                }
            }
        }

        #endregion
    }
}
