using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.core.Models
{

    enum UserRole
    {
        ADMIN,
        TEACHER,
        STUDENT,
    }

    public class UserModel { }

  

    public class BookModel {
        private string _bookName;
        private string _authorName;
        private string _publisherName;
        private int _bookId;
        private int _bookPrice;
        private long createdAt;
        public BookModel(string bookName, string authorName, string publisherName,int bookPrice)
        {
            _bookName = bookName;
            _authorName = authorName;
            _publisherName = publisherName;
            _bookPrice = bookPrice;
            Random random = new Random();
            _bookId = random.Next(1000, 9999);
        }

        public string BookName
        {
            get { return _bookName; }
            private set {  }
        }

        public string AuthorName
        {
            get { return _authorName; }
            private set { }
        }

        public string PublisherName
        {
            get { return _publisherName; }
            private set {  }
        }

        public int BookId
        {
            get { return _bookId; }
            private set { }
        }

        public int BookPrice
        {
            get { return _bookPrice; }
            set { _bookPrice = value; }
        }
        public override string ToString()
        {
            return $"Book ID: {_bookId}, Book Name: {_bookName}, Author: {_authorName}, Publisher: {_publisherName}, Price: {_bookPrice}";
        }

    }
}
