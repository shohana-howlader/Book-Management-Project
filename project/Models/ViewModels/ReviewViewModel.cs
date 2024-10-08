﻿namespace project.Models.ViewModels
{
    public class ReviewViewModel
    {
        public int? BookId { get; set; }
        public string BookTitle { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DatePosted { get; set; }
        public string BookPhotoUrl { get; set; }
    }
}