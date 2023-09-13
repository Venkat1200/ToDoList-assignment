using System.Security.Cryptography.X509Certificates;

var todos = new List<string>();



Console.WriteLine("Hello Welcome to ToDo app");

bool shouldExit = false;
while (!shouldExit)
{

    Console.WriteLine("[S]ee all Todos");
    Console.WriteLine("[A]dd a Todo");
    Console.WriteLine("[R]emove a Todo");
    Console.WriteLine("[E]xit");



    string userInput = Console.ReadLine();

    switch (userInput)
    {
        case "S":
        case "s":
            seeAlltodos();
           
            break;

        case "A":
        case "a":

            Addatodo();

            break;


        case "R":
        case "r":
            deleteaTodo();
            break;


        case "E":
        case "e":
            shouldExit = true;
            break;

        default:
            Console.WriteLine("Please enter the valid Response");
            break;


    }
}



    Console.ReadKey();

void seeAlltodos()
{
    foreach (var todo in todos)
    {
        if (todos.Count == 0)
        {
             Notods();
            return;
        }

            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{todos[i]}");
            }

        
    }
}

void Addatodo()


{
    string Description;
    do

    {
        Console.WriteLine("Enter the Description");
        Description = Console.ReadLine();
    }

    while (!isvaliddescription(Description));

    todos.Add(Description);
      


    
}







void deleteaTodo()
{
    if (todos.Count == 0)
    {
        Notods();
        return;
    }

    bool isIndexValid = false;
    while (!isIndexValid)
    {

        Console.WriteLine("Select the Todos to remove from the List");
        seeAlltodos();
        var userInput = Console.ReadLine();

        if(userInput == "")
        {
            Console.Write("Index ivvu raa Gandu");
            continue;   
        }

        if (int.TryParse(userInput, out int index) &&
            index >= 1 && index< todos.Count)
        {
            var todotobeRemoved = todos[index -1];
            todos.RemoveAt(index-1);
            isIndexValid = true;

        }
        {
            Console.WriteLine("The given Index is not Valid");
        }
        

    }

}

bool isvaliddescription(string Description)
{

    if (Description == "")
    {
        Console.WriteLine("Description cannot be Empty");
        return false;
    }
    else if (todos.Contains(Description))
    {

        Console.WriteLine("Description Should be Unique");
        return false;
    }
    return true;

}


static void Notods()
{
    Console.WriteLine("There are no Todos to Do");
}