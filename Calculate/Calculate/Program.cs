
using ServiceLayer;

CalculateService calculateService = new();
var result = calculateService.GetCalculate(new int[] {1,2,3,4});
Console.WriteLine(result);