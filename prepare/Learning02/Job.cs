public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display(){
        Console.WriteLine($"{_jobTitle} with {_company} from {_startYear} to {_endYear}");
    }
}