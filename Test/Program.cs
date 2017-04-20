using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployerViewModelManager employerViewModelManager = new EmployerViewModelManager();
            List<EmployerViewModel> employerViewModelList = employerViewModelManager.GetEmployerViewModelList();
            foreach (var item in employerViewModelList)
            {
                Console.WriteLine(item.employerId+" , "+item.name);
            }

            Console.WriteLine("any key to exit ...");
            Console.ReadKey();
        }
    }
}
