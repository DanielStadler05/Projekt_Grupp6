using System;
using System.Reflection;

namespace GruppXproject
{
    public class Program
    {
        public static List<Booking> BookedList = new List<Booking>();

        public static void Main(string[] args)
        {

        
            //fixa allt efter here

        static void AddPerson()
        {

            bool GenderFalse = false;
            while (!GenderFalse)
            {
                Console.WriteLine(
                    "How does the person identify?" +
                    "\n1: Male" +
                    "\n2: Female" +
                    "\n3: NonBinary" +
                    "\n4: Other");

                string GenderInput = Console.ReadLine();
                if (int.TryParse(GenderInput, out int SwitchGender))
                {
                    if (SwitchGender >= 1 && SwitchGender <= 4)
                    {
                        switch (SwitchGender)
                        {
                            case 1:
                                InputGender = Gender.Male;
                                GenderFalse = true;
                                break;

                            case 2:
                                InputGender = Gender.Female;
                                GenderFalse = true;
                                break;

                            case 3:
                                InputGender = Gender.NonBinary;
                                GenderFalse = true;
                                break;

                            case 4:
                                InputGender = Gender.Other;
                                GenderFalse = true;
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("Invalid input. (1-4)");
                                break;
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid input correct answer is int (1-4)");
                }
            }

            Console.Clear();
            while (true)
            {
                Console.WriteLine("Please enter birthday of the person. The only valid format is YYYY-MM-DD:");
                string Inputdate = Console.ReadLine();
                if (DateTime.TryParse(Inputdate, out InputDate))
                {
                    Console.Clear();
                    break;
                }
                Console.Clear();
                Console.WriteLine("Invalid input. The only valid format is YYYY-MM-DD");
            }



            Person person = new Person(InputName, InputGender, InputHair, InputEyeColor, InputDate);
            PersonList.Add(person);
        }
        static void ListPerson()
        {
            Console.Clear();
            Console.WriteLine("Here are the people: ");

            foreach (Person person in PersonList)
            {
                Console.WriteLine(person + "\n");
            }
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
        }
    }
}