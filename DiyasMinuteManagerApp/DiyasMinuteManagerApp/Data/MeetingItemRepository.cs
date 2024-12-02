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
    public static class MeetingItemRepository
    {
        public static int AddMeetingItem(MeetingItem meetingItem)
        {
            string query = @"INSERT INTO MeetingItem (Description)
                          OUTPUT INSERTED.MeetingItemID
                          VALUES (@Description)";

            SqlParameter parameter = new SqlParameter("@Description", meetingItem.Description);
            int meetingItemId = (int)DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameter);
            return meetingItemId;
        }
    }
}
