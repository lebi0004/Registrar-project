namespace Registrar;

public class Helper
{
  public static List<Course> GetCourses ()
  {
    List<Course> courses = [];

    Course course = new Course
    {
      Code = "CST8282",
      Title = "Introduction to Database Systems",
      WeeklyHours = 4
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8253",
      Title = "Web Programming II",
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8256",
      Title = "Web Programming Language I",  
      WeeklyHours = 5
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8255",
      Title = "Web Imaging and Animations",  
      WeeklyHours = 2
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST8254",
      Title = "Network Operating System",  
      WeeklyHours = 1
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2200",
      Title = "Data Warehouse Design",  
      WeeklyHours = 3
    };
    courses.Add(course);

    course = new Course
    {
      Code = "CST2240",
      Title = "Advance Database topics",  
      WeeklyHours = 1
    };
    courses.Add(course);   

    return courses;
  }

  public static List<string> GetStudentTypes () {
    return ["Full Time", "Part Time", "Coop"];
  }



private static Random random = new Random();

private static List<Contact>? cachedContacts = null; /*Random Id issue! Static cache for contacts*/
   public static List<Contact> GetContacts ()
{
  if (cachedContacts != null)
  return cachedContacts;  /*Random Id issue! Return cached list if already created*/


    List<Contact> contacts = [];

    Contact contact = new Contact
    {
        FirstName = "John",
        LastName = "Doe",
        Type = "Full Time",
        Id = GenerateRandomId()
    };

    contacts.Add(contact);


     contact = new Contact
    {
        FirstName = "Jane",
        LastName = "Doe",
        Type = "Part Time",
        Id = GenerateRandomId()
    };

    contacts.Add(contact);

     contact = new Contact
    {
        FirstName = "John",
        LastName = "Smith",
        Type = "Coop",
        Id = GenerateRandomId()
    };

    contacts.Add(contact);

    cachedContacts = contacts;  /*Random Id issue! Cache the newly created list*/

    return contacts;
}

private static int GenerateRandomId()
{
  return random.Next(100000, 999999);
}
}
