using System.ComponentModel.DataAnnotations;

namespace InstaData.InstaModels
{
    public class Client
    {
        [Key]
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string RedirectUri { get; set; }
    }
}
