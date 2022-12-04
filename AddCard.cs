namespace ToDo;

public class AddCard
{
    public static void Add(){
        Console.WriteLine("Başlık Giriniz                                  :");
        string title=Console.ReadLine();
        Console.WriteLine("İçerik Giriniz                                  :");
        string content=Console.ReadLine();
        Console.WriteLine("Büyüklük Seçiniz -> XS(1),S(2),M(3),L(4),XL(5)  :");
        string size=Console.ReadLine();
        Console.WriteLine("Kişi Seçiniz -> (0,1,2,3,4)                     :");
        string person=Console.ReadLine();
        if (person=="0"||person=="1"||person=="2"||person=="3"||person=="4")
        {
            switch (size)
            {
                case "1":
                {
                    CardList.cardsTodo.Add(new Card(title,content,MemberList.members[Int16.Parse(person)],Sizes.XS));
                    break;
                }
                case "2":
                {
                    CardList.cardsTodo.Add(new Card(title,content,MemberList.members[Int16.Parse(person)],Sizes.S));
                    break;
                }
                case "3":
                {
                    CardList.cardsTodo.Add(new Card(title,content,MemberList.members[Int16.Parse(person)],Sizes.M));
                    break;
                }
                case "4":
                {
                    CardList.cardsTodo.Add(new Card(title,content,MemberList.members[Int16.Parse(person)],Sizes.L));
                    break;
                }
                case "5":
                {
                    CardList.cardsTodo.Add(new Card(title,content,MemberList.members[Int16.Parse(person)],Sizes.XL));
                    break;
                }
                default: 
                {
                    Console.WriteLine("Lütfen geçerli bir değer giriniz.");
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine("Hatalı girişler yaptınız!");
        }
       
    }
}