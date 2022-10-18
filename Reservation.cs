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
    class Reservation
    {
        public int resid;
        public string resDate;
        public string resTime;
        public string noofReservation;
        public string user;
        public int ticket;



        public Reservation()
        {

        }
        public Reservation(int resid, string resDate, string resTime, string noofReservation, string user, int ticket)
        {
            this.resid = resid;
            this.resDate = resDate;
            this.resTime = resTime;
            this.noofReservation = noofReservation;
            this.user = user;
            this.ticket = ticket;
        }
        public Reservation(int resid, string resDate, string resTime, string user, int ticket)
        {
            this.resid = resid;
            this.resDate = resDate;
            this.resTime = resTime;
            this.user = user;
            this.ticket = ticket;
        }
        public DataTable displayUserreservation(string name)
        {
            DatabaseLayer dl = new DatabaseLayer();
            DataTable dt = dl.DisplayUserreservation(name);
            return dt;
        }
        public void insertReservation()
        {
            
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.InsertReservation(this);
        }
        public void updateReservation()
        {
            Seat s = new Seat();
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.UpdateReservation(this);
        }
        
    }
}
