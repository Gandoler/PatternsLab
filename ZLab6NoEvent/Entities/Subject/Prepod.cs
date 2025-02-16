namespace ZLab6.Entities;

public class Prepod 
{
    
    public string Name { get; }

    public Prepod(string name)
    {
        Name = name;
    }

    

    public void SubmitReport()
    {
        
    DB.Instance.AddReport();   
    }
}