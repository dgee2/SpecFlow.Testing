using System;
using System.Configuration;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TechTalk.SpecFlow;

namespace SpecFlow.ApiTesting.StepDefinitions
{
    [Binding]
    public sealed class ApiStepDefs
    {
        private HttpResponseMessage _response;

        private string _content;
        private async Task<string> GetResponseContent()
        {
            return _content ?? (_content = await _response.Content.ReadAsStringAsync());
        }

        private async Task<JToken> GetResponseToken(string key)
        {
            var content = await GetResponseContent();
            var contentJObject = JToken.Parse(content);
            return contentJObject.SelectToken(key);
        }

        [StepArgumentTransformation]
        public Uri UriTransform(string uri) => new Uri(uri);

        [When(@"I make a (GET|POST|PUT|DELETE|PATCH) request to the (.*) url")]
        public async Task IMakeA_method_RequestToThe_url_url(string method, string url)
        {
            var httpMethod = new HttpMethod(method);
            var uri = new Uri(url);

            using (var client = new HttpClient())
            {
                _response = await client.SendAsync(new HttpRequestMessage(httpMethod, uri));
            }
        }
        [When(@"I make a (GET|POST|PUT|DELETE|PATCH) request to the (.*) url from config")]
        public async Task WhenIMakeARequestToTheApiUrlUrlFromConfig(string method, string urlConfigItem)
        {
            var url = ConfigurationManager.AppSettings[urlConfigItem];
            await IMakeA_method_RequestToThe_url_url(method, url);
        }

        [Then(@"The request response is valid json")]
        [Then(@"The request response is valid Json")]
        public async Task ThenTheRequestResponseIsValidJson()
        {
            var content = await GetResponseContent();
            content = content.Trim();
            if ((content.StartsWith("{") && content.EndsWith("}")) || //For object
                (content.StartsWith("[") && content.EndsWith("]"))) //For array
            {
                try
                {
                    JToken.Parse(content);
                }
                catch (JsonReaderException jex)
                {
                    throw new Exception("GetResponseContent could not be parsed by Newtonsoft. It is likely that it is not correct Json.",jex);
                }
                catch (Exception ex) //some other exception
                {
                    throw new Exception("GetResponseContent could not be parsed by Newtonsoft due to an unknown error. It is likely that it is not correct Json.", ex);
                }
            }
            else
            {
                throw  new Exception("GetResponseContent does not start and end with either { and } or [ and ] and so is not valid Json.");
            }
        }

        [Then(@"the key (.*) in the response exists")]
        public async Task ThenTheKeyExistsInTheResponse(string key)
        {
            var contentJObject = await GetResponseToken(key);
            if (contentJObject == null)
            {
                throw new Exception($"The key '{key}' does not exist in the response.");
            }
        }

        [Then(@"the key (.*) in the response contains (1) element")]
        [Then(@"the key (.*) in the response contains (.*) elements")]
        public async Task ThenTheKeyInTheResponseContainsElements(string key, int count)
        {
            var array = await GetResponseToken(key);
            if (! (array is JArray))
            {
                throw new Exception($"The key '{key}' in the response is not an array.");
            }

            if (((JArray)array).Count != count)
            {
                throw new Exception($"The key '{key}' in the response does not have {count} elements.");
            }
        }

        [Then(@"the key (.*) in the response equals the expected (.*)")]
        public async Task ThenTheKeyInTheResponseEqualsTheDatetime(string key, DateTime datetime)
        {
            var token = await GetResponseToken(key);
            var tokenValue = token.ToString();
            if (!DateTime.TryParse(tokenValue, out var actualDatetime))
            {
                throw new Exception($"The key '{key}' in the response does not contain a valid expected value");
            }

            if (!actualDatetime.Equals(datetime))
            {
                throw new Exception($"The key '{key}' in the reponse does not have the expected value '{datetime}'");
            }
        }

        [Then(@"the key (.*) in the response equals the integer (.*)")]
        public async Task ThenTheKeyInTheResponseEqualsTheInteger(string key, int expected)
        {
            var token = await GetResponseToken(key);
            var tokenValue = token.ToString();
            if (!int.TryParse(tokenValue, out var actual))
            {
                throw new Exception($"The key '{key}' in the response does not contain a valid expected value");
            }

            if (!actual.Equals(expected))
            {
                throw new Exception($"The key '{key}' in the reponse does not have the expected value '{expected}'");
            }
        }

        [Then(@"the key (.*) in the response is greater than the integer (.*)")]
        public async Task ThenTheKeyInTheResponseIsGreaterThanTheInteger(string key, int expected)
        {
            var token = await GetResponseToken(key);
            var tokenValue = token.ToString();
            if (!int.TryParse(tokenValue, out var actual))
            {
                throw new Exception($"The key '{key}' in the response does not contain a valid expected value");
            }

            if (actual <= expected)
            {
                throw new Exception($"The key '{key}' in the reponse is not greater than the expected value '{expected}'");
            }
        }

        [Then(@"the key (.*) in the response is greater than or equal to the integer (.*)")]
        public async Task ThenTheKeyInTheResponseIsGreaterThanOrEqualToTheInteger(string key, int expected)
        {
            var token = await GetResponseToken(key);
            var tokenValue = token.ToString();
            if (!int.TryParse(tokenValue, out var actual))
            {
                throw new Exception($"The key '{key}' in the response does not contain a valid expected value");
            }

            if (actual < expected)
            {
                throw new Exception($"The key '{key}' in the reponse is not greater than or equal to the expected value '{expected}'");
            }
        }

        [Then(@"the key (.*) in the response is less than the integer (.*)")]
        public async Task ThenTheKeyInTheResponseIsLessThanTheInteger(string key, int expected)
        {
            var token = await GetResponseToken(key);
            var tokenValue = token.ToString();
            if (!int.TryParse(tokenValue, out var actual))
            {
                throw new Exception($"The key '{key}' in the response does not contain a valid expected value");
            }

            if (actual >= expected)
            {
                throw new Exception($"The key '{key}' in the reponse is not greater than the expected value '{expected}'");
            }
        }

        [Then(@"the key (.*) in the response is less than or equal to the integer (.*)")]
        public async Task ThenTheKeyInTheResponseIsLessThanOrEqualToTheInteger(string key, int expected)
        {
            var token = await GetResponseToken(key);
            var tokenValue = token.ToString();
            if (!int.TryParse(tokenValue, out var actual))
            {
                throw new Exception($"The key '{key}' in the response does not contain a valid expected value");
            }

            if (actual > expected)
            {
                throw new Exception($"The key '{key}' in the reponse is not greater than or equal to the expected value '{expected}'");
            }
        }

        [Then(@"the key (.*) in the response equals the string (.*)")]
        public async Task ThenTheKeyInTheResponseEqualsTheString(string key, string expected)
        {
            var token = await GetResponseToken(key);
            var actual = token.ToString();

            if (!actual.Equals(expected))
            {
                throw new Exception($"The key '{key}' in the reponse does not have the expected value '{expected}'");
            }
        }
    }
}
