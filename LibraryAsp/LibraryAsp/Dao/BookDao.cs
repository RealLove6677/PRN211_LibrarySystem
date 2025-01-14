﻿using LibraryAsp.Dao;
using LibraryAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;


namespace LibraryAsp.Dao
{
    public class BookDao
    {
        LibraryDbContext myDb = new LibraryDbContext();
        public List<Book> getAll()
        {
            return myDb.books.OrderByDescending(p => p.id_book).ToList();
        }
        public List<Book> getFiveBook()
        {
            return myDb.books.OrderByDescending(p => p.id_book).Take(5).ToList();
        }
        public void add(string name, string author, int id_publisher, int id_category, int year_publish, float price, string description, string image, int quantity,DateTime createdAt)
        {
            string sql = "insert into Books(name,author,id_publisher,id_category,year_publish,price,description,image,createdAt, quantity) " +
               "values(@name,@author,@publisher,@category,@year,@price,@des,@image,@create,@quantity)";
            myDb.Database.ExecuteSqlCommand(sql, new SqlParameter("@name", name),
                new SqlParameter("@author", author),
                new SqlParameter("@publisher", id_publisher),
                new SqlParameter("@category", id_category),
                new SqlParameter("@year", year_publish),
                new SqlParameter("@price", price),
                new SqlParameter("@des", description),
                new SqlParameter("@image", image),
                new SqlParameter("@create", createdAt),
                new SqlParameter("@quantity", quantity)
                );
        }
        public void delete(int id_book)
        {
            var result = myDb.books.Where(x => x.id_book == id_book).SingleOrDefault();
            myDb.books.Remove(result);
            myDb.SaveChanges();
        }

        public Book getOneBook(int id_book)
        {
            return myDb.books.Where(x => x.id_book == id_book).SingleOrDefault();
        }

        public void update(string name, string author, int id_publisher, int id_category, int year_publish, float price, string description, int quantity, int id_book)
        {
            
            string sql = @"update dbo.Books set [name] = @name, author = @author , id_category = @id_cat,
                    id_publisher = @id_pub, year_publish = @year, price = @price, [description] = @descrip, quantity = @quantity 
                    where id_book = @id_book
                    ";

            myDb.Database.ExecuteSqlCommand(sql, new SqlParameter("@name", name),
                new SqlParameter("@author", author),
                new SqlParameter("@id_cat", id_category),
                new SqlParameter("@id_pub", id_publisher),
                new SqlParameter("@year", year_publish),
                new SqlParameter("@price", price),
                new SqlParameter("@descrip", description),
                new SqlParameter("@quantity",quantity),
                new SqlParameter("@id_book", id_book)
                );
        }

        public void editQuantity(int id_book, int quantityNew)
        {
            string sql = @"update dbo.Books set quantity = @quantity where id_book = @id_book";
            myDb.Database.ExecuteSqlCommand(sql, new SqlParameter("@quantity", quantityNew)
                , new SqlParameter("id_book", id_book));
        }
    }
}