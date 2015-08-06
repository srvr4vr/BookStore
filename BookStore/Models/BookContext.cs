﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class BookContext : DbContext
    {
        public BookContext() : base(nameOrConnectionString: "DefaultConnection") { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
    }
}