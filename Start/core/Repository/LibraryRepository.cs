using Start.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Start.core.Repository
{
    public interface LibraryRepository
    {
        void createUser(UserModel user);

        void updateUser(UserModel user);

        void deleteUser(string userId);

        UserModel getUserById(string userId);

        List<UserModel> getAllUsers();

        void createBook(BookModel book);

        void updateBook(BookModel book);

        void deleteBook(string bookId);


        BookModel getBookById(string bookId);

        List<BookModel> getAllBooks();

       void updateIssue(IssueModel issue);

    }
}
