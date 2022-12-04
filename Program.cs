namespace ToDo;
class Program
{
    static void Main(string[] args)
    {
        MemberList memberList =new MemberList();// Varsayılan üyeler oluşturuluyor.
        CardList cardList=new CardList();//Varsayılan kartlar oluşturuluyor.

        bool process=false;
        while (process != true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            string selected=Console.ReadLine();

            switch (selected)
            {
                case "1":
                {
                    CallCards.Call();
                    break;
                }
                case "2":
                {
                    AddCard.Add();
                    break;
                }
                case "3":
                {
                    DeleteCard.Delete(CardList.cardsTodo,CardList.cardsInTodo,CardList.cardsTodo);
                    break;   
                }
                case "4":
                {
                    MoveCard.Move(CardList.cardsTodo,CardList.cardsInTodo,CardList.cardsTodo);
                    break;
                }
                
                default: 
                {
                    Console.WriteLine("Geçerli bir değer giriniz.");
                    break;
                }
            }

        }
    }
}
