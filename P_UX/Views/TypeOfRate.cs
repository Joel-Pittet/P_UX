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
    public partial class TypeOfRate : Form
    {

        /// <summary>
        /// Controller par défaut
        /// </summary>
        public Controller Controller { get; set; }

        /// <summary>
        /// Constructeur
        /// </summary>
        public TypeOfRate()
        {
            InitializeComponent();
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
            Controller.ShowTicketsSelectionFromTypeOfRate();
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
        /// Affiche les prix du billet selectionné en plein tarif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFullFare_Click(object sender, EventArgs e)
        {
            Controller.ShowTicketsPrice(true);
        }

        /// <summary>
        /// Affiche les prix du billet selectionné en demi tarif
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHalfFare_Click(object sender, EventArgs e)
        {
            Controller.ShowTicketsPrice(false);
        }
    }
}
