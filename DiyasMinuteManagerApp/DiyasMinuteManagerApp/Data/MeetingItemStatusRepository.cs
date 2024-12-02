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
        public static void AddMeetingItemStatus(MeetingItemStatus itemStatus)
        {
            string query = @"INSERT INTO MeetingItemStatus (MeetingID, MeetingItemID, Status, ResponsiblePerson)
                             VALUES (@MeetingID, @MeetingItemID, @Status, @ResponsiblePerson)";

            SqlParameter[] parameters = {
                new SqlParameter("@MeetingID", itemStatus.MeetingID),
                new SqlParameter("@MeetingItemID", itemStatus.MeetingItemID),
                new SqlParameter("@Status", itemStatus.Status),
                new SqlParameter("@ResponsiblePerson", itemStatus.ResponsiblePerson)
            };

            DatabaseHelper.ExecuteNonQuery(query, CommandType.Text, parameters);
        }

        public static List<MeetingItemStatus> GetMeetingItemsByMeetingId(int meetingId)
        {
            string query = @"SELECT mis.MeetingItemStatusID, mis.MeetingID, mis.MeetingItemID, mis.Status, mis.ResponsiblePerson, mi.Description
                             FROM MeetingItemStatus mis
                             INNER JOIN MeetingItem mi ON mis.MeetingItemID = mi.MeetingItemID
                             WHERE mis.MeetingID = @MeetingID";

            SqlParameter parameter = new SqlParameter("@MeetingID", meetingId);
            DataTable dt = DatabaseHelper.ExecuteQuery(query, CommandType.Text, parameter);

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
