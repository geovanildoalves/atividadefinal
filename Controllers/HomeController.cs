using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPET.Models;
using LHPet.Models;

namespace LHPET.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
              
    {
         //instâncias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Geovanildo Borges", "857.032.950-41", "geovanildo.alves@aluno.senai.br", "Bandeirinha");
        Cliente cliente2 = new Cliente(02, "Marcos", "856.032.950-41", "geovanildo.alves@aluno.senai.br", "Bandeira");
        Cliente cliente3 = new Cliente(03, "Paulo", "855.032.950-41", "geovanildo.alves@aluno.senai.br", "Bande");
        Cliente cliente4 = new Cliente(04, "José", "854.032.950-41", "geovanildo.alves@aluno.senai.br", "Ban");
        Cliente cliente5 = new Cliente(05, "Carlos", "853.032.950-41", "geovanildo.alves@aluno.senai.br", "Ban");

          //lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

         //instâncias do tipo fornecedor 
        Fornecedor fornecedor1 = new Fornecedor(01, "Geo SA", "14.182.102/0001-80", "geovanildo.alves@aluno.senai.br");
        Fornecedor fornecedor2 = new Fornecedor(02, "Marco SA", "15.836.698/0001-57", "geovanildo.alves@aluno.senai.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Paula Ltda", "40.810.224/0001-83", "geovanildo.alves@aluno.senai.br");
        Fornecedor fornecedor4 = new Fornecedor(04, "Joana CIA", "87.945.350/0001-09", "geovanildo.alves@aluno.senai.br");
        Fornecedor fornecedor5 = new Fornecedor(05, "Carla Ltda", "818.760.614/0001-37", "geovanildo.alves@aluno.senai.br");


        //lista de fornecedores e atribui os fornecedores
           List<Fornecedor> listaFornecedores = new List<Fornecedor>();
           listaFornecedores.Add(fornecedor1);
           listaFornecedores.Add(fornecedor2);
           listaFornecedores.Add(fornecedor3);
           listaFornecedores.Add(fornecedor4);
           listaFornecedores.Add(fornecedor5);
        
         ViewBag.listaFornecedores = listaFornecedores;

       return View();
    }    
   

 public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }


}
