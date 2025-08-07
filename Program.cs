using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Triage_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symptoms = new string[5];
            string[] departments = new string[5];

            string[] generalKeywords = { "fever", "cough" };
            string[] emergencyKeywords = { "injury", "burn" };

            Console.WriteLine("Hospital Patient Department Assignment System");
            Console.WriteLine("Enter symptoms for 5 patients (one symptom per patient):");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Patient {i + 1} symptom: ");
                symptoms[i] = Console.ReadLine().ToLower(); 

                if (Array.Exists(generalKeywords, keyword => keyword == symptoms[i]))
                {
                    departments[i] = "General Medicine";
                }
                else if (Array.Exists(emergencyKeywords, keyword => keyword == symptoms[i]))
                {
                    departments[i] = "Emergency";
                }
                else
                {
                    departments[i] = "Refer to Specialist";
                }
            }
            
            Console.WriteLine("\nPatient Assignments:");
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Patient {i + 1}: Symptom - {symptoms[i]}, Department - {departments[i]}");
            }
        }
    }
}
