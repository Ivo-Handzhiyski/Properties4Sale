namespace Properties4Sale.Services.Data
{
    public interface IGoogleReCapthaService
    {
        public string ResponseToken { get; set; }

        public string SecretKey { get; set; }
    }
}
