using P_UX.Model;
using P_UX.Resources;
using P_UX.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Principal;
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
        private TypeOfRate _typeOfRate;
        private TicketPrices _ticketPrices;

        //Gère l'internationalisation
        private ResourceManager _resManagerTraduction;

        /// <summary>
        /// Langues disponibles
        /// </summary>
        public enum Language { FRA, ENG, ESP, DEU, ITA }

        /// <summary>
        /// Langue courante index de l'enum
        /// </summary>
        private Language _currentLanguage = Language.FRA;

        /// <summary>
        /// Controleur
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public Controller(MainView view, TicketsSelection ticketsSelection, TypeOfRate typeOfRate, TicketPrices ticketPrices, Model.Model model)
        {
            _mainView = view;
            _model = model;
            _ticketsSelection = ticketsSelection;
            _typeOfRate = typeOfRate;
            _ticketPrices = ticketPrices;


            _ticketPrices.Controller = this;
            _typeOfRate.Controller = this;
            _ticketsSelection.Controller = this;
            _mainView.Controller = this;
            _model.Controller = this;
            
        }

        /// <summary>
        /// Crée un nouveau ressource manager en fonction de la langue courante
        /// </summary>
        /// <param name="langue"></param>
        /// <returns></returns>
        public ResourceManager SwitchCurrentLanguage(Language language)
        {
            _currentLanguage = language;

            switch (language)
            {
                case Language.FRA:
                    _resManagerTraduction = new ResourceManager(typeof(French));
                    break;
                case Language.ENG:
                    _resManagerTraduction = new ResourceManager(typeof(English));
                    break;
                case Language.ESP:
                    _resManagerTraduction = new ResourceManager(typeof(Spanish));
                    break;
                case Language.DEU:
                    _resManagerTraduction = new ResourceManager(typeof(German));
                    break;
                case Language.ITA:
                    _resManagerTraduction = new ResourceManager(typeof(Italian));
                    break;
                default:
                    MessageBox.Show("La langue séléctionnée n'est pas disponible");
                    break;
            }

            UpdateLanguageAllView();

            return _resManagerTraduction;
        }

        /// <summary>
        /// Met à jour la langue pour chaque vue
        /// </summary>
        public void UpdateLanguageAllView()
        {
            _mainView.ChangeLanguageOfControls(_resManagerTraduction);
            _ticketsSelection.ChangeLanguageOfControls(_resManagerTraduction);
            _typeOfRate.ChangeLanguageOfControls(_resManagerTraduction);
            _ticketPrices.ChangeLanguageOfControls(_resManagerTraduction);
            
        }


        /// <summary>
        /// Affiche une Form et en cache une autre
        /// </summary>
        /// <param name="formToHide">Form à cacher</param>
        /// <param name="formToShow">Form à afficher</param>
        public void ChangeForm(Form formToHide, Form formToShow)
        {
            formToHide.Hide();
            formToShow.Show();
        }

        #region Affichage des vues
        /// <summary>
        /// Affiche la vue principale
        /// </summary>
        public void ShowMainView()
        {
            ChangeForm(_ticketsSelection, _mainView);
        }


        /// <summary>
        /// Affiche la vue de selection des tickets
        /// </summary>
        public void ShowTicketsSelection()
        { 
            ChangeForm(_mainView, _ticketsSelection);
        }

        /// <summary>
        /// Affiche la vue des tarifs
        /// </summary>
        public void ShowTypeOfRate()
        {
            ChangeForm(_ticketsSelection, _typeOfRate);
        }

        /// <summary>
        /// Affiche la vue des prix des billets
        /// </summary>
        public void ShowTicketsPrice()
        {

        }


        #endregion

        /// <summary>
        /// Affiche la vue principale et ferme la vue en cours
        /// </summary>
        /// <param name="actualForm">Forme actuelle au moment du clic sur le bouton Annuler</param>
        public void CancelButton(Form actualForm)
        {
            ChangeForm(actualForm, _mainView);
        }

        /*/// <summary>
        /// Retourne le prix du billet séléctionné
        /// </summary>
        /// <param name="textLabelBtnClicked"></param>
        /// <returns></returns>
        public double GetTicketFullPrice()
        {
            double ticketPrice = 0;

            foreach (Tuple<string, double> ticket in _model.ListNameAndPriceTickets)
            {
                if ()
                {
                    ticketPrice = ticket.Item2;
                    break;
                }
            }

            return ticketPrice;
        }*/
    }
}
