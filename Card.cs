namespace ToDo;

public partial class Card
{
    private string title;
    private string content;
    private Members member;
    private Sizes size;

    public Card(string title, string content, Members member,Sizes size)
    {
        this.title = title;
        this.content = content;
        this.member = member;
        this.size=size;
    }


    public string Title { get => title; set => title = value; }
    public string Content { get => content; set => content = value; }
    public Members Member { get => member; set => member = value; }
    public Sizes Size { get => size; set => size = value; }
}
public enum Sizes
{
    XS=1,
    S=2,
    M=3,
    L=4,
    XL=5
}