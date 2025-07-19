using System;

public class Entry
{
    private string _prompt;
    private string _response;
    private DateTime _date;
    
    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
    }
     public Entry(string prompt, string response,string date)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Parse(date);
    }
    public string StoreEntry()
    {
        return $"{_prompt},{_response},{_date}";
    }


    public string DisplayEntry()
    {
        return $"{_date} - {_prompt}\n{_response}\n";
    }
}



