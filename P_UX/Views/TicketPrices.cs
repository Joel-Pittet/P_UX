///Auteur: Joël Pittet
///Date: 30.05.2024
///Lieu: ETML - VENNES
///Description: Vue pour choisir le nombre de billets voulus
///
using System;
using System.Resources;
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
        private string _btnOne = "";
        private string _btnTwo = "";
        private string _btnThree = "";
        private string _btnFour = "";
        private string _btnFive = "";
        private string _btnSix = "";
        private string _btnSeven = "";
        private string _btnHeight = "";

        /// <summary>
        /// Prix courant du billet selon tarif et type de billets
        /// </summary>
        private double _actualPrice;

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

            double priceTxtBx = _actualPrice * nbTicketsWanted;

            lblPriceTxtBx.Text = Convert.ToString(Math.Round(priceTxtBx, 2));
        }


        /// <summary>
        /// Ajoute le prix du billet seléctionné dans le texte des btn des tickets
        /// </summary>
        public void ShowTicketPriceOnBtn(bool isFullPrice)
        {
            if (isFullPrice)
            {
                _actualPrice = Controller.ReturnFullPrice();

                UpdateBtnNameWithPrices();

            }
            else
            {
                _actualPrice = Controller.CalculateTicketPriceHalfFare();

                UpdateBtnNameWithPrices();
            }
        }

        /// <summary>
        /// Met à jour le texte des boutons pour affiche le prix a coté du nombre
        /// </summary>
        private void UpdateBtnNameWithPrices()
        {
            btnOnce.Text = btnOnce.Text + $"  ({Math.Round(_actualPrice, 2)} €)";
            btnTwice.Text = btnTwice.Text + $"  ({Math.Round(_actualPrice * 2, 2)} €)";
            btnThreeTimes.Text = btnThreeTimes.Text + $"  ({Math.Round(_actualPrice * 3, 2)} €)";
            btnFourTimes.Text = btnFourTimes.Text + $"  ({Math.Round(_actualPrice * 4, 2)} €)";
            btnFiveTimes.Text = btnFiveTimes.Text + $"  ({Math.Round(_actualPrice * 5, 2)} €)";
            btnSixTimes.Text = btnSixTimes.Text + $"  ({Math.Round(_actualPrice * 6, 2)} €)";
            btnSevenTimes.Text = btnSevenTimes.Text + $"  ({Math.Round(_actualPrice * 7, 2)} €)";
            btnHeightTimes.Text = btnHeightTimes.Text + $"  ({Math.Round(_actualPrice * 8, 2)} €)";
        }


        /// <summary>
        /// Stocke le nom des boutons de base pour pouvoir les réaffichés si l'utilisateur fais retour
        /// </summary>
        public void GetBaseNameBtn()
        {
            _btnOne = btnOnce.Text;
            _btnTwo = btnTwice.Text;
            _btnThree = btnThreeTimes.Text;
            _btnFour = btnFourTimes .Text;

            _btnFive = btnFiveTimes .Text;
            _btnSix = btnSixTimes .Text;
            _btnSeven = btnSevenTimes .Text;
            _btnHeight = btnHeightTimes.Text;
        }

        /// <summary>
        /// Réaffiche le text de base sur les bontons
        /// </summary>
        public void ResetBtnName()
        {
            btnOnce.Text = _btnOne;
            btnTwice.Text = _btnTwo;
            btnThreeTimes.Text = _btnThree;
            btnFourTimes.Text = _btnFour;
            btnFiveTimes.Text = _btnFive;
            btnSixTimes.Text = _btnSix;
            btnSevenTimes.Text = _btnSeven;
            btnHeightTimes.Text = _btnHeight;
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
            Controller.ShowOrderResume(_actualPrice, 1);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwice_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(_actualPrice, 2);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThreeTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(_actualPrice, 3);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFourTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(_actualPrice, 4);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiveTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(_actualPrice, 5);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSixTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(_actualPrice, 6);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSevenTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(_actualPrice, 7);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHeightTimes_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(_actualPrice, 8);
        }

        /// <summary>
        /// Affiche le résumé de la commande et retourne le prix du billet et le nombre de fois au controleur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddTickets_Click(object sender, EventArgs e)
        {
            Controller.ShowOrderResume(_actualPrice, Convert.ToInt32(txtBxNbrTickets.Text));
        }
    }
}
