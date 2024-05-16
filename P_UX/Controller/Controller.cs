using P_UX.Resources;
using P_UX.Views;
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
        private TypeOfRate _typeOfRate;
        private TicketPrices _ticketPrices;

        //Gère l'internationalisation
        private ResourceManager _resManagerTraduction;

        /// <summary>
        /// Langues disponibles
        /// </summary>
        public enum Language { FRA, ANG, ESP, DEU, ITA }

        /// <summary>
        /// Langue courante index de l'enum
        /// </summary>
        private int _currentLanguage = 0;

        /// <summary>
        /// GETTER / SETTER
        /// Langue courante index de l'enum
        /// </summary>
        public int CurrentLanguage
        {
            get
            {
                return _currentLanguage;
            }
            set
            {
                _currentLanguage = value;
            }
        }

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
        public ResourceManager SwitchCurrentLanguage(int language)
        {
            switch (language)
            {
                case 0:
                    _resManagerTraduction = new ResourceManager(typeof(French));
                    break;
                case 1:
                    _resManagerTraduction = new ResourceManager(typeof(English));
                    break;
                case 2:
                    _resManagerTraduction = new ResourceManager(typeof(Spanish));
                    break;
                case 3:
                    _resManagerTraduction = new ResourceManager(typeof(German));
                    break;
                case 4:
                    _resManagerTraduction = new ResourceManager(typeof(Italian));
                    break;
                default:
                    MessageBox.Show("La langue séléctionnée n'est pas disponible");
                    break;
            }

            return _resManagerTraduction;
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

        /// <summary>
        /// Permet de récupérer la langue de l'enum
        /// </summary>
        /// <param name="language"></param>
        /// <returns></returns>
        public int FindLanguage(int language)
        {
            switch (language)
            {
                case 0:
                    _currentLanguage = 0;
                    return Convert.ToInt32(Language.FRA);
                    break;
                case 1:
                    _currentLanguage = 1;
                    return Convert.ToInt32(Language.ANG);
                    break;
                case 2:
                    _currentLanguage = 2;
                    return Convert.ToInt32(Language.ESP);
                    break;
                case 3:
                    _currentLanguage = 3;
                    return Convert.ToInt32(Language.DEU);
                    break;
                case 4:
                    _currentLanguage = 4;
                    return Convert.ToInt32(Language.ITA);
                    break;
                default :
                    _currentLanguage = 0;
                    return Convert.ToInt32(Language.FRA);
                    break;
            }

        }

    }
}
