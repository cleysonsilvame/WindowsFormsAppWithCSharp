using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaLogin
{
    public class Usuario
    {
        private int id;
        private string login;
        private string senha;

        public Usuario(int id, string login, string senha)
        {
            this.id = id;
            this.login = login;
            this.senha = senha;
        }

        public Usuario(string login, string senha)
        {
            this.login = login;
            this.senha = senha;
        }

        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}