﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sitecore.SharedSource.CognitiveServices.Models.Bing
{
    public class WebSearchNewsCluster
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public List<WebSearchNewsProvider> Provider { get; set; }
        public DateTime DatePublished { get; set; }
        public string Category { get; set; }
    }
}