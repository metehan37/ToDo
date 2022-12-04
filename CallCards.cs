namespace ToDo;

public class CallCards
{
    public static void Call()
    {
        Console.WriteLine("TODO Line");
        Console.WriteLine("************************");
        if (CardList.cardsTodo.Count==0)
        {
            Console.WriteLine("~ BOŞ ~");
        }
        else
        {
           foreach (var item in CardList.cardsTodo)
        {
            Console.WriteLine("Başlık      : {0}",item.Title);
            Console.WriteLine("İçerik      : {0}",item.Content);
            Console.WriteLine("Atanan Kişi : {0}",item.Member.Name);
            Console.WriteLine("Büyüklük    : {0}",item.Size);
            Console.WriteLine("-");
        } 
        }
        Console.WriteLine("IN PROGRESS Line");
        Console.WriteLine("************************");
        if (CardList.cardsDone.Count==0)
        {
            Console.WriteLine("~ BOŞ ~");
        }
        else
        {
                                foreach (var item in CardList.cardsInTodo)
        {
            Console.WriteLine("Başlık      : {0}",item.Title);
            Console.WriteLine("İçerik      : {0}",item.Content);
            Console.WriteLine("Atanan Kişi : {0}",item.Member.Name);
            Console.WriteLine("Büyüklük    : {0}",item.Size);
            Console.WriteLine("-");
        }
        }
        Console.WriteLine("DONE Line");
        Console.WriteLine("************************");
        if (CardList.cardsDone.Count==0)
        {
            Console.WriteLine("~ BOŞ ~");
        }
        else
        {
            foreach (var item in CardList.cardsDone)
            {
                Console.WriteLine("Başlık      : {0}",item.Title);
                Console.WriteLine("İçerik      : {0}",item.Content);
                Console.WriteLine("Atanan Kişi : {0}",item.Member.Name);
                Console.WriteLine("Büyüklük    : {0}",item.Size);
                Console.WriteLine("-");
            } 
        }
    }
}