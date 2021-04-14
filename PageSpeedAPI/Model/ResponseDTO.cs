using Newtonsoft.Json;
using System;
using System.Collections.Generic;
namespace PageSpeedAPI.Model
{
    public class ResponseDTO
    {
        public LightHouseResult lighthouseResult { get; set; }
        public LoadingExperience loadingExperience { get; set; }
    }

    public class LightHouseResult
    {
        public Categories categories { get; set; }
        public Audits audits { get; set; }
    }

    public class LoadingExperience
    {
        public Metrics metrics { get; set; }
        public string overall_category { get; set; }
    }

    public class Categories
    {
        public Performance performance { get; set; }
    }
    public class Performance
    {
        public double score { get; set; }
    }
    public class Audits
    {
        [JsonProperty("first-contentful-paint")]
        public LabData FCP { get; set; }

        [JsonProperty("speed-index")]
        public LabData SI{ get; set; }

        [JsonProperty("largest-contentful-paint")]
        public LabData LCP { get; set; }

        [JsonProperty("Interactive")]
        public LabData TTI { get; set; }

        [JsonProperty("total-blocking-time")]
        public LabData TBT { get; set; }

        [JsonProperty("cumulative-layout-shift")]
        public LabData CLS { get; set; }
    }
    public class Metrics
    {
        [JsonProperty("CUMULATIVE_LAYOUT_SHIFT_SCORE")]
        public FieldData CLS { get; set; }

        [JsonProperty("FIRST_CONTENTFUL_PAINT_MS")]
        public FieldData FCP { get; set; }
        
        [JsonProperty("FIRST_INPUT_DELAY_MS")]
        public FieldData FID { get; set; }
        
        [JsonProperty("LARGEST_CONTENTFUL_PAINT_MS")]
        public FieldData LCP { get; set; }
    }
    public class LabData
    {
        public double score { get; set; }
        public double numericValue { get; set; }
    }
    public class FieldData
    {
        public int percentile { get; set; }
        public string category { get; set; }
    }
}
