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
    public partial class View : Form
    {
       
        /// <summary>
        /// Langues disponibles
        /// </summary>
        enum Language { FRA, DEU, ITA, ANG }

        /// <summary>
        /// Langue courante du programme
        /// </summary>
        Language currentLanguage;

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
        public View()
        {
            InitializeComponent();
        }


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
        /// Change la langue de l'interface: Français
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFRA_Click(object sender, EventArgs e)
        {
            //Change la langue courante
            currentLanguage = Language.FRA;

            //Donne la langue au controller et récupère le ressourceManager associé
            _resManagerTraduction = Controller.NewCurrentLanguage(Convert.ToInt32(currentLanguage));

            //Met à jour la langue dans l'interface
            UpdateLanguage(_resManagerTraduction);
        }

        private void btnANG_Click(object sender, EventArgs e)
        {

        }
    }
}
