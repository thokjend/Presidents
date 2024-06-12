using Presidents;

//Console.Write("Enter year from: ");
//int yearFrom = Int32.Parse(Console.ReadLine());
//Console.Write("Enter year to: ");
//int yearTo = Int32.Parse(Console.ReadLine());

Console.Write("Enter name: ");
var name = Console.ReadLine();

var app = new App();

//app.ShowPresidentWithMoreThan1Period();

//app.CountParty();

//app.SearchByYear(yearFrom, yearTo);
app.SearchByName(name);
