using AppIlhabela.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AppIlhabela.Controllers
{
    public class PraiaController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
        
        public ActionResult Hist() {
            var hist = new História
            {
                historia = "Ilhabela, localizada no litoral norte do estado de São Paulo, tem uma história rica que remonta a séculos. Antes da chegada dos europeus, a região era habitada por indígenas Tupinambás. Em 1502, o navegador português Américo Vespúcio, ao explorar a costa brasileira, teria avistado a ilha, que inicialmente foi chamada de \"Ilha de São Sebastião\" em homenagem a São Sebastião, santo do dia em que a expedição a avistou (20 de janeiro). Este nome permaneceu durante muitos anos e ainda é oficialmente o nome de seu município: São Sebastião.",
                historiaNome = "O nome \"Ilhabela\" surgiu posteriormente, por volta de 1945, quando a ilha passou a ser conhecida popularmente por seu cenário paradisíaco, destacando-se por suas belas paisagens naturais. O nome Ilhabela (anteriormente grafado como \"Ilha Bela\") é uma referência direta à sua aparência cênica, com praias, cachoeiras e montanhas cobertas pela Mata Atlântica.",
                evoluçao = "Nos últimos anos, Ilhabela tem se consolidado como um dos principais destinos turísticos do Brasil, conhecida por sua preservação ambiental e por abrigar um dos maiores parques estaduais do país, o Parque Estadual de Ilhabela, que protege cerca de 85% de seu território. A ilha é famosa por suas trilhas, cachoeiras e praias de beleza única, além de ser um ponto importante para a prática de esportes náuticos, como a vela e o mergulho.\r\n\r\nA evolução de Ilhabela tem sido marcada por um equilíbrio entre o desenvolvimento turístico e a preservação ambiental, com um número crescente de visitantes, mas também com esforços para manter sua biodiversidade. A infraestrutura da ilha também tem se modernizado para atender a essa demanda turística, com investimentos em transporte, hospedagem e serviços.\r\n\r\nHoje, Ilhabela é uma mistura de natureza preservada e modernidade, atraindo turistas do mundo todo, enquanto mantém sua identidade histórica e cultural."
            };
            return View(hist);
        }

        public ActionResult Descricao()
        {

            var praia = new Praias
            {
                id = 1,
                nome = "Praia de Castelhanos",
                subtit = "Como chegar, valores, informações importantes e + !",
                descriçao = "A Praia de Castelhanos é famosa por seu formato de coração, especialmente quando vista de pontos mais altos ou a partir de imagens aéreas. Esse formato único é resultado da combinação da linha da costa e da vegetação ao redor, que criam essa aparência distinta. ",
                chegar = new List<ComoChegar>
                {
                new ComoChegar
                {
                    titulo = "Acesso de Carro 4x4",
                    descriçao = "A estrada que leva à Praia de Castelhanos é de terra e bastante acidentada, sendo recomendável o uso de veículos 4x4. O trajeto começa na Estrada de Castelhanos, que atravessa o Parque Estadual de Ilhabela, e leva cerca de 1h30 a 2h, dependendo das condições da estrada."
                },
                new ComoChegar
                {
                     titulo = "Passeio de Jipe",
                    descriçao = " Diversas agências de turismo em Ilhabela oferecem passeios de jipe até Castelhanos. Esses passeios geralmente incluem transporte, guias e paradas em pontos turísticos ao longo do caminho.\r\n"
                },
                new ComoChegar
                {
                    titulo = "Barco",
                    descriçao = "Também é possível chegar à Praia de Castelhanos de barco, partindo da Vila ou da Praia do Perequê. Esse trajeto oferece vistas deslumbrantes da costa e leva aproximadamente 1 hora."
                }
                }
            };
                return View(praia);
        
        }
            public ActionResult DescricaoPra()
            {

                var praia2 = new Praias
                {
                    id = 2,
                    nome = "Praia da Feiticeira",
                    subtit = "Como chegar, valores, informações importantes e + !",
                    descriçao = "\r\nA Praia da Feiticeira é uma das praias mais charmosas e tranquilas de Ilhabela. Ela está localizada no sul da ilha, entre as praias do Portinho e do Julião, e é conhecida por sua beleza natural, águas calmas e cristalinas, além da sombra oferecida pelas árvores que cercam a orla. Seu nome está envolto em lendas locais, que falam sobre uma antiga moradora, chamada de \"feiticeira\", que teria vivido na região e praticado magia.",
                    chegar = new List<ComoChegar>
                {
                new ComoChegar
                {
                    titulo = "Acesso de Carro 4x4",
                    descriçao = "Após desembarcar da balsa, siga pela Avenida Perimetral, a principal via que percorre o litoral da ilha. Dirija em direção ao sul da ilha (sentido sul da SP-131). A Praia da Feiticeira está bem sinalizada, com um pequeno estacionamento próximo à entrada, a partir do qual é necessário caminhar por uma trilha curta, mas íngreme."
                },
                new ComoChegar
                {
                     titulo = "Passeio de Ônibus",
                    descriçao = " Para quem não está de carro, há linhas de ônibus locais que fazem o percurso entre o centro de Ilhabela e o sul da ilha. Os ônibus partem da Vila (centro histórico) ou da balsa, e é necessário descer no ponto mais próximo à entrada da praia."
                },
                new ComoChegar
                {
                    titulo = "Por uma trilha",
                    descriçao = "Para quem gosta de aventura, é possível chegar à Praia da Feiticeira a partir de uma trilha que começa perto da Praia do Portinho. A caminhada leva em torno de 30 minutos e passa por trechos de Mata Atlântica, além de revelar vistas incríveis do mar."
                }
                }
                };


                return View(praia2);

        }
    }
}


