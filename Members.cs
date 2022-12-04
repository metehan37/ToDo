namespace ToDo;

public class Members
{
    private string name;
    private string teamname;
    public Members(string name, string teamname)
    {
        this.name = name;
        this.Teamname = teamname;
    }
    public string Name { get => name; set => name = value; }
    public string Teamname { get => teamname; set => teamname = value; }
}