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

namespace P_UX.Views
{
    public partial class TicketPrices : Form
    {
        /// <summary>
        /// Controller par défaut
        /// </summary>
        public Controller.Controller Controller { get; set; }

        //Texte de base des boutons
        string btnOne = "";
        string btnTwo = "";
        string btnThree = "";
        string btnFour = "";

        string btnFive = "";
        string btnSix = "";
        string btnSeven = "";
        string btnHeight = "";

        /// <summary>
        /// Prix courant du billet selon tarif et type de billets
        /// </summary>
        double actualPrice;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public TicketPrices()
        {
            InitializeComponent();

            lblPriceTxtBx.Text = Convert.ToString(0);

            GetBaseNameBtn();
        }


        /// <summary>
        /// Affiche le prix si un nombre est entré dans la textBox
        /// </summary>
        public void CalculateNnTicketPrice()
        {
            int nbTicketsWanted = Convert.ToInt32(txtBxNbrTickets.Text);

            double priceTxtBx = actualPrice * nbTicketsWanted;

            lblPriceTxtBx.Text = Convert.ToString(Math.Round(priceTxtBx, 2));
        }


        /// <summary>
        /// Ajoute le prix du billet seléctionné dans le texte des btn des tickets
        /// </summary>
        public void ShowTicketPriceOnBtn(bool isFullPrice)
        {
            if (isFullPrice)
            {
                actualPrice = Controller.ReturnFullPrice();

                UpdateBtnNameWithPrices();

            }
            else
            {
                actualPrice = Controller.CalculateTicketPriceHalfFare();

                UpdateBtnNameWithPrices();
            }
        }

        /// <summary>
        /// Met à jour le texte des boutons pour affiche le prix a coté du nombre
        /// </summary>
        private void UpdateBtnNameWithPrices()
        {
            btnOnce.Text = btnOnce.Text + $"  ({Math.Round(actualPrice, 2)} €)";
            btnTwice.Text = btnTwice.Text + $"  ({Math.Round(actualPrice * 2, 2)} €)";
            btnThreeTimes.Text = btnThreeTimes.Text + $"  ({Math.Round(actualPrice * 3, 2)} €)";
            btnFourTimes.Text = btnFourTimes.Text + $"  ({Math.Round(actualPrice * 4, 2)} €)";
            btnFiveTimes.Text = btnFiveTimes.Text + $"  ({Math.Round(actualPrice * 5, 2)} €)";
            btnSixTimes.Text = btnSixTimes.Text + $"  ({Math.Round(actualPrice * 6, 2)} €)";
            btnSevenTimes.Text = btnSevenTimes.Text + $"  ({Math.Round(actualPrice * 7, 2)} €)";
            btnHeightTimes.Text = btnHeightTimes.Text + $"  ({Math.Round(actualPrice * 8, 2)} €)";
        }


        /// <summary>
        /// Stocke le nom des boutons de base pour pouvoir les réaffichés si l'utilisateur fais retour
        /// </summary>
        public void GetBaseNameBtn()
        {
            btnOne = btnOnce.Text;
            btnTwo = btnTwice.Text;
            btnThree = btnThreeTimes.Text;
            btnFour = btnFourTimes .Text;

            btnFive = btnFiveTimes .Text;
            btnSix = btnSixTimes .Text;
            btnSeven = btnSevenTimes .Text;
            btnHeight = btnHeightTimes.Text;
        }

        /// <summary>
        /// Réaffiche le text de base sur les bontons
        /// </summary>
        public void ResetBtnName()
        {
            btnOnce.Text = btnOne;
            btnTwice.Text = btnTwo;
            btnThreeTimes.Text = btnThree;
            btnFourTimes.Text = btnFour;
            btnFiveTimes.Text = btnFive;
            btnSixTimes.Text = btnSix;
            btnSevenTimes.Text = btnSeven;
            btnHeightTimes.Text = btnHeight;
        }

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

            UpdateBtnNameWithPrices();
        }

        /// <summary>
        /// Change la langue de l'interface: Anglais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnANG_Click(object sender, EventArgs e)
        {
            Controller.SwitchCurrentLanguage(P_UX.Controller.Controller.Language.ENG);

            UpdateBtnNameWithPrices();
        }

        /// <summary>
        /// Change la langue de l'interface: Espagnol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnESP_Click(object sender, EventArgs e)
        {
            Controller.SwitchCurrentLanguage(P_UX.Controller.Controller.Language.ESP);

            UpdateBtnNameWithPrices();
        }

        /// <summary>
        /// Change la langue de l'interface: Allemand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDEU_Click(object sender, EventArgs e)
        {
            Controller.SwitchCurrentLanguage(P_UX.Controller.Controller.Language.DEU);

            UpdateBtnNameWithPrices();
        }

        /// <summary>
        /// Change la langue de l'interface: Italien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnITA_Click(object sender, EventArgs e)
        {
            Controller.SwitchCurrentLanguage(P_UX.Controller.Controller.Language.ITA);

            UpdateBtnNameWithPrices();
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
            ResetBtnName();

            Controller.ShowTypeOfRateFromTicketsPrice();
        }

        /// <summary>
        /// Affiche la page principale
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetBtnName();

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
        /// Calcule le prix de la textbox et l'affiche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxNbrTickets_TextChanged(object sender, EventArgs e)
        {
            if (txtBxNbrTickets.Text != string.Empty)
            {
                CalculateNnTicketPrice();
            }
            else
            {
                lblPriceTxtBx.Text = Convert.ToString(0);
            }
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOnce_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(actualPrice, 1);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwice_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(actualPrice, 2);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThreeTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(actualPrice, 3);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFourTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(actualPrice, 4);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiveTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(actualPrice, 5);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSixTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(actualPrice, 6);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSevenTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(actualPrice, 7);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHeightTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(actualPrice, 8);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTickets_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(actualPrice, Convert.ToInt32(txtBxNbrTickets.Text));
        }
    }
}
