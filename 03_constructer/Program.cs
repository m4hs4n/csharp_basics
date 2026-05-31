namespace Program
{

    
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1, "Mahsan");

            var order = new Order();
            customer.Orders.Add(order);
            
            System.Console.WriteLine(customer.Id);
            System.Console.WriteLine(customer.Name);

            


        }

    }
}


