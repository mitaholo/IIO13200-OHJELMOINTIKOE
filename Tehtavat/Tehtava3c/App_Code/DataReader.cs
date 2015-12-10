using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Management;

public class DataReader
{
    SqlConnection connection;

    public DataReader()
    {
        System.Configuration.Configuration rootWebConfig = System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/");
        System.Configuration.ConnectionStringSettings connString;
        if (rootWebConfig.ConnectionStrings.ConnectionStrings.Count > 0)
        {
            connString = rootWebConfig.ConnectionStrings.ConnectionStrings["DemoxOy"];
            connection = new SqlConnection(connString.ConnectionString);
        }
    }

    public List<Attendance> ReadToList()
    {
        return ReadToList("");
    }

    public List<Attendance> ReadToList(string search)
    {
        List<Attendance> attendances = new List<Attendance>();
        try
        {
            using (connection)
            {
                SqlCommand command;
                if (search == "") command = new SqlCommand("SELECT * FROM lasnaolot", connection);
                else
                {
                    command = new SqlCommand("SELECT * FROM lasnaolot WHERE asioid = @asioid", connection);
                    command.Parameters.Add(new SqlParameter("asioid", search));
                }
                connection.Open();
                using (command)
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        attendances.Add(new Attendance(reader.GetInt16(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetString(5)));
                    }
                }
            }
        }
        catch (System.Data.SqlClient.SqlException e)
        {
            return null;
        }

        return attendances;
    }

    public List<Student> ReadStudentsToList(string search)
    {
        List<Student> students = new List<Student>();
        try
        {
            using (connection)
            {
                SqlCommand command;
                if (search == "") command = new SqlCommand("SELECT * FROM lasnaolot", connection);
                else
                {
                    command = new SqlCommand("SELECT * FROM lasnaolot WHERE asioid = @asioid", connection);
                    command.Parameters.Add(new SqlParameter("asioid", search));
                }
                connection.Open();
                using (command)
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        students.Add(new Student(reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                    }
                }
            }
        }
        catch (System.Data.SqlClient.SqlException e)
        {
            return null;
        }

        return students;
    }
}