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
    class User
    {
        public string email;
        public string userName;
        public string password;
        public string confirmpassword;
        public string role;
        public int id;
        public string fname;
        public string lname;
        public byte[] photo;

        public User()
        {

        }

        public User(int id, string fname, string lname, string confirmpassword, string email, string username, string password, string role, byte[] photo)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.confirmpassword = confirmpassword;
            this.email = email;
            this.userName = username;
            this.password = password;
            this.role = role;
            this.photo = photo;
        }
        public User(string fname, string lname, string confirmpassword, string email, string username, string password,  byte[] photo)
        {
            this.fname = fname;
            this.lname = lname;
            this.confirmpassword = confirmpassword;
            this.email = email;
            this.userName = username;
            this.password = password;
            
            this.photo = photo;
        }
        public User(int id, string fname, string lname, string confirmpassword, string email, string username, string password, byte[] photo)
        {
            this.id = id;
            this.fname = fname;
            this.lname = lname;
            this.confirmpassword = confirmpassword;
            this.email = email;
            this.userName = username;
            this.password = password;
            this.photo = photo;
        }

        public void createUser()
        {
            DatabaseLayer dbl = new DatabaseLayer();
            dbl.saveUserByStoreProc(this);
        }
        public string allUsers()
        {
            DatabaseLayer dbl = new DatabaseLayer();
            string count=dbl.AllUsers();
            return count;
        }
        public string allAdminstrator()
        {
            DatabaseLayer dbl = new DatabaseLayer();
            string count = dbl.AllAdminstrator();
            return count;
        }

        public string usersByEvent(string name)
        {
            
            DatabaseLayer dbl = new DatabaseLayer();
            string count = dbl.UsersbyEvent(name);
            return count;
        }
    }
}
