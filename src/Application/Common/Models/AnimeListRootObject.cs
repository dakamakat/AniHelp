using System;
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

    public class RatingFrequencies
    {
        [JsonProperty("2")]
        public string _2 { get; set; }

        [JsonProperty("3")]
        public string _3 { get; set; }

        [JsonProperty("4")]
        public string _4 { get; set; }

        [JsonProperty("5")]
        public string _5 { get; set; }

        [JsonProperty("6")]
        public string _6 { get; set; }

        [JsonProperty("7")]
        public string _7 { get; set; }

        [JsonProperty("8")]
        public string _8 { get; set; }

        [JsonProperty("9")]
        public string _9 { get; set; }

        [JsonProperty("10")]
        public string _10 { get; set; }

        [JsonProperty("11")]
        public string _11 { get; set; }

        [JsonProperty("12")]
        public string _12 { get; set; }

        [JsonProperty("13")]
        public string _13 { get; set; }

        [JsonProperty("14")]
        public string _14 { get; set; }
        [JsonProperty("15")]
        public string _15 { get; set; }

        [JsonProperty("16")]
        public string _16 { get; set; }

        [JsonProperty("17")]
        public string _17 { get; set; }

        [JsonProperty("18")]
        public string _18 { get; set; }

        [JsonProperty("19")]
        public string _19 { get; set; }

        [JsonProperty("20")]
        public string _20 { get; set; }
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
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("synopsis")]
        public string Synopsis { get; set; }

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

        [JsonProperty("ratingFrequencies")]
        public RatingFrequencies RatingFrequencies { get; set; }

        [JsonProperty("userCount")]
        public int UserCount { get; set; }

        [JsonProperty("favoritesCount")]
        public int FavoritesCount { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("nextRelease")]
        public object NextRelease { get; set; }

        [JsonProperty("popularityRank")]
        public int PopularityRank { get; set; }

        [JsonProperty("ratingRank")]
        public int RatingRank { get; set; }

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

    public class Genres
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Categories
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Castings
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Installments
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Mappings
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Reviews
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class MediaRelationships
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Characters
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Staff
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Productions
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Quotes
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Episodes
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class StreamingLinks
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class AnimeProductions
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }
    public class AnimeCharacters
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class AnimeStaff
    {
        [JsonProperty("links")]
        public Links Links { get; set; }
    }

    public class Relationships
    {
        [JsonProperty("genres")]
        public Genres Genres { get; set; }

        [JsonProperty("categories")]
        public Categories Categories { get; set; }

        [JsonProperty("castings")]
        public Castings Castings { get; set; }

        [JsonProperty("installments")]
        public Installments Installments { get; set; }

        [JsonProperty("mappings")]
        public Mappings Mappings { get; set; }

        [JsonProperty("reviews")]
        public Reviews Reviews { get; set; }

        [JsonProperty("mediaRelationships")]
        public MediaRelationships MediaRelationships { get; set; }

        [JsonProperty("characters")]
        public Characters Characters { get; set; }

        [JsonProperty("staff")]
        public Staff Staff { get; set; }

        [JsonProperty("productions")]
        public Productions Productions { get; set; }

        [JsonProperty("quotes")]
        public Quotes Quotes { get; set; }

        [JsonProperty("episodes")]
        public Episodes Episodes { get; set; }

        [JsonProperty("streamingLinks")]
        public StreamingLinks StreamingLinks { get; set; }

        [JsonProperty("animeProductions")]
        public AnimeProductions AnimeProductions { get; set; }

        [JsonProperty("animeCharacters")]
        public AnimeCharacters AnimeCharacters { get; set; }

        [JsonProperty("animeStaff")]
        public AnimeStaff AnimeStaff { get; set; }
    }

    public class SingleAnimeData
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("relationships")]
        public Relationships Relationships { get; set; }
    }


    public class SingleAnime
    {
        [JsonProperty("data")]
        public SingleAnimeData SingleAnimeData { get; set; }
    }
    public class AnimeList
    {      
        [JsonProperty("data")]
        public List<SingleAnimeData> AnimeListData { get; set; }

        [JsonProperty("meta")]
        public Meta Meta { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }
    }


}

