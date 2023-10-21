using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SatbayevUniversiry.LIB;
using Satbayev.University.DAL;

namespace Satbayev.University.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Service service = new Service();
            QuestionTemplate question = new QuestionTemplate();
            question.author = "";
            question.mark = 3.1;
            question.level = "";
            question.categoryId = 1;
            question.creatDate = DateTime.Now;

            category category = new category();
            category.categoryName = "Math";

            question.category=category;

            string result = service.AddQuetion(question);

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
