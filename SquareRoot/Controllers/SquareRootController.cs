using System;
using Microsoft.AspNetCore.Mvc;

namespace SquareRoot.Controllers
{
    public class SquareRootController : Controller
    {
        public ActionResult Higher()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Higher(string firstNumber, string secondNumber)
        {
            int numberOne = int.Parse(firstNumber);
            int numberTwo = int.Parse(secondNumber);
            double squareOne = Math.Sqrt(numberOne);
            double squareTwo = Math.Sqrt(numberOne);
            if(squareOne > squareTwo){
                int result = numberOne;
            }else if(squareOne < squareTwo){
                int result = numberTwo;
            };

            ViewBag.Result = result;
            return View();
        }
    }
}