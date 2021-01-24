using System.Collections.Generic;
using Newtonsoft.Json;

namespace Application.Common.Models
{
        public class Links
        {
            [JsonProperty("self")]
            public string Self { get; set; }

            [JsonProperty("related")]
            public string Related { get; set; }

            [JsonProperty("first")]
            public string First { get; set; }

            [JsonProperty("next")]
            public string Next { get; set; }

            [JsonProperty("last")]
            public string Last { get; set; }
        }

        public class Titles
        {
            [JsonProperty("en")]
            public string En { get; set; }

            [JsonProperty("en_jp")]
            public string EnJp { get; set; }

            [JsonProperty("ja_jp")]
            public string JaJp { get; set; }

            [JsonProperty("en_us")]
            public string EnUs { get; set; }
        }

        public class Tiny
        {
            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            public int Height { get; set; }
        }

        public class Small
        {
            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            public int Height { get; set; }
        }

        public class Medium
        {
            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            public int Height { get; set; }
        }

        public class Large
        {
            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            public int Height { get; set; }
        }

        public class Dimensions
        {
            [JsonProperty("tiny")]
            public Tiny Tiny { get; set; }

            [JsonProperty("small")]
            public Small Small { get; set; }

            [JsonProperty("medium")]
            public Medium Medium { get; set; }

            [JsonProperty("large")]
            public Large Large { get; set; }
        }

        public class Meta
        {
            [JsonProperty("dimensions")]
            public Dimensions Dimensions { get; set; }

            [JsonProperty("count")]
            public int Count { get; set; }
        }

        public class PosterImage
        {
            [JsonProperty("tiny")]
            public string Tiny { get; set; }

            [JsonProperty("small")]
            public string Small { get; set; }

            [JsonProperty("medium")]
            public string Medium { get; set; }

            [JsonProperty("large")]
            public string Large { get; set; }

            [JsonProperty("original")]
            public string Original { get; set; }

            [JsonProperty("meta")]
            public Meta Meta { get; set; }
        }

        public class CoverImage
        {
            [JsonProperty("tiny")]
            public string Tiny { get; set; }

            [JsonProperty("small")]
            public string Small { get; set; }

            [JsonProperty("large")]
            public string Large { get; set; }

            [JsonProperty("original")]
            public string Original { get; set; }

            [JsonProperty("meta")]
            public Meta Meta { get; set; }
        }

        public class Attributes
        {
            [JsonProperty("slug")]
            public string Slug { get; set; }

            [JsonProperty("description")]
            public string Description { get; set; }

            [JsonProperty("coverImageTopOffset")]
            public int CoverImageTopOffset { get; set; }

            [JsonProperty("titles")]
            public Titles Titles { get; set; }

            [JsonProperty("canonicalTitle")]
            public string CanonicalTitle { get; set; }

            [JsonProperty("abbreviatedTitles")]
            public List<string> AbbreviatedTitles { get; set; }

            [JsonProperty("averageRating")]
            public string AverageRating { get; set; }

            [JsonProperty("startDate")]
            public string StartDate { get; set; }

            [JsonProperty("endDate")]
            public string EndDate { get; set; }

            [JsonProperty("nextRelease")]
            public object NextRelease { get; set; }

            [JsonProperty("ageRating")]
            public string AgeRating { get; set; }

            [JsonProperty("ageRatingGuide")]
            public string AgeRatingGuide { get; set; }

            [JsonProperty("subtype")]
            public string Subtype { get; set; }

            [JsonProperty("status")]
            public string Status { get; set; }

            [JsonProperty("tba")]
            public string Tba { get; set; }

            [JsonProperty("posterImage")]
            public PosterImage PosterImage { get; set; }

            [JsonProperty("coverImage")]
            public CoverImage CoverImage { get; set; }

            [JsonProperty("episodeCount")]
            public int EpisodeCount { get; set; }

            [JsonProperty("episodeLength")]
            public int? EpisodeLength { get; set; }

            [JsonProperty("totalLength")]
            public int TotalLength { get; set; }

            [JsonProperty("youtubeVideoId")]
            public string YoutubeVideoId { get; set; }

            [JsonProperty("showType")]
            public string ShowType { get; set; }

            [JsonProperty("nsfw")]
            public bool Nsfw { get; set; }
        }

        public class Anime
        {
            [JsonProperty("id")]
            public string Id { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("links")]
            public Links Links { get; set; }

            [JsonProperty("attributes")]
            public Attributes Attributes { get; set; }
        }

        public class AnimeListKitsu
        {
            [JsonProperty("data")]
            public List<Anime> Data { get; set; }

            [JsonProperty("meta")]
            public Meta Meta { get; set; }

            [JsonProperty("links")]
            public Links Links { get; set; }
        }


    }

