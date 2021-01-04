using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enums;

namespace Domain.Entities
{
    public class Attribute
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Slug { get; set; }
        public string Synopsis { get; set; }
        public string Description { get; set; }
        public int CoverImageTopOffset { get; set; }
        public string CanonicalTitle { get; set; }
        public string AverageRating { get; set; }
        public int UserCount { get; set; }
        public int FavoritesCount { get; set; }
        public string NextRelease { get; set; }
        public int PopularityRank { get; set; }
        public int RatingRank { get; set; }
        public string AgeRatingGuide { get; set; }
        public string Subtype { get; set; }
        public string Status { get; set; }
        public string Tba { get; set; }
        public int EpisodeCount { get; set; }
        public int EpisodeLength { get; set; }
        public int TotalLength { get; set; }
        public string YoutubeVideoId { get; set; }
        public bool Nsfw { get; set; }
        public string[] AbbreviatedTitles { get; set; }
        public AgeRating AgeRating { get; set; }
        public FilmType ShowType { get; set; }
        public RatingFrequencie RatingFrequencies { get; set; }
        public ICollection<Image> Images { get; set; }
        public Title Titles { get; set; }
        public int AnimeId { get; set; }
        public Anime Anime { get; set; }
    }
}
