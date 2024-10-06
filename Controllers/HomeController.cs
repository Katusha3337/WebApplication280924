using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication280924.Models;

namespace WebApplication280924.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new MatrixModel());
        }

        [HttpPost]
        public IActionResult Calculate(MatrixModel model, string operation)
        {
            model.Result = new int[model.Size][];

            for (int i = 0; i < model.Size; i++)
            {
                model.Result[i] = new int[model.Size];
                for (int j = 0; j < model.Size; j++)
                {
                    if (operation == "Add")
                    {
                        model.Result[i][j] = model.MatrixA[i][j] + model.MatrixB[i][j];
                    }
                    else if (operation == "Multiply")
                    {
                        model.Result[i][j] = 0;
                        for (int k = 0; k < model.Size; k++)
                        {
                            model.Result[i][j] += model.MatrixA[i][k] * model.MatrixB[k][j];
                        }
                    }
                }
            }

            return View("Result", model);
        }
    }
}
