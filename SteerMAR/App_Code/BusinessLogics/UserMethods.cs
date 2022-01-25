using SteerMAR.DatabaseHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SteerMAR.App_Code.DataAccess.SetupModels;

namespace SteerMAR.App_Code.BusinessLogics
{
    public class UserMethods : SqlConnectionHelper
    {
        public DataSet UserLogin(UserModel model)
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_UserLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", "Login");
                cmd.Parameters.AddWithValue("@PIN_No", model.PIN_No);
                cmd.Parameters.AddWithValue("@User_Password", model.User_Password);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet UpdateAttendance()
        {
            try
            {
                localCon();
                cmd = new SqlCommand("Proc_UserLogin", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Type", "logout");
                cmd.Parameters.AddWithValue("@PIN_No", string.Empty);
                cmd.Parameters.AddWithValue("@User_Password", string.Empty);
                da = new SqlDataAdapter(cmd);
                ds = new DataSet();
                da.Fill(ds);
                con.Close();
                return ds;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
