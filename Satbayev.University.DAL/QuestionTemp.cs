using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.University.DAL
{
    public class QuestionTemplate
    {
        public int id { get; set; }
        public DateTime creatDate { get; set; }
        public string author { get; set; }
        public string questions { get; set; }
        public double mark { get; set; }
        public string level { get; set; }
        public string changeAuthor { get; set; }
        public DateTime changeDate { get; set; }
        public category category { get; set; }
        public int categoryId { get; set; }

    }
}
