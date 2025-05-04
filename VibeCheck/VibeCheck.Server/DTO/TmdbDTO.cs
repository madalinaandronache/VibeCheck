﻿namespace VibeCheck.Server.DTO;

public class TmdbDTO
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string? PosterUrl { get; set; }
    public string? MediaType { get; set; } // movie, tv etc.
}