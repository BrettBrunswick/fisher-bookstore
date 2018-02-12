using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using Fisher.Bookstore.Pages;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Fisher.Bookstore.Models;

namespace Fisher.Bookstore.Pages
{

public class Books : PageModel
{
    public List<Book> books;

    
    public void OnGet()
    {    
        books = new List<Book>();
        
        books.Add(new Book()
        {
            Title = "My First Book",
            Author = "Brett Brunswick"
        });

        books.Add(new Book()
        {
            Title = "The Outsiders",
            Author = "Eric Church"
        });

        books.Add(new Book()
        {
            Title = "Traveller",
            Author = "Chris Stapleton"
        });
    }

}

}