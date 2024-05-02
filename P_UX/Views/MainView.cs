using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_UX
{
    public partial class MainView : Form
    {
       
        /// <summary>
        /// Langues disponibles
        /// </summary>
        enum Language { FRA, ANG, ESP, DEU, ITA }

        /// <summary>
        /// Ressource Manager pour gérer les langues
        /// </summary>
        ResourceManager _resManagerTraduction;

        /// <summary>
        /// Controller par défaut
        /// </summary>
        public Controller.Controller Controller { get; set; }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public MainView()
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
            UpdateCurrentLanguage(Language.FRA);
        }

        /// <summary>
        /// Change la langue de l'interface: Anglais
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnANG_Click(object sender, EventArgs e)
        {
            UpdateCurrentLanguage(Language.ANG);
        }

        /// <summary>
        /// Change la langue de l'interface: Espagnol
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnESP_Click(object sender, EventArgs e)
        {
            UpdateCurrentLanguage(Language.ESP);
        }

        /// <summary>
        /// Change la langue de l'interface: Allemand
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDEU_Click(object sender, EventArgs e)
        {
            UpdateCurrentLanguage(Language.DEU);
        }

        /// <summary>
        /// Change la langue de l'interface: Italien
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnITA_Click(object sender, EventArgs e)
        {
            UpdateCurrentLanguage(Language.ITA);
        }

        #endregion

        /// <summary>
        /// Parcourt chaque controls et traduit le nom dans la langue demandée
        /// </summary>
        /// <param name="resManagerTraduction"></param>
        public void UpdateLanguage(ResourceManager resManagerTraduction)
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

        /// <summary>
        /// Met à jour la langue courante pour tous les controls
        /// </summary>
        /// <param name="lang"></param>
        private void UpdateCurrentLanguage(Language lang)
        {
            //Donne la langue au controller et récupère le ressourceManager associé
            _resManagerTraduction = Controller.NewCurrentLanguage(Convert.ToInt32(lang));

            //Met à jour la langue dans l'interface
            UpdateLanguage(_resManagerTraduction);
        }

        #endregion

        /// <summary>
        /// Redirection vers choix des billets
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuyTickets_Click(object sender, EventArgs e)
        {
            Controller.ShowTicketsSelection();
        }

        
    }
}
