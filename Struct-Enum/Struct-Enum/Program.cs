

using Struct_Enum;
using Struct_Enum.Constans;
using Struct_Enum.Enum;

//Test test = new Test();
//test.MyProperty = 1;

//Console.WriteLine(test.MyProperty);



//Employee employee = new Employee("Mirze", "Bashirzade", 26, "bulbule");



//Console.WriteLine(GetEmployee(employee));

//static Employee GetEmployee(Employee employee)
//{
//    return employee;
//}

//string email = "ff@gmail.com";

//if (email != "tt@gmail.com")
//{
//    Console.WriteLine(Errors.LoginMessage);
//}       



//int roleId = 1;

//switch (roleId)
//{
//	case (int)Roles.SuperAdmin:
//		Console.WriteLine("Super admindir");
//		break;
//    case (int)Roles.Admin:
//        Console.WriteLine("admindir");
//        break;
//    case (int)Roles.Member:
//        Console.WriteLine("Memberdir");
//        break;
//    default:
//        Console.WriteLine("Role tapilmadi");
//        break;
//}


//string[] result = (string[])Enum.GetValues(typeof(Roles));

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}

//string[] names = Enum.GetNames(typeof(Roles));

//string InputData = "Admin";

//foreach (var item in names)
//{
//    if (InputData == item)
//    {
//        Console.WriteLine($"User role is - {item}");
//        break;
//    }

//}


int[] result = (int[])Enum.GetValues(typeof(Roles));

foreach (var item in result)
{
    Console.WriteLine(item);
}
