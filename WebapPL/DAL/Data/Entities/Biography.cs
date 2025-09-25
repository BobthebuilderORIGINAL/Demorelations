using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Biography:BaseEnity
    {
        public string BiographyData { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }

        public string PlaceOfBirth { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        
        public int AuthorId {get; set; }
        public virtual Author Author { get; set; } = null!;
    }
}
