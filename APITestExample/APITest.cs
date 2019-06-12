using System.Net; //This is used to provide HTTP objects
using NUnit.Framework; //To drive our tests
using RestSharp; //This is an open source API testing framework
using Newtonsoft.Json; //This is used to convert C# objects to JSON

namespace Tests
{
    public class APITest
    {

        [Test]
        public void GetAPICall()
        {
            //Think of a client like a browser, and the URL we are interested in
            var client = new RestClient("https://automationintesting.online");
            //Here we build up our request with the required information.
            //In this instance we are just providded the route and stating we expect JSON back
            var request = new RestRequest("room/", DataFormat.Json);
            //Here we use RESTSharps request object and instruct the client to send our request using the GET method
            var response = client.Get(request);

            //Asserting that the status is "OK"
            Assert.That(response.StatusCode.ToString(), Is.EqualTo("OK"));
            //Asserting that the status code is 200
            Assert.That((int)response.StatusCode, Is.EqualTo(200));
        }

        [Test]
        public void PostAPICall()
        {
            //Think of a client like a browser, and the URL we are interested in
            var client = new RestClient("https://automationintesting.online");
            //Here we build up our request with the required information.
            //In this instance we are just providded the route and stating we expect JSON back
            var request = new RestRequest("auth/login",  DataFormat.Json);
            
            //I've created a basic object and set the values with need.
            //These directly map to the JSON we have to send - https://automationintesting.online/auth/swagger-ui.html
            AuthPayload payload = new AuthPayload();
            payload.username = "admin";
            payload.password = "password";

            //Provide the object we've created to RESTSharp
            request.AddJsonBody(payload);
            //Instruct RESTSharp to send our request using the POST method
            var response = client.Post(request);

            //
            //Asserting that the status is "OK"
            Assert.That(response.StatusCode.ToString(), Is.EqualTo("OK"));
            //Asserting that the status code is 200
            Assert.That((int)response.StatusCode, Is.EqualTo(200));

            //This request return JSON, so we have to parse/deserialise it to an object we can use in C#
            //I've created the AuthResponse below and told JSONConert to use that object
            //It will try to match properties like for like.
            AuthResponse dave = JsonConvert.DeserializeObject<AuthResponse>(response.Content);

            //I'm expecting a token, and I know it's length should be 16 characters. 
            Assert.That(dave.token.Length, Is.EqualTo(16));
        }
    }

    public class AuthPayload
    {
        public string username { get; set; }
        public string password { get; set; }
    }

    public class AuthResponse
    {
        public string token { get; set; }
    }
}