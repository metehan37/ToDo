namespace ToDo;

public class DeleteCard{
    public static void Delete(List<Card> cardsToDo,List<Card> cardsInToDo,List<Card> cardsDone){

        bool find=false;
        while (find !=true)
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız: ");
            string title=Console.ReadLine();
            foreach (Card item in cardsToDo)
            {
                if (item.Title==title)
                {
                    CardList.cardsTodo.Remove(item);
                    find=true;
                    break;
                }
            }
            foreach (Card item in cardsInToDo)
            {
                if (item.Title==title)
                {
                    CardList.cardsInTodo.Remove(item);
                    find=true;
                    break;
                }
            }
            foreach (Card item in cardsDone)
            {
                if (item.Title==title)
                {
                    CardList.cardsDone.Remove(item);
                    find=true;
                    break;
                }
            }
            if (find==false)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
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