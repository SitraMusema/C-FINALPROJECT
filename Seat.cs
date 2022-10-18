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
    class Seat
    {
        public int seatNumber;
        public string seatType;
        public int reservation;

        public Seat()
        {

        }

        public Seat(int seatNumber,string seatType,int reservation)
        {
            this.seatNumber = seatNumber;
            this.seatType = seatType;
            this.reservation = reservation;
        }
        public DataTable displaySeat()
        {
            DatabaseLayer dl = new DatabaseLayer();
            DataTable dt = dl.DisplaySeat();
            return dt;
        }
        public void insertSeat()
        {
            Reservation r = new Reservation();
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.InsertSeat(this,r);
        }
        public void updateReservation()
        {
            Reservation r = new Reservation();
            DatabaseLayer dbl = new DatabaseLayer();
            //dbl.UpdateReservationandSeat(r, this);
        }
    }
}
