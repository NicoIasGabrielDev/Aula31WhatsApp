using System;

namespace Aula31WhatsApp
{
    public class Mensagem : Contato
    {
        public string Texto { get; set; }
        public string Destinatario { get; set; }

        

        public void Enviar(Contato cont){
            System.Console.WriteLine("Mensagem será destinada a quem?");
            Destinatario = Console.ReadLine();
            System.Console.WriteLine("Digite sua mensagem:");
            Texto = Console.ReadLine();
            System.Console.WriteLine($"\nMensagem enviada com sucesso para: {Destinatario}\nMensagem enviada: {Texto}");
           
         }

        


    }
}