using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteString
{
    class ExtratorValorDeArgumentosURL
   {
        public string Url { get; }
        private readonly string _argumentos;
        public ExtratorValorDeArgumentosURL(string url)
        {

            if (string.IsNullOrEmpty(url))
            {
                throw new ArgumentException("O argumento da string não pode ser vazia. ", nameof(url));
            }

            int indiceInterrogacao = url.IndexOf("?");
            _argumentos = url.Substring(indiceInterrogacao + 1);
            Url = _argumentos;
        }
        public string GetValor(string nomeParametro)
        {
            nomeParametro = nomeParametro.ToUpper(); // VALOR
            string argumentoEmCaixaAlta = _argumentos.ToUpper(); // MOEDAORIGEM=REAL&MOEDADESTINO=DOLAR

            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length); // dolar
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
            {
                return resultado;
            }
            return resultado.Remove(indiceEComercial);

        }


    }
}
