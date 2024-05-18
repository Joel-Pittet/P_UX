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
        /// Dictionnaire pour stocker les noms et prix de chaque billets
        /// </summary>
        private List<Tuple<string, double>> _listNameAndPriceTickets = new List<Tuple<string, double>>();

        /// <summary>
        /// GETTER / SETTER
        /// Dictionnaire pour stocker les noms et prix de chaque billets
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
        private Tuple<string, double> _ticketTPlus = new Tuple<string, double>("Billet t+", 2.15);

        /// <summary>
        /// BIllet Paris Region
        /// </summary>
        private Tuple<string, double> _ticketParisRegion = new Tuple<string, double>("Billet pour Paris Region", 2.15);

        /// <summary>
        /// Billet Disneyland Paris
        /// </summary>
        private Tuple<string, double> _ticketDisneyland = new Tuple<string, double>("Billet Disneyland Paris", 2.15);

        /// <summary>
        /// Billet Paris Visite
        /// </summary>
        private Tuple<string, double> _ticketParisVisit = new Tuple<string, double>("Billet Paris Visit", 2.15);

        /// <summary>
        /// Billet Aéroport
        /// </summary>
        private Tuple<string, double> _ticketAirport = new Tuple<string, double>("Billet Aéroport", 2.15);

        /// <summary>
        /// Billet Mobilis
        /// </summary>
        private Tuple<string, double> _ticketMobilis = new Tuple<string, double>("Billet Mobilis", 2.15);

        /// <summary>
        /// Constructeur
        /// </summary>
        public Model()
        {
            AddTickets();
        }

        /// <summary>
        /// Ajoute tous les tickets à la lste des tickets disponible
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
