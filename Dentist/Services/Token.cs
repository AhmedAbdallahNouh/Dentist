namespace Dentist.Services
{
    public class Token
    {
        private readonly ILocalStorageService _localStorage;

        public Token(ILocalStorageService localStorage)
        {
            this._localStorage = localStorage;
        }
        public async Task<string> GetToken() => await _localStorage.GetItemAsStringAsync("token");

    }
}
