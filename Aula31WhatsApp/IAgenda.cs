using System.Collections.Generic;

namespace Aula31WhatsApp
{
    public interface IAgenda
    {
         void Cadastrar(Contato cont);
         void Excluir(string _termo);
         List<Contato> Listar();
    }
}