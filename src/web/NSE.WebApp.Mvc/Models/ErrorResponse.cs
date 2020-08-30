﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NSE.WebApp.Mvc.Models
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }

        [JsonPropertyName("errors")]
        public List<string> Errors { get; set; }
    }
}