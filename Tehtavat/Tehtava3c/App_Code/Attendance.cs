using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Management;
using System.Data.SqlTypes;

public class Attendance
{
    public int id;
    public string asioid, firstname, lastname, course;
    public DateTime date;

    public Attendance(int id, string asioid, string lastname, string firstname, DateTime date, string course)
    {
        this.id = id;
        this.asioid = asioid;
        this.firstname = firstname;
        this.lastname = lastname;
        this.date = date;
        this.course = course;
    }

    public string[] ToStringArray()
    {
        string[] data = new string[] { asioid, lastname, firstname, date.ToString(), course };
        return data;
    }

    override public string ToString()
    {
        return asioid + ", " + lastname + ", " + firstname + ", " + date.ToString() + ", " + course;
    }
}
