﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using QuizApp.Core.Models;
using QuizApp.Core.Services;

namespace QuizApp.Infrastructure.Data
{
    public class QuestionRepository : IQuestionRepository
    {
        // TODO: inherit and implement the IQuestionRepository interface

        private readonly AppDbContext _appDbContext;

        public QuestionRepository(AppDbContext appDbContext) 
        {
            // TODO: inject and store AppDbContext
            _appDbContext = appDbContext;
        }

        public Question Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Question> GetAll()
        {
            throw new NotImplementedException();
        }

        public Question Add(Question newQuestion)
        {
            throw new NotImplementedException();
        }

        public Question Update(Question updatedQuestion)
        {
            throw new NotImplementedException();
        }

        public void Remove(Question question)
        {
            throw new NotImplementedException();
        }

        // TODO: The Update() method needs some special logic that you have not seen before.
        // It will update the Question AND also update all of the related Answers. Here is
        // the implementation for Update:
        //public Question Update(Question updatedItem)
        //{
        //    // retrieve the existing question
        //    var existingItem = this.Get(updatedItem.Id);
        //    if (existingItem == null) return null;

        //    // copy updated property values into the existing question
        //    _dbContext.Entry(existingItem)
        //       .CurrentValues
        //       .SetValues(updatedItem);

        //    // loop thru all of the answers in the updated question
        //    foreach (var updatedAnswer in updatedItem.Answers)
        //    {
        //        // find the existing answer that corresponds to the updated answer
        //        var existingAnswer = existingItem.Answers
        //        .Where(a => a.Id == updatedAnswer.Id)
        //        .SingleOrDefault();
        //        // update existing answer from updated answer
        //        _dbContext.Entry(existingAnswer)
        //            .CurrentValues
        //            .SetValues(updatedAnswer);
        //    }

        //    // save all the changes
        //    _dbContext.Questions.Update(existingItem);
        //    _dbContext.SaveChanges();
        //    return existingItem;
        //}
    }
}
