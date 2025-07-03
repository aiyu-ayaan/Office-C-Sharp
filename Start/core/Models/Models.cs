using Start.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.core.Models
{

    public enum UserRole
    {
        ADMIN,
        TEACHER,
        STUDENT,
    }

    public class UserModel {
        private string _id;
        private string _name;
        private string _password;
        private UserRole _role;
        private long _createdAt;
        public UserModel( string name, string password, UserRole role)
        {
            _name = name;
            _password = password;
            _role = role;
            _createdAt = DateTimeUtils.GetCurrentTimeOnMilliseconds();
            _id = Guid.NewGuid().ToString();

        }

        public string Id { get { return _id; } private set { } }

        public string Name
        {
            get { return _name; }
            private set { }
        }
        public string Password
        {
            get { return _password; }
            set {
                if (value.Length < 6)
                {
                    throw new ArgumentException("Password must be at least 6 characters long.");
                }
                _password = value;
            }
        }
        public UserRole Role
        {
            get { return _role; }
            private set { }
        }
        public long CreatedAt
        {
            get { return _createdAt; }
            private set { }
        }

    }

  

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
