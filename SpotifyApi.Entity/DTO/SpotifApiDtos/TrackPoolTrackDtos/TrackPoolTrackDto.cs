﻿using SpotifyApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApi.Entity.DTO.SpotifApiDtos.TrackPoolTrackDtos
{
    public class TrackPoolTrackDto : IDto
    {
        public string Href { get; set; }
        public List<TrackPoolTrackListDto> Items { get; set; }
        public int Limit { get; set; }
        public string Next { get; set; }
        public int Offset { get; set; }
        public string Previous { get; set; }
        public int Total { get; set; }
    }
}
