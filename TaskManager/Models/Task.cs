namespace Classes;

public class Task
{
    public Task(string id, string task_name, string priority, string description, string created_at)
    {
        this.id = id;
        this.task_name = task_name;
        this.priority = priority;
        this.description = description;
        this.created_at = created_at;


    }
    public string id { get; } 
    public string task_name { get; set; }
    public string priority { get; set; }
    public string description { get; set; } 
    public string created_at { get;  }

}