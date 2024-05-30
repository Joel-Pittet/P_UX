///Auteur: Joël Pittet
///Date: 30.05.2024
///Lieu: ETML - VENNES
///Description: Model principal, contient les billets avec le nom auquel ils sont associés ainsi que le prix de chaque billet
///
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_UX.Model
{
    public class Model
    {
        /// <summary>
        /// Controller par défaut
        /// </summary>
        public Controller.Controller Controller { get; set; }

        /// <summary>
        /// Dictionnaire pour stocker les noms des boutons associé au nom du billet et prix de chaque billets
        /// </summary>
        private List<Tuple<string, double>> _listNameAndPriceTickets = new List<Tuple<string, double>>();

        /// <summary>
        /// GETTER / SETTER
        /// Dictionnaire pour stocker les noms des boutons associé au nom du billet et prix de chaque billets
        /// </summary>
        public List<Tuple<string, double>> ListNameAndPriceTickets
        {
            get
            {
                return _listNameAndPriceTickets;
            }
            set
            {
                _listNameAndPriceTickets = value;
            }
        }

        /// <summary>
        /// Bilet t+
        /// </summary>
        private Tuple<string, double> _ticketTPlus = new Tuple<string, double>("btnTicketT", 2.15);

        /// <summary>
        /// BIllet Paris Region
        /// </summary>
        private Tuple<string, double> _ticketParisRegion = new Tuple<string, double>("btnTicketParisRegion", 5.25);

        /// <summary>
        /// Billet Disneyland Paris
        /// </summary>
        private Tuple<string, double> _ticketDisneyland = new Tuple<string, double>("btnTicketDisney", 25.00);

        /// <summary>
        /// Billet Paris Visite
        /// </summary>
        private Tuple<string, double> _ticketParisVisit = new Tuple<string, double>("btnTicketParisVisit", 5.80);

        /// <summary>
        /// Billet Aéroport
        /// </summary>
        private Tuple<string, double> _ticketAirport = new Tuple<string, double>("btnTicketAirport", 15.15);

        /// <summary>
        /// Billet Mobilis
        /// </summary>
        private Tuple<string, double> _ticketMobilis = new Tuple<string, double>("btnTicketMobilis", 8.75);

        /// <summary>
        /// Prix complet du billet seléctionné
        /// </summary>
        private double _fullPriceTicketSelectioned = 0;

        /// <summary>
        /// GETTER / SETTER
        /// Prix complet du billet seléctionné
        /// </summary>
        public double FullPriceTicketSelectioned
        {
            get
            {
                return _fullPriceTicketSelectioned;
            }
            set
            {
                _fullPriceTicketSelectioned = value;
            }
        }

        /// <summary>
        /// Prix réduit du billet seléctionné
        /// </summary>
        private double _halfPrice = 0;

        /// <summary>
        /// GETTER / SETTER
        /// Prix réduit du billet seléctionné
        /// </summary>
        public double HalfPrice
        {
            get
            {
                return _halfPrice;
            }
            set
            {
                _halfPrice = value;
            }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        public Model()
        {
            AddTickets();
        }

        /// <summary>
        /// Ajoute tous les tickets à la lste des tickets disponibles
        /// </summary>
        public void AddTickets()
        {
            _listNameAndPriceTickets.Add(_ticketTPlus);
            _listNameAndPriceTickets.Add(_ticketParisRegion);
            _listNameAndPriceTickets.Add(_ticketDisneyland);
            _listNameAndPriceTickets.Add(_ticketParisVisit);
            _listNameAndPriceTickets.Add(_ticketAirport);
            _listNameAndPriceTickets.Add(_ticketMobilis);
        }
    }
}
