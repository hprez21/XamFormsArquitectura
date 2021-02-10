using System;
using System.Collections.Generic;
using System.Text;

namespace XamFormsArquitectura.Models
{

    public class AnimeData
    {
        public string request_hash { get; set; }
        public bool request_cached { get; set; }
        public int request_cache_expiry { get; set; }
        public Result[] results { get; set; }
        public int last_page { get; set; }
    }

    public class Result
    {
        public int mal_id { get; set; }
        public string url { get; set; }
        public string image_url { get; set; }
        public string title { get; set; }
        public bool airing { get; set; }
        public string synopsis { get; set; }
        public string type { get; set; }
        public int episodes { get; set; }
        public float score { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public int members { get; set; }
        public string rated { get; set; }
    }

}
