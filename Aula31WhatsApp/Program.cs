using System;
using System.Collections.Generic;

namespace Aula31WhatsApp
{
    class Program
    {
        static void Main(string[] args)
        {
          
           Mensagem mens = new Mensagem();
           Agenda agenda = new Agenda();
           Contato c1 = new Contato();
     
           c1.Nome = "Cristiano";
           c1.Telefone = "98652310";

           agenda.Cadastrar(c1);

           agenda.Excluir("Cristiano");


           System.Console.WriteLine("Seus contatos:");

           List<Contato> lista = agenda.Listar();

           foreach(Contato item in lista){
               System.Console.WriteLine($"Número: {item.Telefone} Nome: {item.Nome}");
           }
          
           mens.Enviar(c1);

           
        }
    }
}
