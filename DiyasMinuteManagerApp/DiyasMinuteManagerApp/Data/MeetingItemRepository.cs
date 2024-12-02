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
            // SQL query to insert a new meeting item and return the generated MeetingItemID.
            string query = @"INSERT INTO MeetingItem (Description)
                          OUTPUT INSERTED.MeetingItemID
                          VALUES (@Description)";

            // Create SQL parameter for the Description field.
            SqlParameter parameter = new SqlParameter("@Description", meetingItem.Description);
            // Execute the query and return the generated ID of the new meeting item.
            int meetingItemId = (int)DatabaseHelper.ExecuteScalar(query, CommandType.Text, parameter);
            return meetingItemId;
        }
    }
}
