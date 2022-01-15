public class Student
{

    /// <summary>
    /// Property of Studnet Name with GET and SET
    /// </summary>
    public string StudnetName { get; set; }
    int RollNumber { get; set; }
    public DateTime? DateOfJoining { get; set; } //01/01/01

    /// <summary>
    /// STudent Field/Varilable
    /// </summary>
    public string StuName;

    public Student()
    {

    }
    public Student(string name, int rollNo, DateTime DOJ)
    {
        StudnetName = name;
        RollNumber = rollNo;
        DateOfJoining = DOJ;
    }

    public virtual int GetDurationOfJouning()
    {
        return Convert.ToInt32((DateTime.Now - DateOfJoining.Value).TotalDays);
    }

    public int GetDOJ()
    {
        return Convert.ToInt32((DateTime.Now - DateOfJoining.Value).TotalDays);
    }
    public int GetDOJ(DateTime doj)
    {
       return Convert.ToInt32((DateTime.Now - doj).TotalDays);
    }
    public int GetDOJ(DateTime doj,String frequency)
    {
        if (frequency == "days")
        {
           return Convert.ToInt32((DateTime.Now - doj).TotalDays);
        }
        else if(frequency=="month")
        {
            return Convert.ToInt32((DateTime.Now - doj).TotalDays/12);
        }
        else
        {
          return  Convert.ToInt32((DateTime.Now - doj).TotalDays);
        }
    }
}

public class College : Student
{

    public override int GetDurationOfJouning()
    {
        return Convert.ToInt32((DateTime.Now - DateOfJoining.Value).TotalDays / 30);
    }
}

public class Main_Function
{
    public static void Main()
    {
        
        
            College college = new College();
            //Total Month;
            college.GetDurationOfJouning();

            Student student = new Student("Harsh", 343, DateTime.Now.AddDays(-200));
            //Total Days
            student.GetDurationOfJouning();


            Student student2 = new Student();
            //Total Days
            //Will generate null exception
            student2.GetDurationOfJouning();
        student2.GetDOJ();
        student2.GetDOJ(DateTime.Now);
        student2.GetDOJ(DateTime.Now, "days");


    }


}