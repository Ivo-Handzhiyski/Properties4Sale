namespace Properties4Sale.Web.Controllers
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Options;
    using Newtonsoft.Json;
    using Properties4Sale.Web.Models;

    public class ReCaptchaController : Controller
    {
        private readonly ReCaptchaSettings settings;

        public ReCaptchaController(IOptions<ReCaptchaSettings> settings)
        {
            this.settings = settings.Value;
        }

        public virtual async Task<GoogleResponse> ValidateResponse(string token)
        {
            GoogleReCapthaService data = new GoogleReCapthaService
            {
                ResponseToken = token,
                SecretKey = this.settings.ReCAPTCHA_Secret_Key,
            };

            HttpClient httpClient = new HttpClient();
            var response = await httpClient
                .GetStringAsync(
                "https://www.google.com/recaptcha/api/siteverify" + $"?secret={data.SecretKey}&response={data.ResponseToken}");

            var capturedResponse = JsonConvert.DeserializeObject<GoogleResponse>(response);

            return capturedResponse;
        }

    }
}