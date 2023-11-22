review1.cs 
// Solution
public bool IsShopOpen(string dayOfWeek)
{
    if (!string.IsNullOrEmpty(dayOfWeek))
    {
        dayOfWeek = dayOfWeek.ToLower();
        if (dayOfWeek == "friday" || dayOfWeek == "saturday" || dayOfWeek == "sunday")
        {
            return true;
        }
        
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }

}

review3.cs
// Solution

public long Fibonacci(int num)
{
    if (num < 50 && num >= 0)
    {
        if (num == 0 || num == 1)
        {
            return num;
        }

        else return Fibonacci(num - 1) + Fibonacci(num - 2);
    }
    else
    {
        throw new System.Exception("Not supported");
    }
}


review4.cs
// Solution

var listOfCities = new[] { "Austin", "New York", "San Francisco" };

for (var i = 0; i < listOfCities.Count(); i++)
{
    var city = listOfCities[i];
    DoStuff();
    DoSomeOtherStuff();

    // ...
    // ...
    // ...
    // Wait, what is `li` for again?
    Dispatch(city);
}

review5.cs
// Solution

int userRole = Console.ReadLine();
if (userRole == 8) // Check if Admin 
{
    
}
else
{
  Console.WriteLine("Not an Admin")
}

review6.cs
// Solution

public class Car
{
    public string CarMake { get; set; }
    public string CarModel { get; set; }
    public string CarColor { get; set; }

    //...
}

review7.cs
// Solution

var yearMonthDate = DateTime.UtcNow.ToString("MMMM DD, YYYY");

review9.cs
// Solution

public void CreateMicrobrewery(string name = "Hipster Brew Co.")
{
    var breweryName;
    if(name != null){
        breweryname = name;
    }
    // ...
}



