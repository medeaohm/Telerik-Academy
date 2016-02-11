﻿using System;
using System.Collections.Generic;
using System.Linq;

using LibrarySystem.Models;

namespace LibrarySystem
{
    public partial class Books : System.Web.UI.Page
    {
        public LibraryDbContext dbContext;

        public Books()
        {
            this.dbContext = new LibraryDbContext();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IEnumerable<Category> RepeaterCategories_GetData()
        {
            return this.dbContext.Categories;
        }

        // The return type can be changed to IEnumerable, however to support
        // paging and sorting, the following parameters must be added:
        //     int maximumRows
        //     int startRowIndex
        //     out int totalRowCount
        //     string sortByExpression
        public IQueryable<LibrarySystem.Models.Category> ListViewCategories_GetData()
        {
            return this.dbContext.Categories;
        }

        protected void LinkButtonSearch_Click(object sender, EventArgs e)
        {
            string queryParam = string.Format("?q={0}", this.TextBoxSearchParam.Text);
            Response.Redirect("~/Search" + queryParam);
        }
    }
}