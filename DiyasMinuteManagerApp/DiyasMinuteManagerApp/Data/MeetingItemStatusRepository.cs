using DiyasMinuteManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyasMinuteManagerApp.Data
{
    public static class MeetingItemStatusRepository
    {
        // Adds a new meeting item status record to the database
        public static void AddMeetingItemStatus(MeetingItemStatus itemStatus)
        {
            // SQL query to insert a new meeting item status
            string query = @"INSERT INTO MeetingItemStatus (MeetingID, MeetingItemID, Status, ResponsiblePerson)
                             VALUES (@MeetingID, @MeetingItemID, @Status, @ResponsiblePerson)";

            // Creating parameters for the query to prevent SQL injection
            SqlParameter[] parameters = {
                new SqlParameter("@MeetingID", itemStatus.MeetingID),
                new SqlParameter("@MeetingItemID", itemStatus.MeetingItemID),
                new SqlParameter("@Status", itemStatus.Status),
                new SqlParameter("@ResponsiblePerson", itemStatus.ResponsiblePerson)
            };

            // Executes the non-query (insert) command to add the data into the database
            DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }
        // Retrieves a list of meeting item statuses by meeting ID
        public static List<MeetingItemStatus> GetMeetingItemsByMeetingId(int meetingId)
        {
            // SQL query to select meeting item statuses and related information
            string query = @"SELECT mis.MeetingItemStatusID, mis.MeetingID, mis.MeetingItemID, mis.Status, mis.ResponsiblePerson, mi.Description
                             FROM MeetingItemStatus mis
                             INNER JOIN MeetingItem mi ON mis.MeetingItemID = mi.MeetingItemID
                             WHERE mis.MeetingID = @MeetingID";

            // Creating parameter to prevent SQL injection
            SqlParameter parameter = new SqlParameter("@MeetingID", meetingId);
            // Executes the query and retrieves the result as a DataTable
            DataTable dt = DatabaseHelper.ExecuteQuery(query, CommandType.Text, parameter);

            // Converts the DataTable rows into a list of MeetingItemStatus objects
            var items = new List<MeetingItemStatus>();
            foreach (DataRow row in dt.Rows)
            {
                items.Add(new MeetingItemStatus
                {
                    MeetingItemStatusID = (int)row["MeetingItemStatusID"],
                    MeetingID = (int)row["MeetingID"],
                    MeetingItemID = (int)row["MeetingItemID"],
                    Status = row["Status"].ToString(),
                    ResponsiblePerson = row["ResponsiblePerson"].ToString(),
                    MeetingItem = new MeetingItem
                    {
                        MeetingItemID = (int)row["MeetingItemID"],
                        Description = row["Description"].ToString()
                    }
                });
            }
            return items;
        }
        // Updates an existing meeting item status record in the database
        public static void UpdateMeetingItemStatus(MeetingItemStatus itemStatus)
        {
            string query = @"UPDATE MeetingItemStatus
                             SET Status = @Status, ResponsiblePerson = @ResponsiblePerson
                             WHERE MeetingItemStatusID = @MeetingItemStatusID";

            SqlParameter[] parameters = {
                new SqlParameter("@Status", itemStatus.Status),
                new SqlParameter("@ResponsiblePerson", itemStatus.ResponsiblePerson),
                new SqlParameter("@MeetingItemStatusID", itemStatus.MeetingItemStatusID)
            };

            DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }
    }
}
