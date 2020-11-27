using Properties4Sale.Services.Data;

namespace Properties4Sale.Web.Controllers
{
    public class GoogleReCapthaService : IGoogleReCapthaService
    {
        public string ResponseToken { get; set; }

        public string SecretKey { get; set; }
    }
}