namespace ToDo;

public class MoveCard{
    public static void Move(List<Card> cardsToDo,List<Card> cardsInToDo,List<Card> cardsDone)
    {
        bool find=false;
        while (find !=true)
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string title=Console.ReadLine();
            foreach (Card item in cardsToDo)
            {
                if (item.Title==title)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Başlık      : {0}",item.Title);
                    Console.WriteLine("İçerik      : {0}",item.Content);
                    Console.WriteLine("Atanan Kişi : {0}",item.Member.Name);
                    Console.WriteLine("Büyüklük    : {0}",item.Size);
                    Console.WriteLine("Line        : TODO");
                    Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz: ");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    string val=Console.ReadLine();
                    switch (val)
                    {
                        case "1":
                        {
                            Console.WriteLine("Zaten bu line'da");
                            break;
                        }
                        case "2":
                        {
                            CardList.cardsInTodo.Add(item);
                            CardList.cardsTodo.Remove(item);
                            break;
                        }
                        case "3":
                        {
                            CardList.cardsDone.Add(item);
                            CardList.cardsTodo.Remove(item);
                            break;
                        }
                        default: 
                        {
                            Console.WriteLine("Yanlış değer girdiniz. Programdan çıkılıyor...");
                            find=true;
                            break;
                        }
                    }
                    find=true;
                    break;
                }
            }
            if (find)
            {
                break;
            }
            foreach (Card item in cardsInToDo)
            {
                if (item.Title==title)
                {
                    Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Başlık      : {0}",item.Title);
                    Console.WriteLine("İçerik      : {0}",item.Content);
                    Console.WriteLine("Atanan Kişi : {0}",item.Member.Name);
                    Console.WriteLine("Büyüklük    : {0}",item.Size);
                    Console.WriteLine("Line        : IN PROGRESS");
                    Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz: ");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    string val=Console.ReadLine();
                    switch (val)
                    {
                        case "1":
                        {
                            CardList.cardsTodo.Add(item);
                            CardList.cardsInTodo.Remove(item);
                            break;
                        }
                        case "2":
                        {
                            Console.WriteLine("Zaten bu line'da");
                            break;
                        }
                        case "3":
                        {
                            CardList.cardsDone.Add(item);
                            CardList.cardsInTodo.Remove(item);
                            break;
                        }
                        default: 
                        {
                            Console.WriteLine("Yanlış değer girdiniz. Programdan çıkılıyor...");
                            find=true;
                            break;
                        }
                    }
                    find=true;
                    break;
                }
            }
            if (find)
            {
                break;
            }
            foreach (Card item in cardsDone)
            {
                if (item.Title==title)
                {
                   Console.WriteLine("Bulunan Kart Bilgileri:");
                    Console.WriteLine("**************************************");
                    Console.WriteLine("Başlık      : {0}",item.Title);
                    Console.WriteLine("İçerik      : {0}",item.Content);
                    Console.WriteLine("Atanan Kişi : {0}",item.Member.Name);
                    Console.WriteLine("Büyüklük    : {0}",item.Size);
                    Console.WriteLine("Line        : Done");
                    Console.WriteLine("\nLütfen taşımak istediğiniz Line'ı seçiniz: ");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    string val=Console.ReadLine();
                    switch (val)
                    {
                        case "1":
                        {
                            CardList.cardsTodo.Add(item);
                            CardList.cardsDone.Remove(item);
                            break;
                        }
                        case "2":
                        {
                            CardList.cardsInTodo.Add(item);
                            CardList.cardsDone.Remove(item);
                            break;
                        }
                        case "3":
                        {
                            Console.WriteLine("Zaten bu line'da");
                            break;
                        }
                        default: 
                        {
                            Console.WriteLine("Yanlış değer girdiniz. Programdan çıkılıyor...");
                            find=true;
                            break;
                        }
                    }
                    find=true;
                    break;
                }
            }
            if (find==false)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Taşımayı sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                string value=Console.ReadLine();
                switch (value)
                {
                    case "1":
                    {
                        find=true;
                        break;
                    }
                    case "2":
                    {
                        break;
                    }
                    
                    default: 
                    {
                        Console.WriteLine("Yanlış değer girdiniz programdan çıkılıyor...");
                        find=true;
                        break;
                    }
                }
            }
        }
    }
}