public class Resume(){

    public string _name;
    public List<Job> _jobs = new List<Job>();
    public void printResume(){
        Console.WriteLine($"Name: {_name}\nWork Experience:");
        foreach (Job job in _jobs){
            job.Display();
        }
    }
}