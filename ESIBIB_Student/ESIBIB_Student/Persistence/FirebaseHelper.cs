﻿using ESIBIB_Student.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESIBIB_Student.Persistence
{
    class FirebaseHelper
    {
        FirebaseClient firebase= new FirebaseClient("https://esilib.firebaseio.com/");
        public FirebaseHelper()
        {
        }

        public async Task AddBook(int id, string Title, string Writer, string Description,string isbn,int available,string coverurl)
        {
            await firebase
              .Child("Book")
              .PostAsync(new Book() { ID = id, Title = Title, Author = Writer, Description = Description ,Available = available,Coverurl = coverurl,ISBN=isbn});
        
        }



        public async Task<List<Book>> GetAllBooks()
        {

            try
            {
                return (await firebase
               .Child("Book")
               .OnceAsync<Book>()).Select(item => new Book
               {
                   ID = item.Object.ID,
                   Title = item.Object.Title,
                   Author = item.Object.Author,
                   Description = item.Object.Description,
                   ISBN = item.Object.ISBN,
                   Coverurl = item.Object.Coverurl,
                   Available= item.Object.Available,
               }).ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("GetUsers  Additional information..." + ex, ex);
            }
        }

    }
}
