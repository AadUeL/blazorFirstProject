using dragon1.ApiRequests.Models;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;

namespace dragon1.ApiRequests
{
    public class ApiRequest
    {
        private readonly HttpClient _httpClient;

        public ApiRequest(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<UserData> GetAllUsers()
        {
            var url = "/GetAllUsers";

            var response = await _httpClient.GetAsync(url);

            var responseContent = await response.Content.ReadAsStringAsync();

            var usersData = JsonSerializer.Deserialize<UserData>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return usersData ?? new UserData();
        }


        public async Task<StatusData> AddNewUser(ReqDataUser user)
        {
            var url = "/CreateNewUserAndLogin";

            var response = await _httpClient.PostAsJsonAsync(url, user);

            var responseContent = await response.Content.ReadAsStringAsync();

            var userAddData = JsonSerializer.Deserialize<StatusData>(responseContent);

            return userAddData ?? new StatusData();

        }

        public async Task<AuthUserData> GetUserFromApi(ReqAuthUser reqUser)
        {
            var url = "/AuthUser";

            var response = await _httpClient.PostAsJsonAsync(url, reqUser);

            var responseContent = await response.Content.ReadAsStringAsync();

            var authUserData = JsonSerializer.Deserialize<AuthUserData>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return authUserData ?? new AuthUserData();
        }

        public async Task<StatusData> DeleteUser(int idUser)
        {
            var url = $"/DeleteUser/{idUser}";

            var response = await _httpClient.DeleteAsync(url);

            var responseContent = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<StatusData>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return result ?? new StatusData();


        }

        public async Task<StatusData> UpdateUser(int id, ReqUpdateUser reqUser)
        {
            var url = $"/UpdateUser/{id}";

            var response = await _httpClient.PutAsJsonAsync(url, reqUser);

            var responseContent = await response.Content.ReadAsStringAsync();

            var result = JsonSerializer.Deserialize<StatusData>(responseContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return result ?? new StatusData();
        }

    }
}
