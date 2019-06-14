using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTStTeste
{
    class Pessoa
    {
        public Int32 Id             { private set; get; } 
        public String Nome          { set; get; }
        public String Cpf           { set; get; }
        public Int16 Sexo          { set; get; }
        public DateTime Nascimento  { set; get; }
        public String Telefone      { set; get; }
        public String Email         { set; get; }
        public String Endereco      { set; get; }
        public String Bairro        { set; get; }
        public String Cidade        { set; get; }
        public String Estado        { set; get; }
        public String Cep           { set; get; }
        public String Complemento   { set; get; }
        public String Turno         { set; get; }
        public String Cargo         { set; get; }
        public String Escolaridade  { set; get; }
        public String Exames        { set; get; }


    }
}
