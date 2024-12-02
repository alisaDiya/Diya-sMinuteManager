using DiyasMinuteManagerApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyasMinuteManagerApp.Data
{
    public static class MeetingTypeRepository
    {
        public static List<MeetingType> GetMeetingTypes()
        {
            // SQL query to fetch MeetingTypeID and TypeName from the MeetingType table
            string query = "SELECT MeetingTypeID, TypeName FROM MeetingType";


            // Executes the query and returns the result as a DataTable
            DataTable dt = DatabaseHelper.ExecuteQuery(query, CommandType.Text);

            // Initialize an empty list to store MeetingType objects
            var types = new List<MeetingType>();
            foreach (DataRow row in dt.Rows)
            {
                types.Add(new MeetingType
                {
                    MeetingTypeID = (int)row["MeetingTypeID"],
                    TypeName = row["TypeName"].ToString()
                });
            }
            return types;
        }
    }
}
