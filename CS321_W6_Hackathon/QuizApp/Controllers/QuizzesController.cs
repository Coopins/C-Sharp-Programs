using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using QuizApp.ApiModels;
using QuizApp.Core.Services;

namespace QuizApp.Controllers
{
    [Route("api/[controller]")]
    public class QuizzesController : Controller
    {

        private readonly IQuizService _quizService;

        // TODO: create a constructor and inject quiz service
        public QuizzesController(IQuizService quizService)
        {
            _quizService = quizService;
        }

        [HttpGet()]
        public IActionResult GetQuizzes()
        {
            // TODO: replace the following code with a complete implementation
            // that will return quizzes from the database
            ModelState.AddModelError("GetQuizzes", "Not Implemented!");
            return BadRequest(ModelState);
        }

        [HttpGet("{id}")]
        public IActionResult GetQuiz(int id)
        {
            // TODO: replace the following code with a complete implementation
            // that will return a single quiz
            try
            {
                var quiz = _quizService.Get(id);

                if (quiz == null) return NotFound();

                return Ok(quiz.ToApiModel());

            } catch
            {
                ModelState.AddModelError("GetQuiz", "Not Implemented!");
                return BadRequest(ModelState);
            }
        }

        // OPTIONAL - PUSH YOURSELF FURTHER
        // Implement a controller action that will return
        // a quiz containing five randomly selected questions.
    }
}
