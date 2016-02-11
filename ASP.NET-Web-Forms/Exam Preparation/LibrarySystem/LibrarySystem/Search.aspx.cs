using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem
{
    public partial class Search : System.Web.UI.Page
    {
        public LibraryDbContext dbContext;

        public Search()
        {
            this.dbContext = new LibraryDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Book> Repeater_GetData([QueryString("q")] string query)
        {
            this.LiteralSerachQuery.Text = string.Format("“{0}”:", query);
            var books = this.dbContext.Books.Where(b=>b.Title != string.Empty);
            if (!string.IsNullOrWhiteSpace(query))
            {
                books =
                 this.dbContext.Books.
                 Where(b => b.Author.ToLower().Contains(query.ToLower()) || b.Title.ToLower().Contains(query.ToLower()));
            }
            
            return books;
        }

        protected string GetTitle(Book book)
        {
            return string.Format("“{0}” <i>by {1}</i>", Server.HtmlEncode(book.Title), Server.HtmlEncode(book.Author));
        }
    }
}