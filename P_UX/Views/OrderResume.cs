using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_UX.Controller
{
    public partial class OrderResume : Form
    {
        /// <summary>
        /// Lie la vue au controleur
        /// </summary>
        public Controller Controller { get; set; }

        /// <summary>
        /// Nombre de billet minimum dans une commande
        /// </summary>
        private const int _MINIMUM_NBR_TICKETS_TO_ORDER = 1;

        /// <summary>
        /// Constrcucteur
        /// </summary>
        public OrderResume()
        {
            InitializeComponent();
        }

        /*
        private void SetButtonsAndLabelsForNewTickets(int levelLine)
        {
            //Bouton moins
            Button btnMinus = new Button();
            btnMinus.Text = "-";
            btnMinus.Size = new Size(48, 46);
            btnMinus.Location = new Point(45, 140);
            this.Controls.Add(btnMinus);

            //Label nombre de billets
            Label lblTicketsTimes = new Label();
            lblTicketsTimes.Text = Convert.ToString(Controller.TicketTimesWanted);
            lblTicketsTimes.Width = 10;
            lblTicketsTimes.Location = new Point(115, 161);
            this.Controls.Add(lblTicketsTimes);

            //Bouton plus
            Button btnPlus = new Button();
            btnPlus.Text = "+";
            btnPlus.Size = new Size(48, 46);
            btnPlus.Location = new Point(150, 140);
            this.Controls.Add(btnPlus);
        }*/


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
            Controller.ShowTicketPriceFromOrderResume();
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

        /// <summary>
        /// Affiche les infos du billets sur le résumé de commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderResume_Activated(object sender, EventArgs e)
        {
            UpdateOrderInfos();
        }

        /// <summary>
        /// Ajoute un ticket de plus à la commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPlus_Click(object sender, EventArgs e)
        {
            Controller.TicketTimesWanted++;

            UpdateOrderInfos();
        }

        /// <summary>
        /// Met à jour les infos de la commande
        /// </summary>
        private void UpdateOrderInfos()
        {
            //Nb de ticket
            lblNbrTimesTicketsInNbr.Text = Convert.ToString(Controller.TicketTimesWanted);

            //Nom du billet
            lblTicketTitle.Text = Controller.NameTicketSelected;

            //Nom du tarif (plein / demi-tarif)
            lblTicketTarif.Text = Controller.ReturnTarif();

            //Prix du billet selon le nbr de fois
            lblTicketPrice.Text = Convert.ToString(Math.Round(Controller.PriceTicketSelected * Controller.TicketTimesWanted, 2));

            //Prix total de la commande
            lblTotalToPayInEuro.Text = lblTicketPrice.Text;

            if (Convert.ToInt32(lblNbrTimesTicketsInNbr.Text) <= 0)
            {
                //Remet le nombre de ticket voulu à 1
                Controller.TicketTimesWanted = _MINIMUM_NBR_TICKETS_TO_ORDER;

                //Affiche un message d'erreur
                MessageBox.Show("Le nombre de billet ne peut être inférieur à 1", "Nombre de billet invalide");
            }
        }

        /// <summary>
        /// Retire un billet de la commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMinus_Click(object sender, EventArgs e)
        {
            Controller.TicketTimesWanted--;

            UpdateOrderInfos();
        }
    }
}
