using System.ComponentModel.DataAnnotations;

namespace GTSharp.Domain.Entities
{
    public class Overview
    {
        [Key]
        public int IdOverview { get; private set; }

        public string Description { get; private set; }
        
        public Movie Movie { get; set; }
    }
}