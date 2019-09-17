using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace TesteString
{
    class Program
    {
        static void Main(string[] args)
        {
            string padraoE = "Sala [A-G][-]?[0123456789]{2}";
            string textoBase = "Sala a004";
            Match resultado2 = Regex.Match(textoBase,padraoE);
            Console.WriteLine(resultado2);
            Console.WriteLine(Regex.IsMatch("Sala a004", padraoE));
            Console.WriteLine(Regex.IsMatch("Sala C004", padraoE));
            Console.WriteLine(Regex.IsMatch("Minha sala é a sala G34", padraoE));
            Console.WriteLine(Regex.IsMatch("Minha sala é a Sala G-34", padraoE));
            Console.ReadLine();


            // Olá, meu nome é Guilherme e você pode entrar em contato comigo
            // através do número 8457-4456!
            // Meu nome é Guilherme, me ligue em 4784-4546
            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padrao = "[0-9]{4}[-][0-9]{4}";
            // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            //string padrao = "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste = "ajgdjgjagsygaugsa 98751-5456 aygsygsygua auyakjskjs";

            Match resultado = Regex.Match(textoDeTeste,padrao);

            Console.WriteLine(Regex.IsMatch(textoDeTeste,padrao));
            Console.WriteLine(resultado.Value);
            Console.ReadLine();



            //Testando StarsWith
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio"));
            Console.WriteLine(urlTeste.Contains("bytebank"));
            Console.WriteLine(indiceByteBank + 1);
            Console.Read();


            //Testando os metodos ToUpper e ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";

            Console.WriteLine(mensagemOrigem.ToLower());

            termoBusca = termoBusca.Replace('r', 'R');
            Console.WriteLine(termoBusca);

            termoBusca = termoBusca.Replace('a', 'A');
            Console.WriteLine(termoBusca);

            Console.WriteLine(mensagemOrigem.IndexOf(termoBusca));
            Console.ReadLine();



            //Testando o metodo
            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValorDeArgumentosURL extratorDeValores = new ExtratorValorDeArgumentosURL(urlParametros);

            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valorMoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valorMoedaOrigem);

            Console.WriteLine(extratorDeValores.GetValor("valor"));

            Console.ReadLine();




            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";
            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da String " + nomeArgumento.Length);

            Console.WriteLine(palavra.Substring(indice));
            Console.WriteLine(palavra.Substring( indice + nomeArgumento.Length +1));


            Console.WriteLine();
            //Testando o exercicio alura
            String texto = "Gustavo_Silva";

            if (string.IsNullOrEmpty(texto))
            {
                Console.WriteLine("String vazia");
            }

            Int32 indici = texto.IndexOf("Gustavo");
            String texto2 = texto.Substring(indici + 1);

            Console.WriteLine("Tamanho: " + texto.Length);
            Console.WriteLine("Indice: " + indici);
            Console.WriteLine(texto2);


            Console.WriteLine();
            // Testando o IsNullOrEmpty
            string textVazio = "";
            string textoNulo = null;
            string textoQualquer = "asdalhsdgashd";

            Console.WriteLine(String.IsNullOrEmpty(textVazio));
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));
            Console.WriteLine(String.IsNullOrEmpty(textoQualquer));

            Console.WriteLine();
            //Testando o metodo remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf("&" );
            Console.WriteLine(testeRemocao.Remove(indiceEComercial));

            /*
            ExtratorValorDeArgumentosURL  extrator = new ExtratorValorDeArgumentosURL("");
            string url = "paginas?argumentos";
            int indiceInterrogacao = url.IndexOf("?");
            string argumentos;

            Console.WriteLine(indiceInterrogacao);
            Console.WriteLine(url);
            argumentos = url.Substring(indiceInterrogacao + 1);
            Console.WriteLine(argumentos);
            */
        }
    }
}
