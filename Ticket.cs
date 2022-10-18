using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stadium_Management_System
{
    class Ticket
    {
        public int ticketid;
        public string tickettype;
        public string amount;
        public string eventt;

        public Ticket()
        {

        }
        public Ticket(int ticketid, string tickettype,string amount,string eventt)
        {
            this.ticketid=ticketid;
            this.tickettype=tickettype;
            this.amount=amount;
            this.eventt=eventt;
        }

        public DataTable displayTicket()
        {
            DatabaseLayer dl = new DatabaseLayer();
            DataTable dt = dl.DisplayTicket();
            return dt;
        }
        public void insertTicket()
        {
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.InsertTicket(this);
        }
        public void updateTicket()
        {
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.UpdateTicket(this);
        }
        public void deleteTicket()
        {
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.DeleteTicket(this);
        }
        public DataTable ticketbyType(string name)
        {
            DatabaseLayer dbl = new DatabaseLayer();
            DataTable type = dbl.TicketbyType(name);
            return type;
        }

    }
}
