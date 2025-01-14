﻿using LibraryAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace LibraryAsp.Dao
{
    public class TransactionDao
    {
        LibraryDbContext myDb = new LibraryDbContext();
        public void borrowBook(Transaction transaction)
        {
            myDb.transactions.Add(transaction);
            myDb.SaveChanges();
        }
        public List<Transaction> getFiveNoti()
        {
            return myDb.transactions.OrderByDescending(p => p.id_transaction).Where(t => t.status==1).Take(5).ToList();
        }
        public Transaction checkExistTransaction(int userId, int bookId)
        {
            return myDb.transactions.Where(t => t.id_user == userId && t.id_book == bookId && t.status != 3 ).FirstOrDefault();
        }

        public List<Transaction> getTransactionBorrow(int userId)
        {
            
            return myDb.transactions.OrderByDescending(t => t.id_transaction).Where(t => t.status != 4 && t.id_user == userId).ToList();
        }

        public List<Transaction> getTransactionPunish(int userId)
        {
            return myDb.transactions.OrderByDescending(t => t.id_transaction).Where(t => t.status == 4 && t.id_user == userId).ToList();
        }

        public List<Transaction> getTransaction ()
        { 
            return myDb.transactions.OrderByDescending(t => t.id_transaction).ToList();
        }
        public Transaction getTransaction(int id)
        {
            return myDb.transactions.Where(a => a.id_transaction == id).FirstOrDefault();
        }
        public void updateStatus(int status, int id)
        {
            var obj = getTransaction(id);
            obj.status = status;
            myDb.SaveChanges();
        }
        public void autoPunish(int id_transac)
        {
            string sql = @"update Transactions set [status] = @status where id_transaction = @id_transac";
            myDb.Database.ExecuteSqlCommand(sql, new SqlParameter("@status", 4),
                new SqlParameter("@id_transac", id_transac));
        }
    }
}