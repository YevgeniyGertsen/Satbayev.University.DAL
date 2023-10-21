using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Satbayev.University.DAL;

namespace SatbayevUniversiry.LIB
{
    public class Service
    {
        public string AddQuetion(QuestionTemplate question)
        {
            Repository repository = new Repository();
            bool result = repository.CreatQuestions(question);

            if (result == true)
            {
                return "Вопрос успешно создана";
            }
            else { return "Ошибка"; }

        }
        public List<QuestionTemplate> GetAllQuetions()
        {
            Repository repository=new Repository();
            List<QuestionTemplate> list = repository.GetQuestions();
            return list;
        }
        
    }
}
