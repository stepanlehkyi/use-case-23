using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace use_case_23.Classes {
  internal class Titles {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime ReleaseYear { get; set; }
        public string AgeSpecification { get; set; }
        public short Runtime { get; set; }
        public string Genres { get; set; }
        public string ProductionCountry { get; set; }
        public short Seasons { get; set; }
    }
}
