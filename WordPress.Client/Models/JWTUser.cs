using Newtonsoft.Json;

namespace WordPress.Client.Models
{
    class JWTUser
    {
        [JsonProperty("jwt_token")]
        public string Token { get; set; }

        [JsonProperty("user_display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("user_email")]
        public string Email { get; set; }

        [JsonProperty("user_nicename")]
        public string NiceName { get; set; }
    }
}
