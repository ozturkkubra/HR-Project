using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; 
using System.Data.SqlClient;

namespace YazılımEviInsanKaynaklarıSistemi
{
    class ProjectProvider
    {
        SqlConnection con;
        SqlCommand cmd;
        public ProjectProvider()
        {
            Baglan();
        }
        public void Baglan()
        {
            con = new SqlConnection("Server=IREMSEKER;Database=Test;Uid=sa;Password=12345;");
            cmd = new SqlCommand();
            cmd.Connection = con;
        }

        public void addProject(Project p)
        {

            if (p != null)
            {
                try
                {
                    cmd.CommandText = "Insert Into projeler (Name, Sector, MinPer, MaxPer, MngrNo, AnlystNo, DsgnrNo, DvlprNo, TstrNo) Values ('" + p.Name + "','" + p.Sector + "','" + p.MinPer + "','" + p.MaxPer + "','" + p.MngrNo + "','" + p.AnlystNo + "','" + p.DsgnrNo + "','" + p.DvlprNo + "','" + p.TstrNo + "')";
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
        public void deleteProject(int MinPer)
        {
            string sql = "DELETE FROM projeler WHERE MinPer=@MinPer";
            cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@MinPer", MinPer);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

    }
}
