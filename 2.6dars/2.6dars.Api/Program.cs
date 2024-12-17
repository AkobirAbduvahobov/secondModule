using _2._6dars.Api.HMWRK;
using _2._6dars.Api.Services;
using _2._6dars.Api.Services.DTOs;
using System;

namespace _2._6dars.Api;

internal class Program
{
    static void Main(string[] args)
    {
        var responseQueueName = "salom";
        var replyTo = $"{responseQueueName}{Guid.NewGuid()}";

        Console.WriteLine(replyTo);

        //IUserService userService = new UserService();

        //var users = userService.GetUsers();



        //UserCreateDto dto1 = new UserCreateDto()
        //{
        //    FirstName = "Ali",
        //    LastName = "Vali",
        //    Age = 17,
        //    Password = "4545",
        //    Email = "Ali@gmail.com"
        //};


        //UserCreateDto dto2 = new UserCreateDto()
        //{
        //    FirstName = "Qovunlar",
        //    LastName = "Ikkichilar",
        //    Age = 19,
        //    Password = "4545",
        //    Email = "Qovunlar@gmail.com"
        //};


        //userService.AddUser(dto1);
        //userService.AddUser(dto2);





        //var bread = new Product()
        //{
        //    Price = 0.3,
        //    Stock = 4
        //};

        //var meat = new Product()
        //{
        //    Price = 10,
        //    Stock = 1.5
        //};

        //var milk = new Product()
        //{
        //    Price = 1,
        //    Stock = 2.5
        //};

        //var rope = new Product()
        //{
        //    Price = 1.2,
        //    Stock = 3
        //};

        //var cart = new ShoppingCart();
        //cart.AddProduct(rope);
        //cart.AddProduct(milk);
        //cart.AddProduct(meat);
        //cart.AddProduct(bread);

        //Console.WriteLine(cart.GetTotalPrice());


        //Console.WriteLine("Hello, World!");
    }
}

//4. BookCollection nomli sinf yarating, unda Book 
// obyektlarining xususiy(private) ro'yxati bo'lsin(har 
// bir Book obyektida Title va Author bo'lsin).
// Kolleksiyani boshqarish uchun AddBook(book) va GetBooksByAuthor(author) 
// metodlarini qo'shing.
