
public class Tamagotchi
{
    private int _hunger;
    private int _boredom;
    private List<string> _words = ["Hi"];
    private bool _isAlive;
    public string _name;


    public void start()
    {
        _hunger = 0;
        _boredom = 0;
        _words = ["Hi"];
        _isAlive = true;
        _name = Console.ReadLine();
    }


    public void Feed()
    {
        _hunger -= Random.Shared.Next(1, 5);
        
        Tick();
        if (_hunger < 0)
        {
            _hunger = 0;
        }
    }
    public void Hi()
    {
        int x = Random.Shared.Next(0, _words.Count);
        string word = _words[x];
        Console.WriteLine(word);
        ReduceBoredom();
        Tick();
    }
    public void Teach(string word)
    {
        
        _words.Add(word);
        ReduceBoredom();
        Tick();
        
        
    }
    public void Tick()
    {
        _hunger ++;
        _boredom ++;
        if(_hunger > 10|| _boredom > 10)
        {
            _isAlive = false;

        }
    }
    public void PrintStats()
    {
        Console.WriteLine($"""
             info;
        hunger:  {_hunger}
        Boredom: {_boredom}
        Alive:   {GetAlive()}
        """);
        Tick();
    }
    public bool GetAlive()
    {
        
        return _isAlive;
    }
    private void ReduceBoredom()
    {
        _boredom -= Random.Shared.Next(1, 5);
        if (_boredom < 0)
        {
            _boredom = 0;
        }
    }
    

} 
