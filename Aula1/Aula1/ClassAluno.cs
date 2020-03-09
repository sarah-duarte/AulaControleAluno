using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class ClassAluno
    {
        private String nome;
        private String email;
        private String matricula;
        private int telefone;
        private String curso;
        private String endereco;

        public void setNome(String nome)
        {
            this.nome = nome;
        }
        public String getNome()
        {
            return this.nome;
        }
        public void setEmail(String email)
        {
            this.email = email;
        }
        public String getEmail()
        {
            return this.email;
        }
        public void setMatricula(String matricula)
        {
            this.matricula = matricula;
        }
        public String getMatricula()
        {
            return this.matricula;
        }
        public void setTelefone(int telefone)
        {
            this.telefone = telefone;
        }
        public int getTelefone()
        {
            return this.telefone;
        }
        public void setCurso(String curso)
        {
            this.curso = curso;
        }
        public String getCurso()
        {
            return this.curso;
        }
        public void setEndereco(String endereco)
        {
            this.endereco = endereco;
        }
        public String getEndereco()
        {
            return this.endereco;
        }


    }
}
