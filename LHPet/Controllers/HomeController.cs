using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancias do tipo clientes
        Cliente cliente1 = new Cliente(01, "Rafael Zuck", "123.456.789-00", "fafaelrazk@sp.senai.br", "Madurga");
         Cliente cliente2 = new Cliente(02, "Rinnachle A. Santos", "123.456.444-00", "Rina@sp.senai.br", "bug");
          Cliente cliente3 = new Cliente(03, "Paulo Magalhes de Almeida", "123.222.789-00", "Paulo_almeida@sp.senai.br", "Byron");
           Cliente cliente4 = new Cliente(04, "Marcos Luiz Silva", "111.456.789-00", "Silvaluizsp.senai.br", "Pinguim");
            Cliente cliente5 = new Cliente(05, "Rafaela Zuck", "111.456.444-00", "fafaelarazk@sp.senai.br", "Loboc");


        // lista clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
         listaClientes.Add(cliente2);
          listaClientes.Add(cliente3);
           listaClientes.Add(cliente4);
            listaClientes.Add(cliente5);

            ViewBag.listaClientes = listaClientes;


        //instancias do tipo fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01, "C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
         Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.111.122/0001-33", "ctrolalt@alt.br");
          Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INC", "33.555.122/0001-21", "boots.pet@gatomania.us");
           Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "36.163.367/0001-11", "noisnamidia@tiktokdogs.uk");
            Fornecedor fornecedor5 = new Fornecedor(05, "Picanha 0800", "03.367.103/0001-34", "Bifinho@buufs.br");

        // lista clientes
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
