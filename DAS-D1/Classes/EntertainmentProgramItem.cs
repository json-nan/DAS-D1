using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAS_D1.Classes
{
    internal class EntertainmentProgramItem
    {
        public string Name { get; set; }
        public string SpanishTitle { get; set; }
        public string[] CreatedBy { get; set; }
        public string[] Protagonists { get; set; }
        public string[] OriginCountries { get; set; }
        public int Seasons { get; set; }
        public int Episodes { get; set; }
        public string Synopsis { get; set; }

        public EntertainmentProgramItem(string name, string spanishTitle, string[] createdBy, string[] protagonists, string[] originCountries, int seasons, int episodes, string synopsis)
        {
            Name = name;
            SpanishTitle = spanishTitle;
            CreatedBy = createdBy;
            Protagonists = protagonists;
            OriginCountries = originCountries;
            Seasons = seasons;
            Episodes = episodes;
            Synopsis = synopsis;
        }
    }
}
