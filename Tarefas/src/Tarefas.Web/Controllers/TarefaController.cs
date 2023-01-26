using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers{
    public class TarefaController : Controller
    {

        public List<TarefaViewModel> listaDeTarefas { get; set; }

        public TarefaController()
        {
            listaDeTarefas =new List<TarefaViewModel>(){
                new TarefaViewModel(){Id = 1, Titulo = "Escovar os dentes"},
                new TarefaViewModel(){Id = 2, Titulo = "Escovar arrumar a cama"},
                new TarefaViewModel(){Id = 3, Titulo = "Por o lixo para fora", Descricao="Somente as terças"}

            };
        }

        
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Index()
        {            
            return View(listaDeTarefas);            
        }

        public IActionResult Details(int id)
        {
            var tarefa = listaDeTarefas.Find(tarefa=>tarefa.Id == id);
            return View(tarefa);
        }
    }
}