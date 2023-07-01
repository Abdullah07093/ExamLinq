// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
System.Console.WriteLine("Task 1");
System.Console.WriteLine("No need No need to learn a new language \n It’s a time-saver \n It’s more accessible");
System.Console.WriteLine("Task 2");
System.Console.WriteLine("Select - листаи листхоро меброрад, SelectMany- факат листаи ягон чизро меброрад ");
System.Console.WriteLine("Task 3");
System.Console.WriteLine("Мо метавонем (group by) ранге запросы SQL одии  бикунем е ин ки GroupBy() истифода барем");
System.Console.WriteLine("Task 4");
System.Console.WriteLine("authentication - ин холате хаст уи барнома месанча хаст е не фалон шахс, ва authorization- ин месанча ки хамин шахс чи рол-ро ичро мекунад");
System.Console.WriteLine("Task 5");
System.Console.WriteLine("аз db.Orders ва db.Customers дар холатеки CustomerId дар датабэйзи Orders== бошад бо  Id дар Customers ва чаьм мекунад бо c.Name , ва бар АКС меброрад бо маблагашон, ва бо ном-ранге калит ва чаьми маблагхоро бо маблагхо Меброрад  ");
System.Console.WriteLine("Problem1 ");
int[] numbers = { 1, 5, 8, 12, 15, 20 };
var result = from item in numbers where item>10 select item;
var result2 = numbers.Where(item=> item>10);
foreach (var item in result)
{
    System.Console.WriteLine(item);
    
}
System.Console.WriteLine();
foreach (var item in result2)
{System.Console.WriteLine(item);
    
}
System.Console.WriteLine("Problem2 ");
var resul3 = from item in numbers where item%2==0  select item;
var g=0;
var f=0;
var result4 = numbers.Where(item=> item%2==0);
foreach (var item in resul3)
{
g+=item;
}
 System.Console.WriteLine(g);
System.Console.WriteLine();
foreach (var item in result4)
{
    f+=item;
}
System.Console.WriteLine(f);
System.Console.WriteLine("Problem3 ");

string[] names = { "Alice", "Anny", "Amy", "Dave", "Alex" };
var result5 = from item in names where item.StartsWith("A") && item.EndsWith("A") select item;
var result6 = names.Where(l=> l.StartsWith("A")).Where(l=>l.EndsWith("A"));

foreach(string word in result5) {
   Console.WriteLine(word);
}
System.Console.WriteLine();

foreach(string word in result6) {
   Console.WriteLine(word);
}
System.Console.WriteLine("Problem4 ");

int[] numbers1 = { 5, 8, 12, 15, 20, 25, 30 };
var resul7 = (from item in numbers1 orderby item descending  select item).Take(3)  ;
foreach (var item in resul7)
{
    Console.WriteLine(item);
}
System.Console.WriteLine();
var result8 = numbers1.OrderDescending().Take(3);
foreach (var item in resul7)
{
    Console.WriteLine(item);
}
System.Console.WriteLine("Problem5 ");

string[] words = { "apple", "banana", "cherry", "date", "elderberry" };

var resul13= (from w in words  orderby  w.Length descending select  w) ;
var resul14= words.OrderByDescending(l=>l.Length) ;
foreach (var item in resul13)
{
    Console.WriteLine( item);
}
System.Console.WriteLine();

foreach (var item in resul14)
{
    Console.WriteLine(item);
}
