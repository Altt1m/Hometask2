public class Program
{
    //(Обернути в методи)
    //Враховуючи вік у секундах, підрахуйте, скільки Вам років на різних планетах(підрахунки обернути в методи та взаємодіяти з користувачем.Врахувати нетипові ситуації)

    //Земля: орбітальний період 365,25 днів Землі, або 31557600 секунд
    //Меркурій: орбітальний період 0.2408467 від земних років
    //Венера: орбітальний період 0,61519726 від земних років
    //Марс: орбітальний період 1.8808158 від земних років
    //Юпітер: орбітальний період 11.862615 від земних років
    //Сатурн: орбітальний період 29.447498 від земних років
    //Уран: орбітальний період 84.016846 від земних років
    //Нептун: орбітальний період 164.79132 від земних років

    private double ageOnEarth; // Вік на Землі (у роках)
    private int earthYearInSeconds = 31557600; // Рік на Землі у секундах

    public void setAgeOnEarth() // Встановлюємо вік на Землі
    {
        Console.Write(" Скільки вам років? ");
        while (true) // Нескінченний цикл очікування правильних даних
        {
            try // Захист від дурачка №1
            {
                ageOnEarth = Convert.ToInt32(Console.ReadLine());
                if (ageOnEarth <= 0) // Захист від дурачка №2
                {
                    Console.WriteLine(" А є якийсь сенс рахувати?");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.Write(" Скільки вам років? (ще раз) ");
                    continue; // Якщо число <= 0
                }
                else if (ageOnEarth > 100)
                {
                    Console.WriteLine(" Ви хоч щось тут бачите, діду?");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Console.Write(" Скільки вам років? (ще раз) ");
                    continue; // Якщо число > 100
                }
                break; // Якщо правильні дані
            }
            catch (Exception) // Відловлювач винятків
            {
                Console.Clear();
                Console.Write(" Перепрошую, скільки вам ПОВНИХ років? (бажано числом) ");
            }
        }
    }

    public void getAgeOnMercury() // Вік на Меркурії
    {
        double ageOnMercuryInSeconds = ageOnEarth * earthYearInSeconds / 0.2408467;
        double ageOnMercury = ageOnMercuryInSeconds / earthYearInSeconds;
        Console.WriteLine($" 1) На Меркурію вам буде {ageOnMercury:f2} років.\n");
    }

    public void getAgeOnVenus() // Вік на Венері
    {
        double ageOnVenusInSeconds = ageOnEarth * earthYearInSeconds / 0.61519726;
        double ageOnVenus = ageOnVenusInSeconds / earthYearInSeconds;
        Console.WriteLine($" 2) На Венері вам буде {ageOnVenus:f2} років.\n");
    }

    public void getAgeOnMars() // Вік на Марсі
    {
        double ageOnMarsInSeconds = ageOnEarth * earthYearInSeconds / 1.8808158;
        double ageOnMars = ageOnMarsInSeconds / earthYearInSeconds;
        Console.WriteLine($" 3) На Марсі вам буде {ageOnMars:f2} років.\n");
    }

    public void getAgeOnJupiter() // Вік на Юпітері
    {
        double ageOnJupiterInSeconds = ageOnEarth * earthYearInSeconds / 11.862615;
        double ageOnJupiter = ageOnJupiterInSeconds / earthYearInSeconds;
        Console.WriteLine($" 4) На Юпітері вам буде {ageOnJupiter:f3} років.\n");
    }

    public void getAgeOnSaturn() // Вік на Сатурні
    {
        double ageOnSaturnInSeconds = ageOnEarth * earthYearInSeconds / 29.447498;
        double ageOnSaturn = ageOnSaturnInSeconds / earthYearInSeconds;
        Console.WriteLine($" 5) На Сатурні вам буде {ageOnSaturn:f3} років.\n");
    }

    public void getAgeOnUranus() // Вік на Урані
    {
        double ageOnUranusInSeconds = ageOnEarth * earthYearInSeconds / 84.016846;
        double ageOnUranus = ageOnUranusInSeconds / earthYearInSeconds;
        Console.WriteLine($" 6) На Урані вам буде {ageOnUranus:f3} років.\n");
    }

    public void getAgeOnNeptune() // Вік на Нептуні
    {
        double ageOnNeptuneInSeconds = ageOnEarth * earthYearInSeconds / 164.79132;
        double ageOnNeptune = ageOnNeptuneInSeconds / earthYearInSeconds;
        Console.WriteLine($" 7) На Нептуні вам буде {ageOnNeptune:f3} років.\n");
    }

    public void show() // Метод показу віків
    {
        Console.WriteLine($" В той час як на Землі Вам {ageOnEarth} років, на інших планетах Вам буде приблизно стільки:\n");
        getAgeOnMercury();
        getAgeOnVenus();
        getAgeOnMars();
        getAgeOnJupiter();
        getAgeOnSaturn();
        getAgeOnUranus();
        getAgeOnNeptune();
    }

    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8; // Встановлення кодировки

        Program user = new Program(); // Створення об'єкта класу Program
        user.setAgeOnEarth(); // Встановлення віку на Землі
        user.show(); // Показ віків на інших планетах
    }
}