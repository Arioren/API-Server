using System.ComponentModel.DataAnnotations;

namespace API_Server.Models
{
    public class Target
    {
        [Key]public int Id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public string photo_url { get; set; }
        public int x_location { get; set; }
        public int y_location { get; set; }
        public string status { get; set; }

    }
}
