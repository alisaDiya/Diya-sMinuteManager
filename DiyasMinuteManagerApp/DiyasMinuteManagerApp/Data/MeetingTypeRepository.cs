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
            string query = "SELECT MeetingTypeID, TypeName FROM MeetingType";
            DataTable dt = DatabaseHelper.ExecuteQuery(query, CommandType.Text);

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
