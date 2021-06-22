using System.Net.Http;

namespace BSA_Task1.Services
{
    public class HttpService
    {
        private HttpClient client = new HttpClient();

        public HttpResponseMessage GetProjects() =>
            client.GetAsync("https://bsa21.azurewebsites.net/api/Projects")
            .Result;

        public HttpResponseMessage GetTasks() =>
            client.GetAsync("https://bsa21.azurewebsites.net/api/Tasks")
            .Result;

        public HttpResponseMessage GetTeams() =>
            client.GetAsync("https://bsa21.azurewebsites.net/api/Teams")
            .Result;

        public HttpResponseMessage GetUsers() =>
            client.GetAsync("https://bsa21.azurewebsites.net/api/Users")
            .Result;
    }
}
