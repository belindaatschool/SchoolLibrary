using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Book
    {
        private int code;
        private string title; //name of the book
        private Date publish;
        private bool isEdu;        
        private string description;
        private string author;
        private bool isLoan;

        public Book(int code, string title, Date publish, bool isEdu, string description, string author, bool isLoan)
        {
            this.code = code;
            this.title = title;
            this.publish = publish;
            this.isEdu = isEdu;
            this.description = description;
            this.author = author;
            this.isLoan = isLoan;
        }
        public int GetCode() { return code; }
        public string GetTitle() { return title; }
        public Date GetPublish() { return publish; }
        public bool IsEdu() { return isEdu; }
        public string GetDescription() { return description; }
        public string GetAuthor() { return author; }
        public bool IsLoan() { return isLoan; }
            

    }
}
