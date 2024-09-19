using AppIlhabela.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppIlhabela.Controllers
{
    public class EventoController : Controller
    {
        private const string img = "/img/copaMit.jpeg";

        // Método que exibe a página inicial com todos os eventos
        public ActionResult Index()
        {
            var events = GetEvents();
            ViewBag.Beaches = GetBeaches();
            return View(events);
        }

        // Método para exibir os eventos de uma praia específica
        public ActionResult BeachEvents(string beachName)
        {
            var events = GetEvents().Where(e => e.nome == beachName).ToList();
            return View("BeachEvents", events);
        }


        // Simulação de dados
        private List<Praias> GetEvents()
        {
            return new List<Praias>
                {
                    new Praias { nome = "Praia de Castelhanos", descriçao = "url-to-image-1.jpg", preços = 20 },
                    new Praias { nome = "Praia 2", descriçao = "url-to-image-2.jpg", preços = 20 },
                    new Praias { nome = "Praia 3", descriçao = "url-to-image-3.jpg", preços = 20 },
                    new Praias { nome = "Praia 4", descriçao = "url-to-image-4.jpg", preços = 20 }
                 };
        }

        private List<string> GetBeaches()
        {
            return new List<string> { "Praia de Castelhanos", "Praia do Perequê", "Praia da Feiticeira", "Praia do Curral", "Praia do Jabaquara" };
        }

        public ActionResult EventDetails()
        {

            // Simulação de dados do evento
            var eventoEvent = new Evento
            {
                nome = "Copa Mitsubishi",
                descriçao = "A copa Mitsubishi é um circuito de vela oceânica que acontece na Praia de Castelhabos, em IlhaBela, e é considerado o maior do Brasil na sua categoria. O evento reúne várias classes de veleiros, desde os de entrada até os de ponta, e atrai tanto equipes experientes quanto novos praticantes.",
                imagem = img,
                link = "https://circuitoilhabela.com.br"
            };

            // Simulação de dados da praia
            var agendaEvent = new Agenda
            {
                data = new List<DateTime> { new DateTime(2024, 6, 15), new DateTime(2024, 6, 16), new DateTime(2024, 6, 22), new DateTime(2024, 6, 23) },
                horario = "15 e 22 às 08:00; 16 e 23 às 14:00",
            };
            var locEvent = new Local
            {
                logradouro = "Av. Força Expedicionária Brasileira",
                nome = "Yacht Club de Ilhabela  - Santa Tereza",
                numero = 399,
            };

            // Preencher o ViewModel com os dados
            var viewModel = new ViewEventos
            {
                Event = eventoEvent,
                Agenda = agendaEvent,
                Loc = locEvent,
            };

            return View(viewModel);
        }

    }
}





