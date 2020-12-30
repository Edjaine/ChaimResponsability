using System.Collections.Generic;

namespace chainResponsability
{
    public class Client
    {
        public List<string> Valida(AbstractHandler handler) {
            var mensagens = new List<string>();
            var comidas = new List<string> {"bife", "peixe", "nut", "outros" };

            comidas.ForEach(c => {
                mensagens.Add((string)handler.Handler(c));
            });
            return mensagens;
        }
    }
}