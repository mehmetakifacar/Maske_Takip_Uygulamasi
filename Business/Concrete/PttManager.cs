using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager
    {
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GivenMask(Person person)
        {

            if (_applicantService.CheckPerson(person) == true)
            {
                Console.WriteLine("Sonuç : " + person.FirstName + " " + person.LastName + " " + "için maske verildi.");
            }
            else
            {
                Console.WriteLine("Sonuç : " + person.FirstName + " " + person.LastName + " " + "için maske verilemedi !");
            }
        }


    }
}
