using CinemaComponents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilentCinema
{
    public partial class DeleteTicket : Form
    {
        Tickets ticketToDelete = Tickets.GetInstance();
        public DeleteTicket()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ticketToDelete.DeleteComponent(ticketToDelete.GetComponents()[txtTicketNo.Text]);
        }
    }
}
 