

using DomainLayer.Models;
using ServiceLayer.Services;

Customer customer = new Customer(1, "Elcan", "Qurbanov", 19, "Developer");
Customer customer2 = new Customer(2, "Shaiq", "Kazimov", 25, "Developer");
Customer customer3 = new Customer(3, "Cavid", "Ismayilzade", 22, "Developer");
Customer customer4 = new Customer(4, "Roya", "Meherromova", 26, "Developer");


CustomerAge[] arr = { customer, customer2, customer3, customer4 };

CustomerAge CustomerAge = new CustomerAge();

Console.WriteLine(CustomerAge.GetAge(arr));
Console.WriteLine(CustomerAge.GetAgeCustomer(arr));

