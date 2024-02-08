using Business.Concrete;
using Entities.Concrete;

namespace Maske_Takip_Uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();

            person1.FirstName = "Akif";
            person1.LastName = "GÜNER";
            person1.DateOfBirth = 1993;
            person1.NationalIdentity = 12345678912;

            Person person2 = new Person();

            person2.FirstName = "Cengiz";
            person2.LastName = "BEYYAMAN";
            person2.DateOfBirth = 1998;
            person2.NationalIdentity = 98765432101;


            Console.WriteLine("Sorgulama Yapılıyor...");

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GivenMask(person1);
            pttManager.GivenMask(person2);

            Console.ReadLine();
          
        }
    }

   
}
