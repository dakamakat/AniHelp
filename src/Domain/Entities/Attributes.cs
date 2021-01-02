using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Attributes
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Slug { get; set; }
        public string Synopsis { get; set; }
        public string Description { get; set; }
        public int CoverImageTopOffset { get; set; }      
        public string CanonicalTitle { get; set; }
        public IList<string> AbbreviatedTitles { get; set; }
        public string AverageRating { get; set; }
        public IDictionary<string,string> RatingFrequencies { get; set; }
        public int UserCount { get; set; }
        public int FavoritesCount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public object NextRelease { get; set; }
        public int PopularityRank { get; set; }
        public int RatingRank { get; set; }
        public string AgeRating { get; set; }
        public string AgeRatingGuide { get; set; }
        public string Subtype { get; set; }
        public string Status { get; set; }
        public string Tba { get; set; }
        public int EpisodeCount { get; set; }
        public int EpisodeLength { get; set; }
        public int TotalLength { get; set; }
        public string YoutubeVideoId { get; set; }
        public FilmType ShowType { get; set; }
        public bool Nsfw { get; set; }
        public Image PosterImage { get; set; }
        public Image CoverImage { get; set; }
        public Titles Titles { get; set; }
    }
}
