using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DataHandler
{
    DataReader dataReader;
    List<Attendance> attendances;
    List<Student> students;

    public DataHandler()
    {
        dataReader = new DataReader();
        attendances = new List<Attendance>();
        students = new List<Student>();
    }

    public Boolean FetchData()
    {
        return FetchData("");
    }

    public Boolean FetchData(string search)
    {
        DataReader attendanceReader = new DataReader();
        attendances = attendanceReader.ReadToList(search);
        if (attendances == null) return false;
        DataReader studentReader = new DataReader();
        students = studentReader.ReadStudentsToList(search);
        students = students.Distinct().ToList<Student>();
        if (students == null) return false;
        return true;
    }

    public string GetTestData()
    {
        IEnumerable<string> students = from attendance in attendances
                                        let asioid = (string)attendance.asioid
                                        select asioid;
        students = students.Distinct();

        IEnumerable<string> courses = from attendance in attendances
                                        let course = (string)attendance.course
                                        select course;
        courses = courses.Distinct();

        return students.Count<string>() + " eri oppilasta " + courses.Count<string>() + " eri kurssilla";
    }

    public DataTable GetDataTable()
    {
        DataTable attendanceTable = new DataTable();
        attendanceTable.Columns.Add("asioid", typeof(string));
        attendanceTable.Columns.Add("lastname", typeof(string));
        attendanceTable.Columns.Add("firstname", typeof(string));
        attendanceTable.Columns.Add("date", typeof(string));
        attendanceTable.Columns.Add("course", typeof(string));

        foreach (Attendance attendee in attendances)
        {
            attendanceTable.Rows.Add(attendee.ToStringArray());
        }

        return attendanceTable;
    }

    public DataTable GetStudentDataTable()
    {
        DataTable studentTable = new DataTable();
        studentTable.Columns.Add("asioid", typeof(string));
        studentTable.Columns.Add("lastname", typeof(string));
        studentTable.Columns.Add("firstname", typeof(string));

        foreach (Student student in students)
        {
            studentTable.Rows.Add(student.ToStringArray());
        }

        return studentTable;
    }
}
