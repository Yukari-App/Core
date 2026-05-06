namespace Yukari.Core.Models;

public record Chapter(
    string Id,
    string? Title,
    string? Number,
    string? Volume,
    string? Language,
    string[] Groups,
    DateOnly LastUpdate,
    int? Pages
);
