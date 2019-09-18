// Метод для считывания значения любого типа 

public static bool readVal<T>(out T var)
        {
            Console.WriteLine($"Input {typeof(T).Name}");
            string tmp;
            while (true)
            {
                tmp = Console.ReadLine();
                if (tmp == "q")
                {
                    var = default(T);
                    return false;
                }
                try
                {
                    var = (T)TypeDescriptor.GetConverter(typeof(T)).ConvertFromString(tmp);
                    return true;
                }
                catch
                {
                    Console.WriteLine("Wrong format. Try again or type 'q' to exit");
                }
            }
        }
