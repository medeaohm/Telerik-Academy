using LibrarySystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem.Admin
{
    public partial class EditBooks : System.Web.UI.Page
    {
        public LibraryDbContext dbContext;

        public EditBooks()
        {
            this.dbContext = new LibraryDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<LibrarySystem.Models.Book> GridViewBooks_GetData()
        {
            return this.dbContext.Books.OrderBy(b => b.ID);
        }

        public IQueryable<Category> DropDownListCategoriesCreate_GetData()
        {
            return this.dbContext.Categories.OrderBy(c => c.Name);
            ;
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewBooks_UpdateItem(int ID)
        {
            Book item = this.dbContext.Books.Find(ID);
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", String.Format("Item with id {0} was not found", ID));
                return;
            }
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
               this.dbContext.SaveChanges();
            }
        }

        // The id parameter name should match the DataKeyNames value set on the control
        public void GridViewBooks_DeleteItem(int ID)
        {
            Book item = this.dbContext.Books.Find(ID);
            // Load the item here, e.g. item = MyDataLayer.Find(id);
            if (item == null)
            {
                // The item wasn't found
                ModelState.AddModelError("", string.Format("Item with id {0} was not found", base.ID));
                return;
            }

            this.dbContext.Books.Remove(item);
            this.dbContext.SaveChanges();
        }

        public void FormViewInsertBook_InsertItem()
        {
            var item = new LibrarySystem.Models.Book();
            TryUpdateModel(item);
            if (ModelState.IsValid)
            {
                this.dbContext.Books.Add(item);
                this.dbContext.SaveChanges();

            }
        }

        protected void LinkButtonInsert_Click(object sender, EventArgs e)
        {
            this.btnWrapper.Visible = false;

            var fv = this.UpdatePanelInsertBook.FindControl("FormViewInsertBook") as FormView;
            fv.Visible = true;
        }
    }
}