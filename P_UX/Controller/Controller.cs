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
        private OrderResume _orderResume;
        private ParisVisit _parisVisit;
        private PaymentOptions _paymentOptions;
        private Payment _payment;

        //Gère l'internationalisation
        private ResourceManager _resManagerTraduction;

        /// <summary>
        /// Langues disponibles
        /// </summary>
        public enum Language { FRA, ENG, ESP, DEU, ITA }

        /// <summary>
        /// Langue courante
        /// </summary>
        private Language _currentLanguage = Language.FRA;

        /// <summary>
        /// Prix du billet seléctionné
        /// </summary>
        private double _priceTicketSelected;

        /// <summary>
        /// GETTER / SETTER
        /// Prix du billet seléctionné
        /// </summary>
        public double PriceTicketSelected
        {
            get
            {
                return _priceTicketSelected;
            }
            private set
            {
                _priceTicketSelected = value;
            }
        }

        /// <summary>
        /// Nombre de fois que le billet est souhaité
        /// </summary>
        private int _ticketTimesWanted;

        /// <summary>
        /// GETTER / SETTER
        /// Nombre de fois que le billet est souhaité
        /// </summary>
        public int TicketTimesWanted
        {
            get
            {
                return _ticketTimesWanted;
            }
            set
            {
                _ticketTimesWanted = value;
            }
        }

        /// <summary>
        /// Nom du billet choisi
        /// </summary>
        private string _nameTicketSelected;

        /// <summary>
        /// Si le tarif est plein ou demi
        /// </summary>
        private bool _isFullPrice;

        /// <summary>
        /// GETTER / SETTER
        /// Si le tarif est plein ou demi
        /// </summary>
        public bool isFullPrice
        {
            get
            {
                return _isFullPrice;
            }
            set
            {
                _isFullPrice = value;
            }
        }

        /// <summary>
        /// GETTER / SETTER
        /// Nom du billet choisi
        /// </summary>
        public string NameTicketSelected
        {
            get
            {
                return _nameTicketSelected;
            }
            set
            {
                _nameTicketSelected = value;
            }
        }

        /// <summary>
        /// Nom du bouton par rapport au billet sélectionné pour géréer la differenc d'affichage entre billet standart et spéciaux
        /// </summary>
        private string _buttonName;

        /// <summary>
        /// Montant final de la commande
        /// </summary>
        private string _finalAmountToPay;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="view"></param>
        /// <param name="model"></param>
        public Controller(MainView view, TicketsSelection ticketsSelection, TypeOfRate typeOfRate, TicketPrices ticketPrices, 
                            OrderResume orderResume, ParisVisit parisVisite, PaymentOptions paymentOptions, Payment payment, Model.Model model)
        {
            _mainView = view;
            _model = model;
            _ticketsSelection = ticketsSelection;
            _typeOfRate = typeOfRate;
            _ticketPrices = ticketPrices;
            _orderResume = orderResume;
            _parisVisit = parisVisite;
            _paymentOptions = paymentOptions;
            _payment = payment;

            _payment.Controller = this;
            _paymentOptions.Controller = this;
            _parisVisit.Controller = this;
            _orderResume.Controller = this;
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
        public void SwitchCurrentLanguage(Language language)
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
            _orderResume.ChangeLanguageOfControls (_resManagerTraduction);
            _parisVisit.ChangeLanguageOfControls(_resManagerTraduction);
            _paymentOptions.ChangeLanguageOfControls(_resManagerTraduction);
            _payment.ChangeLanguageOfControls(_resManagerTraduction);
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
        /// Affiche la vue de selection des tickets depuis TypeOfRate
        /// </summary>
        public void ShowTicketsSelectionFromTypeOfRate()
        {
            ChangeForm(_typeOfRate, _ticketsSelection);
        }


        /// <summary>
        /// Affiche la vue des tarifs et récupère le prix du billet seléctionné
        /// Récupère le nom du bouton séléctionné
        /// </summary>
        public void ShowTypeOfRate(string nameOfButton)
        {
            _buttonName = nameOfButton;

            _model.FullPriceTicketSelectioned = GetTicketFullPrice(nameOfButton);

            ChangeForm(_ticketsSelection, _typeOfRate);
        }

        /// <summary>
        /// Affiche la vue des tarif après avoir fait retour sur la vue des prix du ticket
        /// </summary>
        public void ShowTypeOfRateFromTicketsPrice()
        {
            ChangeForm(_ticketPrices, _typeOfRate);
        }

        /// <summary>
        /// Affiche la vue des prix des billets
        /// </summary>
        public void ShowTicketsPrice(bool isFullPrice)
        {
           
            if (_buttonName == "btnTicketParisVisit")
            {
                ChangeForm(_typeOfRate, _parisVisit);
            }
            else
            {
                _ticketPrices.ShowTicketPriceOnBtn(isFullPrice);
                ChangeForm(_typeOfRate, _ticketPrices);
            }

        }

        /// <summary>
        /// Affiche la vue des prix des billets sur le retour du résumé de la commande
        /// </summary>
        public void ShowTicketPriceFromOrderResume()
        {
            ChangeForm(_orderResume, _ticketPrices);
        }

        /// <summary>
        /// Affiche la vue de résumé de la commande depuis la vue du Paris Visite
        /// </summary>
        public void ShowResumeOrderFromParisVisit()
        {
            _ticketTimesWanted = 1;

            _priceTicketSelected = _model.FullPriceTicketSelectioned;

            ChangeForm(_parisVisit, _orderResume);
        }

        /// <summary>
        /// Affiche la séléction des tickets depuis le résumé de commande
        /// </summary>
        public void ShowticketSelectionFromResumeOrder()
        {
            ChangeForm(_orderResume, _ticketsSelection);
        }

        /// <summary>
        /// Affiche la selection des
        /// </summary>
        public void ShowTypeOfRateFromParisVisit()
        {
            ChangeForm(_parisVisit, _typeOfRate);
        }

        /// <summary>
        /// Affiche le résumé de la commande et récupère le prix du billet séléctionné et le nombre de fois qu'il est commandé
        /// </summary>
        public void ShowOrderResume(double ticketPrice, int timesWanted)
        {
            _priceTicketSelected = ticketPrice;

            _ticketTimesWanted = timesWanted;

            ChangeForm(_ticketPrices, _orderResume);
        }

        /// <summary>
        /// Affiche les options de paiement après le résumé de la commande
        /// </summary>
        public void ShowPaymentOptions()
        {
            ChangeForm(_orderResume, _paymentOptions);
        }

        /// <summary>
        /// Affiche le résumé de la commande depuis les options de paiement
        /// </summary>
        public void ShowResumeOrderFromPaymentOptions()
        {
            ChangeForm(_paymentOptions, _orderResume);
        }

        /// <summary>
        /// Affiche la vue du paiement
        /// </summary>
        public void ShowPayment()
        {
            ChangeForm(_paymentOptions, _payment);
        }

        /// <summary>
        /// Affiche la vue des options de paiement depuis la vue du paiement
        /// </summary>
        public void ShowPaymentOptionFromPayment()
        {
            ChangeForm(_payment, _paymentOptions);
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
       /// Récupère le prix du billet dans le model
       /// </summary>
       /// <param name="nameOfButton"></param>
       /// <returns></returns>
        public double GetTicketFullPrice(string nameOfButton)
        {
            double ticketPrice = 0;

            foreach (Tuple<string, double> ticket in _model.ListNameAndPriceTickets)
            {
                if (ticket.Item1 == nameOfButton)
                {
                    ticketPrice = ticket.Item2;
                }
            }

            return ticketPrice;
        }

        /// <summary>
        /// Calcule le prix du demi tarif
        /// </summary>
        public double CalculateTicketPriceHalfFare()
        {
            _model.HalfPrice = _model.FullPriceTicketSelectioned / 2;

            return _model.HalfPrice;
        }

        /// <summary>
        /// Retourne le prix complet du billet seléctionné
        /// </summary>
        /// <returns></returns>
        public double ReturnFullPrice()
        {
            return _model.FullPriceTicketSelectioned;
        }

        /// <summary>
        /// Retourne le tarif
        /// </summary>
        /// <returns></returns>
        public string ReturnTarif()
        {
            if (_isFullPrice)
            {
                return "Plein";
            }
            else
            {
                return "Demi-Tarif";
            }
        }

        /// <summary>
        /// Récupère le prix total de la commande
        /// </summary>
        /// <param name="finalPrice"></param>
        public void GetFinalOrderPrice(string finalPrice)
        {
            _finalAmountToPay = finalPrice;
        }

        /// <summary>
        /// Retourne le montant total à payer
        /// </summary>
        /// <returns></returns>
        public string ReturnFinalAmountToPay()
        {
            return _finalAmountToPay;
        }
    }
}
