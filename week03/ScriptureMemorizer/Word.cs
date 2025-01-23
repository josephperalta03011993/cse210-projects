public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        // if true then show blank ___ else display the value of text
        if (_isHidden)
        {
            return new string('_', _text.Trim().Length);
        }
        else 
        {
            return _text;
        }
    }
}