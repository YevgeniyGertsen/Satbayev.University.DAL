using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Satbayev.University.DAL
{
    public class Repository
    {
        private string Path = @"C\Temp\SatbayevUniversityDAL.db";
        public bool CreatQuestions(QuestionTemplate question)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
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
        public bool UpdateQuestion(QuestionTemplate question)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var col = (db.GetCollection<QuestionTemplate>());
                    col.Update(question);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteQuestion(int questionId)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var col = db.GetCollection<QuestionTemplate>();
                    col.Delete(questionId);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<QuestionTemplate> GetQuestions()
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var col = db.GetCollection<QuestionTemplate>("QuestionTemplate");
                    return col.FindAll().ToList();

                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public List<QuestionTemplate> GetQuestionsByCategoryId(int id)
        {
            try
            {
                using (var db = new LiteDatabase(Path))
                {
                    var col = db.GetCollection<QuestionTemplate>("QuestionTemplate").
                         FindAll()
                         .Where(w => w.categoryId == id).ToList();
                    return col;
                }
            }
            catch (Exception)
            {
                return null;
            }


        }
        
        

    }
}
