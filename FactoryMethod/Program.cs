using FactoryMethod.FactoryMethod;
bool run = true;

Console.WriteLine("Введите запросы для приложения.");
while (run)
{
    
    Console.WriteLine("1)Создать запрос на запись\n2)Вывести всю информацию\n" +
        "3)Вывести информацию конкретного объекта\n4)Выйти");
    int quary = int.Parse(Console.ReadLine());
    switch (quary)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Введите объект, который хотите создать:");
            string entity = Console.ReadLine();
            Console.WriteLine("Введите Id объекта");
            string id = Console.ReadLine();
            Console.WriteLine("Введите имя объекта:");
            string name = Console.ReadLine();

            string query = $"{entity},{id},{name}";
            InputHandler.CreateField(query);

            break;
        case 2:
            Console.Clear();
            Console.WriteLine("Вся информация в файле");
            Console.WriteLine("====================================");
            InputHandler.ReadFile();
            Console.WriteLine("====================================\n");
            break;
        case 3:
            
            Console.WriteLine("Введите объект, который хотите просмотреть:");
            entity = Console.ReadLine();
            Console.Clear();
            Console.WriteLine($"Вся информация о {entity}");
            Console.WriteLine("====================================");
            InputHandler.ReadFile(entity);
            Console.WriteLine("====================================\n");
            break;


        case 4:
            run = false;
            break;
        
        default:
            Console.Clear();
            Console.WriteLine("Введите конкретное число!");
            break;

    }
}

