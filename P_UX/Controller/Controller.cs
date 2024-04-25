using P_UX.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P_UX.Controller
{
    public class Controller
    {

        //Création de la vue et du modele pour les lier au controller dans le constructeur
        private View _view;
        private Model.Model _model;

        //Gère l'internationalisation
        ResourceManager resManagerTraduction;

        /// <summary>
        /// Controleur
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public Controller(View view, Model.Model model)
        {
            _view = view;
            _model = model;
            _view.Controller = this;
            _model.Controller = this;
        }

        /// <summary>
        /// Crée un nouveau ressource manager en fonction de la langue courante
        /// </summary>
        /// <param name="langue"></param>
        /// <returns></returns>
        public ResourceManager NewCurrentLanguage(int langue)
        {
            switch (langue)
            {
                case 0:
                    resManagerTraduction = new ResourceManager(typeof(French));
                    break;
                case 1:
                    resManagerTraduction = new ResourceManager(typeof(English));
                    break;
                case 2:
                    resManagerTraduction = new ResourceManager(typeof(Spanish));
                    break;
                case 3:
                    resManagerTraduction = new ResourceManager(typeof(German));
                    break;
                case 4:
                    resManagerTraduction = new ResourceManager(typeof(Italian));
                    break;
                default:
                    MessageBox.Show("La langue séléctionnée n'est pas disponible");
                    break;
            }

            return resManagerTraduction;
        }
    }
}
