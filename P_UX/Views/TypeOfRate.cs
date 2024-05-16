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
        /// Ressource Manager pour gérer les langues
        /// </summary>
        ResourceManager _resManagerTraduction;

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

        /// <summary>
        /// Récupère la langue courante et l'applique sur la form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypeOfRate_Activated(object sender, EventArgs e)
        {
            GetLanguageToApply(Controller.CurrentLanguage);
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
            GetLanguageToApply(Controller.FindLanguage(0));
        }

        /// <summary>
        /// Change la langue de l'interface: Anglais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnANG_Click(object sender, EventArgs e)
        {
            GetLanguageToApply(Controller.FindLanguage(1));
        }

        /// <summary>
        /// Change la langue de l'interface: Espagnol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnESP_Click(object sender, EventArgs e)
        {
            GetLanguageToApply(Controller.FindLanguage(2));
        }

        /// <summary>
        /// Change la langue de l'interface: Allemand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDEU_Click(object sender, EventArgs e)
        {
            GetLanguageToApply(Controller.FindLanguage(3));
        }

        /// <summary>
        /// Change la langue de l'interface: Italien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnITA_Click(object sender, EventArgs e)
        {
            GetLanguageToApply(Controller.FindLanguage(4));
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
        /// Récupère le ressource manager de la bonne langue et applique la langue au formulaiure
        /// </summary>
        /// <param name="languageToApply"></param>
        public void GetLanguageToApply(int languageToApply)
        {
            _resManagerTraduction = Controller.SwitchCurrentLanguage(languageToApply);

            ChangeLanguageOfControls(_resManagerTraduction);
        }


        /// <summary>
        /// Parcourt chaque controls et traduit le nom dans la langue demandée
        /// </summary>
        /// <param name="resManagerTraduction"></param>
        public void ChangeLanguageOfControls(ResourceManager resManagerTraduction)
        {
            _resManagerTraduction = resManagerTraduction;

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

        }
    }
}
