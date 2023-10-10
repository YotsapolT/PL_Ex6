using System;
class CustomerMailApplication
{
    public static void Main(string[] args)
    {
        Customer cust = getCustomerTypeFromUser();
        string? mail = null;
        if (cust != null)
        {
            mail = generateMail(cust);
            Console.WriteLine(mail);
        }
        else
        {
            Console.WriteLine("Error");
        }

    }
    public static string generateMail(Customer cust)
    {
        return cust.createMail();
    }
    public static Customer getCustomerTypeFromUser()
    {
        Customer? cust = null;
        Console.Write("Please choose customer type 1. Regular, 2. Mountain, 3. Delinquent ");
        int type = Convert.ToInt32(Console.ReadLine());
        switch (type)
        {
            case 1:
                cust = CustomerFactory.createCustomer("Regular");
                break;
            case 2:
                cust = CustomerFactory.createCustomer("Mountain");
                break;
            case 3:
                cust = CustomerFactory.createCustomer("Delinquent");
                break;
        }
        return cust;
    }
}
