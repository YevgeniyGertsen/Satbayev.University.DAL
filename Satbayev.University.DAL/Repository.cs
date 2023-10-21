using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.University.DAL
{
    public class Repository
    {
        public bool CreatQuestions(QuestionTemplate question) 
        {
            try
            {
                using (var db = new LiteDatabase(""))
                {
                    var col = db.GetCollection<QuestionTemplate>("QuestionTemplate");
                    col.Insert(question);
                }

                return true;
            }
            
            catch (Exception)
            {
            
                return false;
            }
        }
    }
}
