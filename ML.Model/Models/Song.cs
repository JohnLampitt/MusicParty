using System.ComponentModel.DataAnnotations;

namespace ML.Model.Models
{
    public class Song
    {
        [Key]
        public int SongId { get; set; }
    }
}