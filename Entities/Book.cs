using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OptimizeMePlease.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(AuthorId))]
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public DateTime Published { get; set; }
        public string ISBN { get; set; }
        [ForeignKey(nameof(PublisherId))]
        public Publisher Publisher { get; set; }
        public int PublisherId { get; set; }
    }
}