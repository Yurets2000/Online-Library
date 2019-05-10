using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibraryMVC2.Models
{
    public class TitledInfo
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        [Index(IsUnique = true)]
        public string Title { get; set; }

        public IList<string> InfoBlocks { get; set; }

        public string InfoBlocksString
        {
            get { return string.Join("|", InfoBlocks); }
            set { InfoBlocks = value.Split('|').ToList(); }
        }
    }
}