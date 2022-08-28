using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;

namespace YazılımEviInsanKaynaklarıSistemi
{
    class PersonnelProvider
    {
        SqlConnection con;
        SqlCommand cmd;
        public PersonnelProvider() 
        {
            Baglan();
        }
        public void Baglan()
        {
            con = new SqlConnection("Server=IREMSEKER;Database=Test;Uid=sa;Password=12345;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
       
        public void addPersonnel(Personnel p)
        {

            if (p != null)
            {
                try
                {
                    cmd.CommandText = "Insert Into personel (TC,Name,Surname,Email,Role) Values (" + p.TC + ",'" + p.Name + "','" + p.Surname + "','" + p.Email + "','" + p.Role + "')";
                    cmd.CommandType = CommandType.Text;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (con != null)
                    {
                        con.Close();
                    }
                }
            }

        }
        public void deletePersonnel(int TC)
        {
            string sql = "DELETE FROM personel WHERE TC=@TC";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@TC", TC);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }


    }
}
