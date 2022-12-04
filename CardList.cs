namespace ToDo;

public class CardList{
    public static List<Card> cardsTodo=new List<Card>();
    public static List<Card> cardsInTodo=new List<Card>();
    public static List<Card> cardsDone=new List<Card>();

    public CardList()
    {
        Card card1=new Card("Futbol","Futbol 11 kişiyle oynanır.",MemberList.members[0],Sizes.L);
        Card card2=new Card("Basketbol","Basket 5 kişiyle oynanır.",MemberList.members[1],Sizes.M);
        Card card3=new Card("Voleybol","Voleybol 5 kişiyle oynanır.",MemberList.members[2],Sizes.S);
        Card card4=new Card("Hentbol","Hentbol 7 kişiyle oynanır.",MemberList.members[3],Sizes.XS);
        Card card5=new Card("Bilardo","Tek kişiyle oynanır.",MemberList.members[4],Sizes.XL);
        cardsTodo.Add(card1);
        cardsTodo.Add(card2);
        cardsInTodo.Add(card3);
        cardsInTodo.Add(card4);
        cardsDone.Add(card5);
    }
}