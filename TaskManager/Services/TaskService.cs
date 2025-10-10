namespace Classes;

public class Task_Methods
{
    public async static void Add_Task(string task_name, string task_priority, string task_description, string task_created, string task_due)
    {
        Task_Validation.Validate_Task(task_name, task_priority, task_description,task_created,task_due);

        Task newTask = new(task_name, task_priority, task_description, task_created, task_due)
        {
            name = task_name,
            priority = task_priority,
            description = task_description,
            created_at = task_created,
            due_date = task_due,




        };
    } 

    public async static void List_Task(string task_name, string priority, string description)
    {

        
    }

    public async static void Delete_Task(string task_name, string priority, string description)
    {


    }  
    
    public async static void Update_Task(string task_name, string priority, string description)
    {

        
    } 

}