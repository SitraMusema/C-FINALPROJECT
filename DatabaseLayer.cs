using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Stadium_Management_System
{
    class DatabaseLayer
    {
        string conStr = "server=LAPTOP-IGLVT0LN;database=stadiumdatabase;uid=project;pwd=123";
        //User
        public void saveUserByStoreProc(User u)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spCreateUser", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", u.id);
                    cmd.Parameters.AddWithValue("@email", u.email);
                    cmd.Parameters.AddWithValue("@userName", u.userName);
                    cmd.Parameters.AddWithValue("@password", u.password);
                    cmd.Parameters.AddWithValue("@firstName", u.fname);
                    cmd.Parameters.AddWithValue("@lastName", u.lname);
                    cmd.Parameters.AddWithValue("@photo", u.photo);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Account created succesfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public string getRole(string un, string pwd)
        {
            string role = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spGetRole", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@userName", un);
                    cmd.Parameters.AddWithValue("@password", pwd);
                    object objRole = cmd.ExecuteScalar();
                    con.Close();
                    if (objRole != null)
                        role = objRole.ToString();
                    else
                        role = "No Role";

                    return role;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "ERROR";
            }

        }
        public string AllUsers()
        {
            string count = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AllUsers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    object objCount = cmd.ExecuteScalar();
                    con.Close();
                    if (objCount != null)
                        count = objCount.ToString();
                    else
                        count = "No user";

                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "error";
            }
        }
        public string AllAdminstrator()
        {
            string count = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("AllAdminstrator", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    object objCount = cmd.ExecuteScalar();
                    con.Close();
                    if (objCount != null)
                        count = objCount.ToString();
                    else
                        count = "No user";

                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "error";
            }
        }
        public string UsersbyEvent(string name)
        {
            string count = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UserbyEvent", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eventName", name);
                    object objCount = cmd.ExecuteScalar();
                    con.Close();
                    if (objCount != null)
                        count = objCount.ToString();
                    else
                        count = "No user";

                    return count;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "error";
            }
        }


        //Event

        public DataTable DisplayEvent()
         {
             try
             {
                 using (SqlConnection con = new SqlConnection(conStr))
                 {
                     con.Open();
                     SqlCommand cmd = new SqlCommand("spDisplayEvent",con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt= new DataTable();
                    da.Fill(dt);
                    return dt;
                     
                     
                 }
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
                return null;
             }
         }
       /* public String AllEventCount()
        {
            string count = "",query = "select * from [usdAllEvents]";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    count = dt.Rows[0][0].ToString();
                    object objCount = cmd.ExecuteScalar();
                    con.Close();
                    if (objCount != null)
                        count = objCount.ToString();
                    else
                        count = "No Event";

                    return count;
                }
              


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "Error!!";
            }
        }*/

        public DataTable DisplayEventByName(string name)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = new SqlCommand("spGetEventbyName", con);
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@eventName", name);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "dtEvent");

                    DataTable dt = ds.Tables["dtEvent"];
                    return dt;

                }
            }

        }
        public void InsertEvent(Event e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertEvent", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", e.name);
                    cmd.Parameters.AddWithValue("@eventdate", e.date);
                    cmd.Parameters.AddWithValue("@eventtime", e.time);
                    

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Event Save Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateEvent(Event e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateEvent", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eventid", e.id);
                    cmd.Parameters.AddWithValue("@name", e.name);
                    cmd.Parameters.AddWithValue("@eventdate", e.date);
                    cmd.Parameters.AddWithValue("@eventtime", e.time);
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Event Updated Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteEvent(Event e)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteEvent", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@eventid", e.id);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Event Deleted Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Reservation
        public DataTable DisplayUserreservation(string name)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();


                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("spDisplayUserreservation", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@userName", name);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "dtReservation");

                        DataTable dt = ds.Tables["dtReservation"];
                        return dt;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
           

        }
        public void InsertReservation(Reservation r)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertReservation", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@resdate", r.resDate);
                    cmd.Parameters.AddWithValue("@restime", r.resTime);
                    cmd.Parameters.AddWithValue("@user", r.user);
                    cmd.Parameters.AddWithValue("@ticket", r.ticket);
                   // cmd.Parameters.AddWithValue("@seatType", s.seatType);
                   // cmd.Parameters.AddWithValue("@seatNumber", s.seatNumber);
                    
                   
                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Reservation Successful !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void InsertSeat(Seat s,Reservation r)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertSeat", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                   
                    cmd.Parameters.AddWithValue("@resid", r.resid);
                    cmd.Parameters.AddWithValue("@seatNumber", s.seatNumber);


                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Reservation Successful !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateReservation(Reservation r)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateReservation", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@resid", r.resid);
                    cmd.Parameters.AddWithValue("@resdate", r.resDate);
                    cmd.Parameters.AddWithValue("@restime", r.resTime);
                    cmd.Parameters.AddWithValue("@user", r.user);
                    cmd.Parameters.AddWithValue("@ticket", r.ticket);
                    //cmd.Parameters.AddWithValue("@seatNumber", s.seatNumber);
                    //cmd.Parameters.AddWithValue("@seaType", s.seatType);
                    

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Reservation Updated Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
      
        //Ticket
        public DataTable DisplayTicket()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDisplayTicket", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        public void InsertTicket(Ticket t)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spInsertTicket", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@tickettype", t.tickettype);
                    cmd.Parameters.AddWithValue("@amount", t.amount);
                    cmd.Parameters.AddWithValue("@event", t.eventt);


                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Ticket Saved Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void UpdateTicket(Ticket t)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spUpdateTicket", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ticketid", t.ticketid);
                    cmd.Parameters.AddWithValue("@tickettype", t.tickettype);
                    cmd.Parameters.AddWithValue("@amount", t.amount);
                    cmd.Parameters.AddWithValue("@event", t.eventt);


                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Ticket updated Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void DeleteTicket(Ticket t)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDeleteTicket", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ticketid", t.ticketid);

                    int row = cmd.ExecuteNonQuery();
                    con.Close();
                    if (row > 0)
                    {
                        MessageBox.Show("Ticket Deleted Successfully !");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable TicketbyType(string name)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();


                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = new SqlCommand("TicketbyType", con);
                        da.SelectCommand.CommandType = CommandType.StoredProcedure;
                        da.SelectCommand.Parameters.AddWithValue("@tickettype", name);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "dtTicket");

                        DataTable dt = ds.Tables["dtTicket"];
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }


        }

        //Seat
        public DataTable DisplaySeat()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("spDisplaySeat", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }


    }
}
