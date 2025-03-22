Console.WriteLine("enter your lastname");
string name = Console.ReadLine();
string NewName = name.ToUpper();
Console.WriteLine(NewName);
Console.WriteLine("enter your middlename");
string name1 = Console.ReadLine();
string NewName1 = name1.ToUpper();
Console.WriteLine(" enter your firstname");
string name2 = Console.ReadLine();
string NewName2 = name2.ToUpper();

    Console.WriteLine("enter your date of birth: YYYY-MM-DD");
    DateOnly Dob = DateOnly.Parse(Console.ReadLine());
    Console.WriteLine(Dob);
    
        // address
        Console.WriteLine("enter your street name");
string streetname= Console.ReadLine();
Console.WriteLine("enter your city");
string city= Console.ReadLine();
Console.WriteLine("enter your state");
string state=Console.ReadLine();
Console.WriteLine("enter your country of residence");
string country=Console.ReadLine();
Console.WriteLine("enter your suitename");
string suitname=Console.ReadLine();
Console.WriteLine("enter your LGA");
string LGA=Console.ReadLine();


string fullname = ($"my name is {name} {name1} {name2} my date of birth is {Dob}");
string address = ($"my street is {streetname} {city} {state} {country} {LGA} {suitname}");
Console.WriteLine(fullname.ToUpper());
Console.WriteLine(address.ToUpper());


    

