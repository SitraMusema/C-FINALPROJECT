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
    class Event
    {
        public int id;
        public string name;
        public string date;
        public string time;

        public Event()
        {

        }
        public Event(int id,string name,string date,string time)
        {
            this.id = id;
            this.name = name;
            this.date = date;
            this.time = time;
        }

        public DataTable displayEvent()
        {
            DatabaseLayer dl = new DatabaseLayer();
            DataTable dt = dl.DisplayEvent();
            return dt;
        }
        public DataTable displayEventByName(string name)
        {
            DatabaseLayer dl = new DatabaseLayer();
            DataTable dt = dl.DisplayEventByName(name);
            return dt;
        }
        public void insertEvent()
        {
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.InsertEvent(this);
        }
        public void updateEvent()
        {
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.UpdateEvent(this);
        }
        public void deleteEvent()
        {
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.DeleteEvent(this);
        }
        
    }
}
