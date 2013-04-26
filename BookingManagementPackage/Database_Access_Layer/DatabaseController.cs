using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Diagnostics;

namespace Database_Access_Layer
{
    public class DatabaseController
    {
        private OleDbConnection dbCon;

        /// <summary>
        /// Constructor for the DatabaseController Class
        /// </summary>
        public DatabaseController()
        {
            Init();
        }

        #region Connection_Handling

        // initilise db
        private void Init()
        {
            string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\\..\\..\\Database.accdb";
            try
            {
                dbCon = new OleDbConnection(conString);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        // open DB connection
        private bool OpenConnection()
        {
            try
            {
                dbCon.Open();
                Debug.WriteLine("Connected To DB!");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("CON ERROR: " + ex.Message);
                return false;
            }
        }

        // close DB connection
        private bool CloseConnection()
        {
            try
            {
                dbCon.Close();
                Debug.WriteLine("Disconnected From DB!");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("CON ERROR: " + ex.Message);
                return false;
            }
        }

        #endregion

        /// <summary>
        /// Handle the request fro mthe Business_Layer
        /// </summary>
        /// <param name="op"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public Object HandleRequest(string op, Object data)
        {
            Object returnData = null;

            //select sql operation
            switch (op)
            {
                case "01":
                    returnData = FindBooking(data.ToString());
                    break;
                case "02":
                    returnData = CreateBooking(data);
                    break;
                case "03":
                    returnData = ModifyBooking(data);
                    break;
                case "04":
                    returnData = DeleteBooking(data);
                    break;
                case "10":
                    
                    break;
            }

            return returnData;
        }

        /// Refactoring Idea:
        /// some parts of the SQL operations could be simplified
        /// and turned into one function

        /// <summary>
        /// Runes the sql query to find the selected record
        /// </summary>
        /// <param name="bookingId"></param>
        /// <returns></returns>
        private ArrayList FindBooking(string bookingId)
        {
            ArrayList tempArrList = new ArrayList();

            try
            {
                if (this.OpenConnection() == true)
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Bookings] WHERE BookingId = '" + bookingId + "'", dbCon);
                    //cmd.Parameters.AddWithValue(@param, param);
                    OleDbDataReader dataReader = cmd.ExecuteReader();

                    if (dataReader.Read())
                    {
                        tempArrList.Add(dataReader["BookingId"] + "");
                        tempArrList.Add(dataReader["MemberId"] + "");
                        tempArrList.Add(dataReader["DateTime"] + "");
                        tempArrList.Add(dataReader["ServiceDetails"] + "");
                        tempArrList.Add(dataReader["DateBooked"] + "");
                        tempArrList.Add(dataReader["Status"] + "");
                        tempArrList.Add(dataReader["ServiceLog"] + "");

                        dataReader.Close();
                        this.CloseConnection();
                        return tempArrList;
                    }

                    dataReader.Close();
                    this.CloseConnection();
                    return null;
                }
                else
                {
                    this.CloseConnection();
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR[FindBooking()]: " + ex.Message);
                this.CloseConnection();
                return null;
            }
        }

        /// <summary>
        /// Runs the sql query to create a booking
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private ArrayList CreateBooking(Object data)
        {
            ArrayList tempArrList = new ArrayList();

            string[] BookingDetails = (string[])data;

            // get the highest booking number
            // so we can increment it for the new booking
            string currentMaxBookingId = MaxBookingId();
            Debug.WriteLine("Maxbooking: " + currentMaxBookingId);

            // create new booking id
            char[] delim = { 'b' };
            string[] bookingId = currentMaxBookingId.Split(delim);
            string newBookingId = "b" + (int.Parse(bookingId[1]) + 1).ToString();
            Debug.WriteLine("New Booking Id: " + newBookingId);

            // create new tracking id from booking id
            //string newTrackingId = "t" + (int.Parse(bookingId[1]) + 1).ToString();
            //Debug.WriteLine("New Tracking Id: " + newTrackingId);

            string memberId = "tempId";
            string serviceLog = "no details";
            string status = "incomplete";

            string query = "INSERT INTO [Bookings] VALUES ('" + newBookingId + "', '" + memberId + "', '" + BookingDetails[0] + "', '" + BookingDetails[1] + "', '" + string.Format("{0:g}", DateTime.Now) + "', '" + serviceLog + "', '" + status + "')";

            try
            {
                if (this.OpenConnection() == true)
                {

                    OleDbCommand cmd1 = new OleDbCommand(query, dbCon);
                    cmd1.ExecuteNonQuery();

                    OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM [Bookings] WHERE BookingId = '" + newBookingId + "'", dbCon);
                    //cmd.Parameters.AddWithValue(@param, param);
                    OleDbDataReader dataReader = cmd2.ExecuteReader();

                    if(dataReader.Read())
                    {
                        tempArrList.Add(dataReader["BookingId"] + "");
                        tempArrList.Add(dataReader["MemberId"] + "");
                        tempArrList.Add(dataReader["DateTime"] + "");
                        tempArrList.Add(dataReader["ServiceDetails"] + "");
                        tempArrList.Add(dataReader["DateBooked"] + "");
                        tempArrList.Add(dataReader["Status"] + "");
                        tempArrList.Add(dataReader["ServiceLog"] + "");
                        
                        dataReader.Close();
                        this.CloseConnection();
                        return tempArrList;
                    }

                    dataReader.Close();
                    this.CloseConnection();
                    return null;
                }
                else
                {
                    Debug.WriteLine("ERROR[DATABASE_CONNECTION_UNAVAILABLE]");
                    this.CloseConnection();
                    return null;
                }
                
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR[CreateBooking()]: " + ex.Message);
                this.CloseConnection();
                return null;
            }
        }

        /// <summary>
        /// Runs the sql query to modify the selected record
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private ArrayList ModifyBooking(Object data)
        {
            ArrayList tempArrList = new ArrayList();

            string[] BookingDetails = (string[])data;

            string query = "UPDATE [Bookings] SET [DateTime] ='" + BookingDetails[0] + "', [ServiceDetails] ='" + BookingDetails[1] + "' WHERE BookingId ='" + BookingDetails[2] + "'";

            try
            {
                if (this.OpenConnection() == true)
                {

                    OleDbCommand cmd1 = new OleDbCommand(query, dbCon);
                    cmd1.ExecuteNonQuery();

                    OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM [Bookings] WHERE BookingId = '" + BookingDetails[2] + "'", dbCon);
                    //cmd.Parameters.AddWithValue(@param, param);
                    OleDbDataReader dataReader = cmd2.ExecuteReader();

                    if (dataReader.Read())
                    {
                        tempArrList.Add(dataReader["BookingId"] + "");
                        tempArrList.Add(dataReader["MemberId"] + "");
                        tempArrList.Add(dataReader["DateTime"] + "");
                        tempArrList.Add(dataReader["ServiceDetails"] + "");
                        tempArrList.Add(dataReader["DateBooked"] + "");
                        tempArrList.Add(dataReader["Status"] + "");
                        tempArrList.Add(dataReader["ServiceLog"] + "");

                        dataReader.Close();
                        this.CloseConnection();
                        return tempArrList;
                    }

                    dataReader.Close();
                    this.CloseConnection();
                    return null;
                }
                else
                {
                    Debug.WriteLine("ERROR[DATABASE_CONNECTION_UNAVAILABLE]");
                    this.CloseConnection();
                    return null;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR[ModifyBooking()]: " + ex.Message);
                this.CloseConnection();
                return null;
            }
        }

        /// <summary>
        /// Runs the sql query to delete the selected record
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private ArrayList DeleteBooking(Object data)
        {
            ArrayList tempArrList = new ArrayList();

            string BookingId = data.ToString();

            string query = "DELETE FROM [Bookings] WHERE BookingId = '" + BookingId + "'";

            try
            {
                if (this.OpenConnection() == true)
                {

                    OleDbCommand cmd1 = new OleDbCommand(query, dbCon);
                    cmd1.ExecuteNonQuery();

                    OleDbCommand cmd2 = new OleDbCommand("SELECT * FROM [Bookings] WHERE BookingId = '" + BookingId + "'", dbCon);
                    //cmd.Parameters.AddWithValue(@param, param);
                    OleDbDataReader dataReader = cmd2.ExecuteReader();

                    if (dataReader.Read())
                    {
                        tempArrList.Add(dataReader["BookingId"] + "");
                        tempArrList.Add(dataReader["MemberId"] + "");
                        tempArrList.Add(dataReader["DateTime"] + "");
                        tempArrList.Add(dataReader["ServiceDetails"] + "");
                        tempArrList.Add(dataReader["DateBooked"] + "");
                        tempArrList.Add(dataReader["Status"] + "");
                        tempArrList.Add(dataReader["ServiceLog"] + "");

                        dataReader.Close();
                        this.CloseConnection();
                        return tempArrList;
                    }

                    dataReader.Close();
                    this.CloseConnection();
                    return null;
                }
                else
                {
                    Debug.WriteLine("ERROR[DATABASE_CONNECTION_UNAVAILABLE]");
                    this.CloseConnection();
                    return null;
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR[DeleteBooking()]: " + ex.Message);
                this.CloseConnection();
                return null;
            }
        }

        /// <summary>
        /// Returns the highest booking id number
        /// Used in generating a new booking id
        /// </summary>
        /// <returns></returns>
        private string MaxBookingId()
        {
            string tempstr = "";

            try
            {
                if (this.OpenConnection() == true)
                {
                    OleDbCommand cmd = new OleDbCommand("SELECT MAX([Bookings].BookingId) AS BookingId FROM [Bookings]", dbCon);
                    //cmd.Parameters.AddWithValue(@param, param);
                    OleDbDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        tempstr = dataReader["BookingId"] + "";
                    }

                    dataReader.Close();

                    this.CloseConnection();

                    return tempstr;
                }
                else
                {
                    this.CloseConnection();
                    return tempstr;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("ERROR[MaxBookingId()]: " + ex.Message);
                this.CloseConnection();
                return tempstr;
            }
        }
    
    }
}
