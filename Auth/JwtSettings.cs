namespace PhamMinhPhuc_2122110044.Auth
{
    public class JwtSettings
    {
        public string SecretKey { get; set; } = "THIS_IS_A_SUPER_SECRET_KEY_1234567890_32";
        public string Issuer { get; set; } = "PhamMinhPhuc_2122110044App";
        public string Audience { get; set; } = "PhamMinhPhuc_2122110044Users";
        public int ExpirationMinutes { get; set; } = 60;
    }
}
