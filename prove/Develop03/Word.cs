class Word
{
    private string _text;

    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _isHidden ? "___" : _text;
    }
    public override string ToString()
    {
        return GetDisplayText();
    }
}