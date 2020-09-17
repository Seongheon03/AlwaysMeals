﻿using Newtonsoft.Json;

namespace Core.Meal.Model.Data
{
    class Result
    {
        [JsonProperty("CODE")]
        public string Code { get; set; }

        [JsonProperty("MESSAGE")]
        public string Message { get; set; }
    }
}