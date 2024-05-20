namespace Lab5_dot_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.WriteLine("Данi такi рецепти, виберiть термiн дiї якого ви б хотiли подовжити (1, 2, 3): ");
                IPrescription prescription = new Prescription("Петро Iванов", DateTime.Now.AddDays(30));
                Console.WriteLine($"{prescription.GetDescription()}, термiн дiї до {prescription.GetExpirationDate()}");

                IPrescription prescription1 = new Prescription("Данило Лiщицький", DateTime.Now.AddDays(21));
                Console.WriteLine($"{prescription1.GetDescription()}, термiн дiї до {prescription1.GetExpirationDate()}");

                IPrescription prescription2 = new Prescription("Олена Нужна", DateTime.Now.AddDays(7));
                Console.WriteLine($"{prescription2.GetDescription()}, термiн дiї до {prescription2.GetExpirationDate()}");


                int choice = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("На скiльки днiв подовжити термiн дiї рецепту? ");
                int num;
                bool isValidNum = int.TryParse(Console.ReadLine(), out num);

                Console.WriteLine("Ввведiть по-батьковi лікаря: ");
                string patronymic = Console.ReadLine();

                while (!isValidNum || num <= 0)
                {
                    Console.WriteLine("Будь ласка, введiть коректну кiлькiсть днiв (не менше 0): ");
                    isValidNum = int.TryParse(Console.ReadLine(), out num);
                }

                switch (choice)
                {
                    case 1:
                        prescription = new DoctorPatronymicDecorator(prescription, patronymic);
                        prescription = new ExtendedPrescription(prescription, num);
                        Console.WriteLine($"{prescription.GetDescription()}, термiн дiї до {prescription.GetExpirationDate()}");
                        break;
                    case 2:
                        prescription1 = new DoctorPatronymicDecorator(prescription1, patronymic);
                        prescription1 = new ExtendedPrescription(prescription1, num);
                        Console.WriteLine($"{prescription1.GetDescription()}, термiн дiї до {prescription1.GetExpirationDate()}");
                        break;
                    case 3:
                        prescription2 = new DoctorPatronymicDecorator(prescription2, patronymic);
                        prescription2 = new ExtendedPrescription(prescription2, num);
                        Console.WriteLine($"{prescription2.GetDescription()}, термiн дiї до {prescription2.GetExpirationDate()}");
                        break;
                    default:
                        Console.WriteLine("Невірний вибір рецепту");
                        return;
                }

                Console.WriteLine("Бажаєте продовжити? +/-");
                answer = Console.ReadLine();
                Console.Clear();
            } while (answer == "+");
        }
    }
}
