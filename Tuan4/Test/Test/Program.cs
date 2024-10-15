
int[] numbers = { 3, 4, 5, 2, 5 };
//query syntax
IEnumerable<int> query1 = from num in numbers
                          where num % 2 == 0
                          orderby num
                          select num;
var query2 = numbers
         .Where(n => n % 2 != 0)
            .OrderBy(n => n);
foreach (var item in query2)
{
    Console.WriteLine(item);
}