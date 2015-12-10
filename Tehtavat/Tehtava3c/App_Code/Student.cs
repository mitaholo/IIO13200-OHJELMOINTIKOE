using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Management;
using System.Data.SqlTypes;

public class Student
{
    public string asioid, firstname, lastname;

    public Student(string asioid, string lastname, string firstname)
    {
        this.asioid = asioid;
        this.firstname = firstname;
        this.lastname = lastname;
    }

    public string[] ToStringArray()
    {
        string[] data = new string[] { asioid, lastname, firstname };
        return data;
    }

    override public string ToString()
    {
        return asioid + ", " + lastname + ", " + firstname;
    }
}