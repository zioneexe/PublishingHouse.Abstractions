﻿namespace PublishingHouse.Abstractions.Entity
{
    public interface IBook
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int? Sku { get; set; }
        public string? Isbn { get; set; }
        public int? Pages { get; set; }
        public int? PublicationYear { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public string? Size { get; set; }
        public double? Weight { get; set; }
        public string? Annotation { get; set; }
        public string? CoverImagePath { get; set; }
        public DateTime? CreateDateTime { get; set; }
        public DateTime? UpdateDateTime { get; set; }
    }
}
