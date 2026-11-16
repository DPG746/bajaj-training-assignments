using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using System.Xml.Linq;
using Assignment_Lambda;

class Program
{
    public static void Main()
    {
	    
        Console.WriteLine("LAMBDA ASSIGNMENT:");
	   
       // Query 1: Find total number of customers in each city
			
       // var result = customers.GroupBy(c => c.City);
       //
       // foreach (var c in result)
       // {
	      //  Console.WriteLine(c.Key + " " + c.Count());
       // }
      
       
       List<Customer> customers = GetAllCustomers();

       var result = customers.GroupBy(c => c.City).Select(g => new
       {
	       City = g.Key,
	       TotalCustomers = g.Count()
       });

       foreach (var items in result)
       {
	       Console.WriteLine(items.City+" "+items.TotalCustomers);
       }
       
       
       
       
       
       //Query 2: Select all customers
       
       // var query1 = from customer in GetAllCustomers()
	      //  select customer;
	      
	      var query1= GetAllCustomers().Select(customer =>customer);
	      
	      foreach (var items in query1)
	      {
		      Console.WriteLine(items.ContactName);
	      }
	      
	      
	      
	      
	      //Query 3: Find customers whose city is New York
	      
	      // var query1 = from customer in GetAllCustomers()
		     //  where customer.City == "New York"
		     //  select customer;


		     var qq = customers.Where(c => c.City == "New York");

		     foreach (var items in qq)
		     {
			     Console.WriteLine(items.ContactName);
		     }
		     
		     
		     
		     
		     
		     
		     //Query 4: Order customers by City descending and ContactName ascending
		     
		     // var query1 = from customer in GetAllCustomers()
			    //  orderby customer.City descending,
				   //   customer.ContactName
			    //  select customer;
			    
			    
			    var q2 = GetAllCustomers().OrderByDescending(customer=>customer.City).ThenBy(customer=>customer.ContactName);

			    foreach (var items in q2)
			    {
				    Console.WriteLine(items.ContactName);
			    }
			    
			    
			    
			    
			    // Query 5:Query 5: Group customers by ContactName
			    
			    // var query1 = from customer in GetAllCustomers()
				   //  group customer by customer.ContactName into g
				   //  select g;


				   var cus = GetAllCustomers().GroupBy(c => c.ContactName);

				   foreach (var item in cus)
				   {
					   Console.WriteLine("Group Name:"+item.Key);

					   foreach (var customer in item)
					   {
						   Console.WriteLine($"Contact Name:{customer.ContactName} ," + $"Customer id:{customer.CustomerId},"+ $"City:{customer.City}");
					   }
					   
				   }
				   
				   
				   
				   
				   // Query 6: Find customers from New York using Where
				   
				   var q3= GetAllCustomers().Where(c => c.City == "Lucknow");

				   foreach (var iit in q3)
				   {
					   Console.WriteLine(iit.ContactName);
				   }
				   
				   
				   
				   //Query 7: Select all Orders
				   
				   // var query2 = from order in GetAllOrders()
					  //  select order;


					  var q7 = GetAllOrders()
						  .Select(order => order);
					  
					  foreach (var item in q7)
					  {
						  Console.WriteLine(
							  $"Order Id {item.OrderId}, " +
							  $"Order Date {item.OrderDate}, " +
							  $"Required Date {item.RequiredDate}, " +
							  $"placed by {item.CustomerId}"
						  );
					  }
    }
	
	
    private static List<Customer> GetAllCustomers(){
	    
        return new List<Customer>(){
            new Customer{CustomerId = 1, ContactName="John Doe", City="New York"},
            new Customer{CustomerId = 2, ContactName="Durga", City="Lucknow"},
            new Customer{CustomerId = 3, ContactName="DPG", City="New York"},
            new Customer{CustomerId = 4, ContactName="nishant", City="Mumbai"},
        };
	    
    }

    private static List<Order> GetAllOrders()
    {
	    return new List<Order>()
	    {
		    new Order()
			    { OrderId = 101, OrderDate = DateTime.Now, RequiredDate = DateTime.Now.AddDays(2), CustomerId = 2 },
		    new Order()
		    {
			    OrderId = 102, OrderDate = DateTime.Now, RequiredDate = DateTime.Now.AddDays(2), CustomerId = 2
		    },
		    new Order()
		    {
			    OrderId = 103, OrderDate = DateTime.Now, RequiredDate = DateTime.Now.AddDays(2), CustomerId = 5
		    },
		    new Order()
		    {
			    OrderId = 103, OrderDate = DateTime.Now, RequiredDate = DateTime.Now.AddDays(2), CustomerId = 5
		    },
		    new Order()
		    {
			    OrderId = 104, OrderDate = DateTime.Now, RequiredDate = DateTime.Now.AddDays(2), CustomerId = 4
		    },
		    new Order()
		    {
			    OrderId = 105, OrderDate = DateTime.Now, RequiredDate = DateTime.Now.AddDays(2), CustomerId = 4
		    }
	    };
    }
	
    
    

    private static List<OrderItem> GetAllOrderItems()
    {
	    return new List<OrderItem>()
	    {
		    new OrderItem() { ItemId = 1, Quantity = 2, ProductId = 1001, OrderId = 101 },
		    new OrderItem() { ItemId = 2, Quantity = 3, ProductId = 1002, OrderId = 101 },
		    new OrderItem() { ItemId = 3, Quantity = 1, ProductId = 1003, OrderId = 102 },
		    new OrderItem() { ItemId = 4, Quantity = 5, ProductId = 1004, OrderId = 103 },
		    new OrderItem() { ItemId = 5, Quantity = 2, ProductId = 1005, OrderId = 104 }
	    };
    }
}

internal class Customer
{
	public int CustomerId { get; set; }
	public string ContactName { get; set; } = string.Empty;
	public string City { get; set; } = string.Empty;
}
    
