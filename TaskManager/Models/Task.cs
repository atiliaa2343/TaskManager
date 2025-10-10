namespace Classes;

public class Task
{
   

    public Task(string name, string priority, string description, string created_at, string due_date)
    {
        this.name = name;
        this.priority = priority;
        this.description = description;
        this.created_at = created_at;
        this.due_date = due_date;


    }
    public string name { get; set; }
    public string priority { get; set; }
    public string description { get; set; }  
    public string due_date { get; set; }
    public string created_at { get; set; }

}