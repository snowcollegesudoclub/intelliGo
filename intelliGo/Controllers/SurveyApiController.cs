using System.Collections.Generic;
using System.Text.Json;
using intelliGo.Models;
using Microsoft.AspNetCore.Mvc;

namespace intelliGo.Controllers
{
    [ApiController]
    [Route("[SurveyApi]")]
    public class SurveyApiController : Controller
    {
        [HttpGet]
        public ActionResult<Survey> GetSurvey(int id)
        {
            return new Survey(){
                Id = 1,
                Name = "This is definitly Kyler's Survey #Yeet"
            };
        }

        [HttpPost]
        public ActionResult<string> CreateSurvey([FromBody]Survey survey)
        {
            return "ok";
        }

        [HttpPost]
        public ActionResult<string> SubmitAnswer(SurveyResponse surveyResponse)
        {
            return "ok";
        }

        [HttpGet]
        public ActionResult<IEnumerable<SurveyResponse>> GetAnswers(int surveyId)
        {
            var answers = new List<SurveyResponse>();
            var answer = new SurveyResponse(){
                Id = 1,
                SurveyId = 1,
                Answer = "one Answer",
                User = "Diego"
            };
            answers.Add(answer);
            answer = new SurveyResponse(){
                Id = 2,
                SurveyId = 1,
                Answer = "another Answer",
                User = "Diego again"
            };
            answers.Add(answer);
            answer = new SurveyResponse(){
                Id = 3,
                SurveyId = 1,
                Answer = "A third Answer",
                User = "Diego is a hacker"
            };
            answers.Add(answer);

            return answers;
        }
    }
}