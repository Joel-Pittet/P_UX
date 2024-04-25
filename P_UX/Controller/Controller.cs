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
        private MainView _mainView;
        private Model.Model _model;
        private TicketsSelection _ticketsSelection;

        //Gère l'internationalisation
        ResourceManager resManagerTraduction;

        /// <summary>
        /// Controleur
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public Controller(MainView view, TicketsSelection ticketsSelection, Model.Model model)
        {
            _mainView = view;
            _model = model;
            _ticketsSelection = ticketsSelection;
            _ticketsSelection.Controller = this;
            _mainView.Controller = this;
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

        /// <summary>
        /// Affiche une Form et en cache une autre
        /// </summary>
        /// <param name="formToHide">Form à cacher</param>
        /// <param name="formToShow">Form à afficher</param>
        public void ChangeForm(Form formToHide, Form formToShow)
        {
            Form viewToShow = formToShow;

            formToHide.Hide();
            viewToShow.Show();
        }

        /// <summary>
        /// Affiche la vue de selection des tickets
        /// </summary>
        public void ShowTicketsSelection()
        { 
            ChangeForm(_mainView, _ticketsSelection);
        }
    }
}
