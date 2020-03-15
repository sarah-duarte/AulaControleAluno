using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    class ClassAlunoADS : ClassAluno
    {
        private int periodo;
        private String turma;
        private String turno;
        private int sala;

        public int getPeriodo()
        {
            return this.periodo;
        }
        public void setPeriodo(int periodo)
        {
            this.periodo = periodo;
        }
    }
}
