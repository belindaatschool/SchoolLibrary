using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class SchoolLib
    {
        //תכונות המחלקה
        private string nameSchool;
        private Address address;
        private Book[] books;
        private int numOfBooks;

        public SchoolLib(string nameSchool, Address address)
        {
            this.nameSchool = nameSchool;
            this.address = address;
            this.books = new Book[10000];
            this.numOfBooks = 0;
        }
        public bool AddBook(Book b)
        {
            if(numOfBooks >= books.Length)
                return false;
            Book libraryBook = new Book(b);
            books[numOfBooks++] = libraryBook;
            return true;
        }
        public bool RemoveBook(int code)
        {
            //מצאי את הספר עם הקוד הנתון
            for(int i=0; i < numOfBooks; i++)
            {
                if (books[i].GetCode() == code)
                {
                    books[i] = null;
                    numOfBooks--;

                    //סגירת החור
                    for (int j = i; j < numOfBooks; j++)
                    {
                        books[j] = books[j + 1];
                    }               
                    return true;
                }
            }
            return false;
        }
        //פעולת תאור העצם
        public override string ToString()
        {
            string booksDetailsStr = "";
            for (int i = 0; i < this.numOfBooks; i++)
                booksDetailsStr += books[i].ToString() + "\n";
            return "School Name: " + this.nameSchool + " Address: " + this.address + "\n" + booksDetailsStr;
        }
    }
}
