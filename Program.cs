using TimeSheets.App.Data;

class Program
{
    static void Main(string[] args)
    {

        var db = new TimeSheetDbContext();

        foreach (var s in db.StaffMembers) { 
        
            Console.WriteLine($"{s.FirstName} {s.Surname}");
        }



    }
}