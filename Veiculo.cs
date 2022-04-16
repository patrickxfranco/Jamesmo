using System;
using Jamesmo.MySQL;

namespace Jamesmo.VeiculoNS
{
    class Veiculo
    {
        string aMarca, aModelo, aAno;
        BancoDeDados banco;
        public Veiculo(string pMarca, string pModelo, string pAno)
        { 
            aMarca = pMarca;
            aModelo = pModelo;
            aAno = pAno;
        }

        public Veiculo(string pModelo)
        {
            aModelo = pModelo;
        }

        public void Cadastrar()
        {
            banco = new BancoDeDados();
            banco.Inserir(aMarca, aModelo, aAno);
        }

        public void Excluir()
        {
            banco = new BancoDeDados();
            banco.Deletar(aModelo);
        }

        public void Visualizar()
        {

        }
    }
}
