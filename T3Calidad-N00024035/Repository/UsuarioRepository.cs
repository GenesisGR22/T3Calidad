using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using T3Calidad_N00024035.Models;

namespace T3Calidad_N00024035.Repository
{
    public interface IUsuarioRepository
    {
        Usuario GetUsuarios(string username, string password);
        string CreateHash(string password);
        void saveUser(Usuario usuario);
    }
    public class UsuarioRepository: IUsuarioRepository
    {
        private readonly IN00024035Context _context;
        private readonly IConfiguration configuration;
        public IHostEnvironment hostEnv;
        public UsuarioRepository(N00024035Context _context, IConfiguration configuration, IHostEnvironment hostEnv)
        {
            this._context = _context;
            this.configuration = configuration;
            this.hostEnv = hostEnv;
        }

        public Usuario GetUsuarios(string username, string password)
        {
            return _context.Usuarios.Where(o => o.Nombre == username && o.Password == CreateHash(password))
                .FirstOrDefault();

        }

        public void saveUser(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        string CreateHash(string input)
        {
            var sha = SHA256.Create();
            input += configuration.GetValue<string>("Token");
            var hash = sha.ComputeHash(Encoding.Default.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        string IUsuarioRepository.CreateHash(string password)
        {
            var sha = SHA256.Create();
            password += configuration.GetValue<string>("Token");
            var hash = sha.ComputeHash(Encoding.Default.GetBytes(password));

            return Convert.ToBase64String(hash);
        }
    }
}
