﻿namespace Book_Management.DataAccessLayer.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
    }
}
