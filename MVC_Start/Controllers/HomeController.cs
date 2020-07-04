using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_Start.Models;

namespace MVC_Start.Controllers
{
<<<<<<< HEAD
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult IndexWithLayout()
    {
      return View();
    }

    /// <summary>
    /// Replicate the chart example in the JavaScript presentation
    /// 
    /// Typically LINQ and SQL return data as collections.
    /// Hence we start the example by creating collections representing the x-axis labels and the y-axis values
    /// However, chart.js expects data as a string, not as a collection.
    ///   Hence we join the elements in the collections into strings in the view model
    /// </summary>
    /// <returns>View that will display the chart</returns>
    public ViewResult DemoChart()
    {
      string[] ChartLabels = new string[] { "Africa", "Asia", "Europe", "Latin America", "North America" };
      int[] ChartData = new int[] { 2478, 5267, 734, 784, 433 };

      ChartModel Model = new ChartModel
      {
        ChartType = "bar",
        Labels = String.Join(",", ChartLabels.Select(d => "'" + d + "'")),
        Data = String.Join(",", ChartData.Select(d => d)),
        Title = "Predicted world population (millions) in 2050"
      };

      return View(Model);
    }
  }
=======
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult IndexWithLayout()
        {
            return View();
        }

        public IActionResult Contact()
        {
            GuestContact contact = new GuestContact();

            contact.Name = "Raquel Varona";
            contact.Email = "raquelvarona@usf.edu";
            contact.Phone = "813-431-5727";

            return View(contact);

        }

        public ViewResult DemoChart()
        {
            string[] ChartLabels = new string[] { "Africa", "Asia", "Europe", "Latin America", "North America" };
            int[] ChartData = new int[] { 2478, 5267, 734, 784, 433 };

            ChartModel Model = new ChartModel
            {
                ChartType = "bar",
                Labels = String.Join(",", ChartLabels.Select(d => "'" + d + "'")),
                Data = String.Join(",", ChartData.Select(d => d)),
                Title = "Predicted world population (millions) in 2050"
            };

            return View(Model);
        }
    }
>>>>>>> 3ad7330... With Form
}