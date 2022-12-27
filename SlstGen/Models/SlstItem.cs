﻿using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace NekoSpace.SlstGen.Models;

public class SlstItem
{
    [JsonPropertyName("idx")]
    public int Idx { get; set; }

    [JsonPropertyName("id")]
    public string Id { get; set; } = string.Empty;

    [JsonPropertyName("title_localized")]
    public SlstLocalizationInfo TitleLocalized { get; set; } = new();

    [JsonPropertyName("artist")]
    public string Artist { get; set; } = string.Empty;

    [JsonPropertyName("artist_localized")]
    public SlstLocalizationInfo? ArtistLocalized { get; set; } = null;

    [JsonPropertyName("bpm")]
    public string Bpm { get; set; } = string.Empty;

    [JsonPropertyName("bpm_base")]
    public double BpmBase { get; set; }

    [JsonPropertyName("set")]
    public string Set { get; set; } = "single";

    [JsonPropertyName("purchase")]
    public string Purchase { get; set; } = string.Empty;

    [JsonPropertyName("audioPreview")]
    public int AudioPreview { get; set; }

    [JsonPropertyName("audioPreviewEnd")]
    public int AudioPreviewEnd { get; set; }

    [JsonPropertyName("side")]
    public int Side { get; set; }

    [JsonPropertyName("bg")]
    public string Bg { get; set; } = string.Empty;

    [JsonPropertyName("bg_inverse")]
    public string? BgInverse { get; set; } = null;

    [JsonPropertyName("bg_daynight")]
    public SlstBgDayNightInfo? BgDayNight { get; set; } = null;

    [JsonPropertyName("date")]
    public long Date { get; set; }

    [JsonPropertyName("version")]
    public string Version { get; set; } = string.Empty;

    [JsonPropertyName("world_unlock")]
    public bool? WorldUnlock { get; set; } = null;

    [JsonPropertyName("remote_dl")]
    public bool? RemoteDl { get; set; } = null;

    [JsonPropertyName("byd_local_unlock")]
    public bool? BydLocalUnlock { get; set; } = null;

    [JsonPropertyName("songlist_hidden")]
    public bool? SonglistHidden { get; set; } = null;

    [JsonPropertyName("no_pp")]
    public bool? NoPp { get; set; } = null;

    [JsonPropertyName("source_localized")]
    public SlstLocalizationInfo? SourceLocalized { get; set; } = null;

    [JsonPropertyName("source_copyright")]
    public string? SourceCopyright { get; set; } = null;

    [JsonPropertyName("no_stream")]
    public bool? NoStream { get; set; } = null;

    [JsonPropertyName("jacket_localized")]
    public SlstLocalizationInfo? JacketLocalized { get; set; } = null;

    [JsonPropertyName("difficulties")]
    public List<SlstDifficultyInfo> Difficulties { get; set; } = Enumerable.Range(0, 3)
        .Select(i => new SlstDifficultyInfo { RatingClass = (ArcaeaRatingClass)i }).ToList();
}