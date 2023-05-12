using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDasPalavras
{
    internal class JogoPalavras
    {
        private int numeroDaPosicao = 0;
        private int numero = 1;
        internal void InserirPalpite(string palpite, List<Label> espacosLetras)
        {
            espacosLetras[numeroDaPosicao].Text = palpite.ToUpper();
            numeroDaPosicao++;
        }

        public void ResetarVariaveisJogoPalavras()
        {
            numeroDaPosicao = 0;
            numero = 1;
        }

        public List<Label> OrganizarListEspacosLetras(List<Label> espacosLetrasDesorganizado, List<Label> espacosLetras)
        {
            for (int i = 0; i < 25; i++)
            {
                string[] nomeLabelSeparado = new string[2];
                nomeLabelSeparado[0] = "label";
                nomeLabelSeparado[1] = Convert.ToString(numero);
                string nomeLabel = String.Concat(nomeLabelSeparado);
                Label label = espacosLetrasDesorganizado.Find(label => label.Name == nomeLabel);
                espacosLetras.Add(label);
                numero++;
            }
            return espacosLetras;
        }

        public string ObterPalavraSecreta()
        {
            string[] palavras = new string[]
{
    "acido", "adiar", "impar", "algar", "amado", "amigo", "anexo", "anuir", "aonde", "apelo",
    "aquem", "argil", "arroz", "assar", "atras", "avido", "azeri", "babar", "bagre", "banho",
    "barco", "bicho", "bolor", "brasa", "brava", "brisa", "bruto", "bulir", "caixa", "cansa",
    "chato", "chave", "chefe", "choro", "chulo", "claro", "cobre", "corte", "curar", "deixo",
    "dizer", "dogma", "dores", "duque", "enfim", "estou", "exame", "falar", "fardo", "farto",
    "fatal", "feliz", "ficar", "fogue", "forca", "forno", "fraco", "fugir", "fundo", "furia",
    "gaita", "gasto", "geada", "gelar", "gosto", "grito", "gueto", "honra", "humor", "idade",
    "ideia", "idolo", "igual", "imune", "indio", "ingua", "irado", "isola", "janta", "jovem",
    "juizo", "largo", "laser", "leite", "lento", "lerdo", "levar", "lidar", "lindo", "lirio",
    "longe", "luzes", "magro", "maior", "malte", "mamar", "manto", "marca", "matar", "meigo",
    "meios", "melao", "mesmo", "metro", "mimos", "moeda", "moita", "molho", "morno", "morro",
    "motim", "muito", "mural", "naipe", "nasci", "natal", "naval", "ninar", "nivel", "nobre",
    "noite", "norte", "nuvem", "oeste", "ombro", "ordem", "orgao", "osseo", "ossos", "outro",
    "ouvir", "palma", "pardo", "passe", "patio", "peito", "pelos", "perdo", "peril", "perto",
    "pezar", "piano", "picar", "pilar", "pingo", "pione", "pista", "poder", "porem", "prado",
    "prato", "prazo", "preco", "prima", "primo", "pular", "quero", "quota", "raiva", "rampa",
    "rango", "reais", "reino", "rezar", "risco", "rocar", "rosto", "roubo", "russo", "saber",
    "sacar", "salto", "samba", "santo", "selar", "selos", "senso", "serao", "serra", "servo",
    "sexta", "sinal", "sobra", "sobre", "socio", "sorte", "subir", "sujei", "sujos", "talao",
    "talha", "tanga", "tarde", "tempo", "tenho", "terco", "terra", "tesao", "tocar", "lacre",
    "laico", "lamba", "lambo", "largo", "larva", "lasca", "laser", "laura", "lavra", "leigo",
    "leite", "leito", "leiva", "lenho", "lento", "leque", "lerdo", "lesao", "lesma", "levar",
    "libra", "limbo", "lindo", "lineo", "lirio", "lisar", "lista", "livro", "logar", "lombo",
    "lotes", "louca", "louco", "louro", "lugar", "luzes", "macio", "macom", "maior", "malha",
    "malte", "mamar", "mamae", "manto", "marco", "maria", "marra", "marta", "matar", "medir",
    "meigo", "meios", "melao", "menta", "menti", "mesmo", "metro", "miado", "midia", "mielo",
    "mielo", "milho", "mimos", "minar", "minha", "miolo", "mirar", "missa", "mitos", "moeda",
    "moido", "moita", "molde", "molho", "monar", "monja", "moral", "morar", "morda", "morfo",
    "morte", "mosca", "mosco", "motim", "motor", "mudar", "muito", "mular", "mulas", "mumia",
    "mural", "extra", "falar", "falta", "fardo", "farol", "farto", "fatal", "feixe", "festa",
    "feudo", "fezes", "fiapo", "fibra", "ficha", "fidel", "filao", "filho", "firma", "fisco",
    "fisga", "fluir", "forca", "forma", "forte", "fraco", "frade", "friso", "frito", "fugaz",
    "fugir", "fundo", "furor", "furto", "fuzil", "gabar", "gaita", "galho", "ganho", "garoa",
    "garra", "garro", "garvo", "gasto", "gaupe", "gazua", "geada", "gemer", "germe", "gigas",
    "girar", "gizar", "globo", "gosto", "graos", "graca", "grava", "grito", "grude", "haver",
    "haver", "hiato", "hidra", "hifen", "himel", "horas", "hotel", "humor", "ideal", "idolo",
    "igual", "ileso", "imune", "irado", "isola", "jarra", "jaula", "jegue", "jeito", "jogar",
    "jovem", "juiza", "juizo", "julho", "junho", "jurar", "justa"
}; //377
            Random numeroAleatorio = new Random();
            string palavraMisteriosa = palavras[numeroAleatorio.Next(0, palavras.Length)];

            return palavraMisteriosa;
        }
    }
}
