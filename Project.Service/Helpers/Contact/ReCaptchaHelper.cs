using RestSharp;

namespace Project.Helpers;

public class ReCaptchaHelper
{
    private class ReCatpchaResponse
    {
        public bool success { get; set; }
        public double score { get; set; }
    }

    public static bool ValidateRecaptcha(string token)
    {
        var client = new RestClient(new RestClientOptions("https://www.google.com/recaptcha/"));
        var request = new RestRequest("api/siteverify");
        request.AddParameter("secret", "6LfPznQmAAAAAHdpJza3UAJaufcqESkbKTqsfNIL");
        request.AddParameter("response", token);

        try
        {
            var grResponse = client.Post<ReCatpchaResponse>(request);

            double minScore = 0.6;
            if (!grResponse.success || grResponse.score < minScore)
            {
                return false;
            }
        }
        catch
        {
            return false;
        }

        return true;
    }
}