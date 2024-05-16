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

namespace P_UX.Views
{
    public partial class TicketPrices : Form
    {
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
        public TicketPrices()
        {
            InitializeComponent();
        }
    }
}
