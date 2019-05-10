using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryMVC2.Models
{
    public class LibraryInfoViewModel
    {
        public Description Description { get; set; }
        public IEnumerable<IndexBookSet> BookSets { get; set; }
    }

    public class IndexBookSet
    {
        public IList<string> Info { get; set; }
        public string ActionLink { get; set; }
        public IEnumerable<TextBook> TextBooks { get; set; }
        public IEnumerable<AudioBook> AudioBooks { get; set; }
        public string Type { get; set; }
    }

    public class CatalogViewModel
    {
        public string SearchString { get; set; }
        public Genre SelectedGenre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<TextBook> TextBooks { get; set; }
        public IEnumerable<AudioBook> AudioBooks { get; set; }
        public Description Description { get; set; }
    }
    

    public class PageInfo
    {
        public string BaseUrl { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / PageSize); }
        }
    }

    public class BookSelection
    {
        public string Title { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public PageInfo PageInfo { get; set; }
    }

}