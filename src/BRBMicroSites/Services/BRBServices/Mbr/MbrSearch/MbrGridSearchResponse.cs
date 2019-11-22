using System;
using System.Collections.Generic;
using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Mbr.MbrSearch
{
    public class MbrGridSearchResponse
    {
        public int total { get; set; }
        public int page { get; set; }
        public int records { get; set; }
        public List<MbrRows> rows { get; set; }
    }

    public class MbrRows
    {
        public int id { get; set; }
        public List<string> cell { get; set; }

        public MbrRows() => cell = new List<string>();
    }
}