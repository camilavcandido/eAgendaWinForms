using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace eAgenda.Dominio
{
    public class Contato
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }

        public Contato()
        {
        }
        public Contato(int numero, string nome, string email, string telefone,
            string empresa, string cargo) : this()
        {
            Numero = numero;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Empresa = empresa;
            Cargo = cargo;
        }

        public string Validar()
        {
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(Nome))
                sb.AppendLine("O nome do contato é obrigatório!");
            if (string.IsNullOrEmpty(Email))
                sb.AppendLine("O Email do contato é obrigatório!");
            if (string.IsNullOrEmpty(Telefone))
                sb.AppendLine("O Telefone do contato é obrigatório!");

            if (EmailEstaValido(ValidarEmail) == false)
                sb.AppendLine("Insira um endereço de email válido! (Ex: contato@gmail.com)");

            if (TelefoneEstaValido() == false)
                sb.AppendLine("O telefone precisa seguir um dos seguintes formatos: 99999-0000 ou 99999 0000 ou 999990000");

            if (sb.Length == 0)
                sb.Append("REGISTRO_VALIDO");

            return sb.ToString();
        }

        private bool EmailEstaValido(Func<bool> validacaoSelecionada)
        {
            bool emailEstaValido = validacaoSelecionada();

            return emailEstaValido;
        }

        private bool ValidarEmail()
        {
            bool emailEstaValido = false;
            try
            {
                emailEstaValido = System.Net.Mail.MailAddress
                   .TryCreate(Email, out _);

            }
            catch
            {

            }

            return emailEstaValido;

        }

        private bool TelefoneEstaValido()
        {
            bool telefoneEstaValido = false;

            string telefoneProcessado = Telefone.Replace("-", string.Empty)
                                                .Replace(" ", string.Empty);

            if (telefoneProcessado.Length < 9)
                return telefoneEstaValido;

            telefoneEstaValido = Regex.IsMatch(telefoneProcessado, @"^[0-9]*$");

            return telefoneEstaValido;
        }

        public override string ToString()
        {
            return $"Numero: {Numero}, Nome: {Nome}, Email: {Email}, Telefone: {Telefone}, " +
                $"Empresa: {Empresa}, Cargo: {Cargo}";
        }
    }
}
