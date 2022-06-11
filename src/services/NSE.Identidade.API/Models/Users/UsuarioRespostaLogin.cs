using System.ComponentModel.DataAnnotations;

namespace NSE.Identidade.API.Models
{
    public class UsuarioRespostaLogin
    {
        public string AccessToken { get; set; }
        public double ExpiresOn { get; set; }
        public UsuarioToken UsuarioToken { get; set; }
    }
}
