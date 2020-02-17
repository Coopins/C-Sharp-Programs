﻿using CS321_W4D2_BookAPI.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CS321_W4D2_BookAPI.ApiModels
{
    public static class BookMappingExtenstions
    {

        public static BookModel ToApiModel(this Book book)
        {
            return new BookModel
            {
                Id = book.Id,
                Title = book.Title,
                Genre = book.Genre,
                OriginalLanguage = book.OriginalLanguage,
                PublicationYear = book.PublicationYear,
                PublisherId = book.PublisherId,
                Publisher = book.Publisher != null 
                    ? book.Publisher.Name + ", " + book.Publisher.HeadQuartersLocation 
                    : null,
                AuthorId = book.AuthorId,
                Author = book.Author != null 
                    ? book.Author.LastName + ", " + book.Author.FirstName 
                    : null
            };
        }

        public static Book ToDomainModel(this BookModel bookModel)
        {
            return new Book
            {
                Id = bookModel.Id,
                Title = bookModel.Title,
                Genre = bookModel.Genre,
                OriginalLanguage = bookModel.OriginalLanguage,
                PublicationYear = bookModel.PublicationYear,
                PublisherId = bookModel.PublisherId,
                AuthorId = bookModel.AuthorId,
            };
        }

        public static IEnumerable<BookModel> ToApiModels(this IEnumerable<Book> authors)
        {
            return authors.Select(a => a.ToApiModel());
        }

        public static IEnumerable<Book> ToDomainModel(this IEnumerable<BookModel> authorModels)
        {
            return authorModels.Select(a => a.ToDomainModel());
        }
    }
}
