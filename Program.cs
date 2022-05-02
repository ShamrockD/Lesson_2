using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Дверь. 2 балла
            /*Легенда: Вы оказались перед дверью, которая открывается только при вашем 18летии.После открытия двери вы видите сообщение. 
            Формально: Есть bool переменная IsDoorOpen, она равна true только если пользователю есть 18.Возвраст пользователя программа также запрашивает сама.*/
            bool isDoorOpen = false;
            Console.WriteLine($"Легенда: Вы оказались перед дверью, которая открывается только при вашем 18летии сейчас ее статус {isDoorOpen}, введите ваш возраст: ");
            
            Int32.TryParse(Console.ReadLine(), out int userAge);
            if (userAge >= 18)
            {
                isDoorOpen = true;
                Console.WriteLine($"Дверь открыта. isDoorOpen: {isDoorOpen}");
            }
            else
            {
                Console.WriteLine($"Извини, но ты слишком юн и дверь закрыта. isDoorOpen: {isDoorOpen}");
            }

            // Done ___________________________________________________________________________________________________________________

            //2. Конвертер валют. 5 балла и + 1 возможный доп. балл
            /*Написать конвертер валют(3 валюты).
            У пользователя есть баланс в каждой из представленных валют.Он может попросить сконвертировать часть баланса в одной валюты в другую.
            Тогда у него с баланса одной валюты снимет X и зачислится на баланс другой Y.
            Курс конвертации должен быть просто прописан в программе. */

            Console.Write("Введите свое количество рублей: ");
            float userRubles = float.Parse(Console.ReadLine());
            Console.Write("Введите свое количество долларов: ");
            float userDollars = float.Parse(Console.ReadLine());
            Console.Write("Введите свое количество евро: ");
            float userEuro = float.Parse(Console.ReadLine());

            // Курсы конвертации валют
            float euroToDol = 1.05f;
            float dolToEuro = 0.95f;
            float dolToRub = 71.29f;
            float euroToRub = 76.07f;

            while (true)
            {
                Console.WriteLine("Выберите вариант конвертации валюты: 1 - Рубли в евро, 2 - Рубли в доллары, 3 - Евро в доллары, 4 - Евро в рубли, 5 - Доллары в евро, 6 - Доллары в рубли, 7 - Ваш баланс");

                int covertOption = Int32.Parse(Console.ReadLine());

                switch (covertOption)
                {
                    case 1:
                        Console.WriteLine("Сумма для конвертации");
                        float valueToConvertrubToEuro = float.Parse(Console.ReadLine());
                        if (valueToConvertrubToEuro > userRubles)
                        {
                            Console.WriteLine("Сумма превышает лимит");
                            break;
                        }
                        else
                        {
                            userEuro += valueToConvertrubToEuro / euroToRub;
                            userRubles -= valueToConvertrubToEuro;
                            Console.WriteLine(userEuro + " Euros now have");
                            break;
                        }
                    case 2:
                        Console.WriteLine("Сумма для конвертации");
                        float valueToConvertrubToDol = float.Parse(Console.ReadLine());
                        if (valueToConvertrubToDol > userRubles)
                        {
                            Console.WriteLine("Сумма превышает лимит");
                            break;
                        }
                        else
                        {
                            userDollars += valueToConvertrubToDol / dolToRub;
                            userRubles -= valueToConvertrubToDol;
                            Console.WriteLine(userDollars + " Dollars now have");
                            break;
                        }
                    case 3:
                        Console.WriteLine("Сумма для конвертации");
                        float valueToConvertEuroToDol = float.Parse(Console.ReadLine());
                        if (valueToConvertEuroToDol > userEuro)
                        {
                            Console.WriteLine("Сумма превышает лимит");
                            break;
                        }
                        else
                        {
                            userDollars += valueToConvertEuroToDol / dolToEuro;
                            userEuro -= valueToConvertEuroToDol;
                            Console.WriteLine(userDollars + " Dollars now have");
                            break;
                        }
                    case 4:
                        Console.WriteLine("Сумма для конвертации");
                        float valueToConvertEuroToRub = float.Parse(Console.ReadLine());
                        if(valueToConvertEuroToRub > userEuro)
                        {
                            Console.WriteLine("Сумма превышает лимит");
                            break;
                        }
                        else
                        {
                            userRubles += valueToConvertEuroToRub * euroToRub;
                            userEuro -= valueToConvertEuroToRub;
                            Console.WriteLine(userRubles + " Rubles now have");
                            break;
                        }
                    case 5:
                        Console.WriteLine("Сумма для конвертации");
                        float valueToConvertDolToEuro = float.Parse(Console.ReadLine());
                        if (valueToConvertDolToEuro > userDollars)
                        {
                            Console.WriteLine("Сумма превышает лимит");
                            break;
                        }
                        else
                        {
                            userEuro += valueToConvertDolToEuro * dolToEuro;
                            userDollars -= valueToConvertDolToEuro;
                            Console.WriteLine(userEuro + " Euros now have");
                            break;
                        }
                    case 6:
                        Console.WriteLine("Сумма для конвертации");
                        float valueToConvertDolToRub = float.Parse(Console.ReadLine());
                        if(valueToConvertDolToRub > userDollars)
                        {
                            Console.WriteLine("Сумма превышает лимит");
                            break;
                        }
                        else
                        {
                            userRubles += valueToConvertDolToRub * dolToRub;
                            userDollars -= valueToConvertDolToRub;
                            Console.WriteLine(userRubles + " Rubles you have now");
                            break;
                        }
                    case 7:
                        Console.WriteLine($"Ваш баланс: {userRubles} рублей {userDollars} долларов {userEuro} евро");
                        break;
                    default:
                        Console.WriteLine("Wrong option, try again please");
                        break;
                }
            }

        }
    }
}
