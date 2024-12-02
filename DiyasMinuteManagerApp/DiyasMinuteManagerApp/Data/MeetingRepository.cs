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
    public static class MeetingRepository
    {
        public static int AddMeeting(Meeting meeting)
        {
            // SQL query to insert a meeting record and return the MeetingID
            string query = @"INSERT INTO Meeting (MeetingTypeID, MeetingDateTime)
                             OUTPUT INSERTED.MeetingID
                             VALUES (@MeetingTypeID, @MeetingDateTime)";

            // Parameters for the SQL query
            SqlParameter[] parameters = {
                new SqlParameter("@MeetingTypeID", meeting.MeetingTypeID),
                new SqlParameter("@MeetingDateTime", meeting.MeetingDateTime)
            };

            // Executes the query and returns the newly inserted MeetingID
            int meetingId = (int)DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters);
            return meetingId;
        }

        public static Meeting GetPreviousMeeting(int meetingTypeId)
        {
            // SQL query to select the most recent meeting for a specific MeetingTypeID
            string query = @"SELECT TOP 1 MeetingID, MeetingTypeID, MeetingDateTime
                             FROM Meeting
                             WHERE MeetingTypeID = @MeetingTypeID
                             ORDER BY MeetingDateTime DESC";
            // Parameter for the SQL query
            SqlParameter parameter = new SqlParameter("@MeetingTypeID", meetingTypeId);
            // Execute the query and get the result as a DataTable
            DataTable dt = DatabaseHelper.ExecuteQuery(query, CommandType.Text, parameter);


            // If a record is found, create and return a Meeting object
            if (dt.Rows.Count > 0)
            {
                var meeting = new Meeting
                {
                    MeetingID = (int)dt.Rows[0]["MeetingID"],
                    MeetingTypeID = (int)dt.Rows[0]["MeetingTypeID"],
                    MeetingDateTime = (DateTime)dt.Rows[0]["MeetingDateTime"]
                };
                return meeting;
            }
            return null;
        }

        public static List<Meeting> GetMeetingsByType(int meetingTypeId)
        {
            // SQL query to select all meetings for a specific MeetingTypeID
            string query = @"SELECT MeetingID, MeetingTypeID, MeetingDateTime
                             FROM Meeting
                             WHERE MeetingTypeID = @MeetingTypeID";
            // Parameter for the SQL query
            SqlParameter parameter = new SqlParameter("@MeetingTypeID", meetingTypeId);
            DataTable dt = DatabaseHelper.ExecuteQuery(query, CommandType.Text, parameter);

            // Create a list to store the Meeting objects
            var meetings = new List<Meeting>();

            // Iterate through each row in the DataTable and populate the list
            foreach (DataRow row in dt.Rows)
            {
                meetings.Add(new Meeting
                {
                    MeetingID = (int)row["MeetingID"],
                    MeetingTypeID = (int)row["MeetingTypeID"],
                    MeetingDateTime = (DateTime)row["MeetingDateTime"]
                });
            }
            return meetings;
        }
    }
}
