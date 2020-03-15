using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aula1
{
    public partial class frmTelaCadastro : Form
    {
        public frmTelaCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ClassAluno aluno = new ClassAluno();
            aluno.setNome(txtNome.Text);
            aluno.setEmail(txtEmail.Text);
            aluno.setMatricula(txtMatricula.Text);
            aluno.setEndereco(txtEndereco.Text);
            aluno.setCurso(txtCurso.Text);

            try
            {
                aluno.setTelefone(int.Parse(txtTelefone.Text));
                String varNome = aluno.getNome();
                String varEmail = aluno.getEmail();
                String varMatricula = aluno.getMatricula();
                String varEndereco = aluno.getEndereco();
                String varCurso = aluno.getCurso();
                int varTelefone = aluno.getTelefone();

                String mensagem = "Nome do Aluno: " + varNome.ToUpper() + "\n\n" 
                    + "Email: " + varEmail.ToLower() + "\n\n"
                    + "Telefone: " + Convert.ToString(varTelefone) + "\n\n"
                    + "Matricula: " + varMatricula.ToUpper() + "\n\n"
                    + "Endereço: " + varEndereco.ToUpper() + "\n\n"
                    + "Curso: " + varCurso.ToUpper();
                MessageBox.Show(mensagem);
            }
            catch (IOException erro)
            {
                MessageBox.Show(erro.Message,"Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtMatricula.Clear();
            txtEndereco.Clear();
            txtCurso.Clear();
            txtNome.Focus();
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            ClassAluno novoAluno = new ClassAluno();
            novoAluno.matricular();
            string str = novoAluno.status;
            MessageBox.Show(str,"Metodo matricular",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void calouroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalouro telaCalouro = new frmCalouro();
            telaCalouro.ShowDialog();
            
        }
    }
}
