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
            string query = @"INSERT INTO Meeting (MeetingTypeID, MeetingDateTime)
                             OUTPUT INSERTED.MeetingID
                             VALUES (@MeetingTypeID, @MeetingDateTime)";

            SqlParameter[] parameters = {
                new SqlParameter("@MeetingTypeID", meeting.MeetingTypeID),
                new SqlParameter("@MeetingDateTime", meeting.MeetingDateTime)
            };

            int meetingId = (int)DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameters);
            return meetingId;
        }

        public static Meeting GetPreviousMeeting(int meetingTypeId)
        {
            string query = @"SELECT TOP 1 MeetingID, MeetingTypeID, MeetingDateTime
                             FROM Meeting
                             WHERE MeetingTypeID = @MeetingTypeID
                             ORDER BY MeetingDateTime DESC";

            SqlParameter parameter = new SqlParameter("@MeetingTypeID", meetingTypeId);
            DataTable dt = DatabaseHelper.ExecuteQuery(query, CommandType.Text, parameter);

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
            string query = @"SELECT MeetingID, MeetingTypeID, MeetingDateTime
                             FROM Meeting
                             WHERE MeetingTypeID = @MeetingTypeID";

            SqlParameter parameter = new SqlParameter("@MeetingTypeID", meetingTypeId);
            DataTable dt = DatabaseHelper.ExecuteQuery(query, CommandType.Text, parameter);

            var meetings = new List<Meeting>();
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
