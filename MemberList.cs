namespace ToDo;

public class MemberList{
    public static List<Members> members=new List<Members>();

    public MemberList()
    {
        Members member1= new Members("Metehan","Futbol");
        Members member2= new Members("Ömer","Basket");
        Members member3= new Members("Akın","Voleybol");
        Members member4= new Members("Ahmet","Hentbol");
        Members member5= new Members("Semih","Bilardo");
        
        members.Add(member1);
        members.Add(member2);
        members.Add(member3);
        members.Add(member4);
        members.Add(member5);
    }
}