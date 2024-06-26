﻿namespace Car_Delivary_API.Mapper
{
    public class JWTMaper
    {
        public string Key { get; set; } = string.Empty;
        public string Issuer { get; set; } = string.Empty;
        public string Audience { get; set; } = string.Empty;
        public double DurationInDays { get; set; }
        public double DurationInMinutes { get; set; }
    }
}
