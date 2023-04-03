


using System.Runtime.CompilerServices;

class Program
{
    //static void Main(string[] args)
    //{

    //    1) შექმენით მეთოდი, რომელსაც ექნება სამი გადასაცემი პარამეტრი: სახელი, მიმდინარე თარიღი და ასაკი.
    //სამივე მონაცემი უნდა შევიყვანოთ კონსოლიდან და მეთოდის საშუალებით უნდა დაბრუნდეს მნიშვნელობა; შედეგი კი დაიბეჭდოს კონსოლზე


        MyFirstMethod("Sophie", "DateTime", 33);
        Console.Write("Current Date is : ");
        DateTime Now = DateTime.Now;
        Console.WriteLine(DateTime.Now.ToString("M/d/yyyy"));
        Console.ReadLine();
    }

    static void MyFirstMethod(string name, string Date, int age)


    {
        Console.WriteLine(name + ", " + age);

    }

     //2) შექმენით მეთოდი:  თუ კონსოლიდან გადავეცი + უნდა დააბრუნოს გადაცემული ორი რიცხვის ჯამი,
     //თუ კონსოლიდან გადავეცი * უნდა დააბრუნოს ორი რიცხვის ნამრავლი.

     //2.1
    static int MyMethod(int x, int y)
    {
        return x + y;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(MyMethod(15, 111));
    }

    //2.2
    static int MyMethod(int x, int y)
    {
        return x * y;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(MyMethod(40, 10));
    }



    //3)შექმენით მეთოდი, რომელსაც ექნება ერთი პარამეტრი.თუ გადაცემული რიცხვი იქნება უარყოფითი დააბრუნოს 0,
    //    //წინააღმდეგ შემთხვევაში დააბრუნოს გადაცემული რიცხვი.

        static int MyMethod(int x)
    {

        int result;

        if (x < 0)
        {
            result = 0;
        }
        else
        {
            result = x;

            return result;
        }

        {
            Console.WriteLine(MyMethod(-50));
        }
    }





    //4) შექმენით მეთოდი, რომელიც გამოითვლის რამდენი კგ ტვირთი იქნება გადასაზიდი.გადასაცემი პარამეტრები იქნება ერთი ერთეულის წონა და რაოდენობა.
    //წონა იქნება default მნიშვნელობის და მისი მნიშვნელობა იქნება 50.

    static void Main()
    {

        Console.WriteLine("Enter the quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());

        int defaultweight = 50;
        Console.WriteLine("defaultweight is:" + defaultweight);

        Console.WriteLine("The result of kg is: " + (quantity * defaultweight));
    }



    //5)შექმენით ორი გადატვირთული მეთოდი.თუ გადაეცა ორი პარამეტრი, დააბრუნოს სახელი და გვარი. თუ გადაეცა სამი პარამეტრი,
    //დააბრუნოს თქვენი სახელი გვარი და დაბადების წელი.


    static string Bio(string name, string Lastname)
    {
        return name + Lastname;
    }

    static string Bio(string name, string Lastname, string birthdate)
    {
        return name + Lastname + birthdate;
    }

    static void Main(string[] args)
    {
        string x1 = Bio("Sophie", "Martiashvili");
        string x2 = Bio("Sophie", "Martiashvili", "06/12/1989");
        Console.WriteLine("name and lastname: " + "  " + x1);
        Console.WriteLine("name, lastname, age : " + "  " + x2);
    }




}

}


