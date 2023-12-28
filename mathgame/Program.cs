
using mathgame;
public class Program
{
    public static void Main()
    {
        string? name = helper.getName();
        var date = DateTime.UtcNow;

        menu mymenu = new menu();
        

        mymenu.Menu(name, date);
    }
}






