public class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public Word(string word, bool isHidden)
    {
        _word = word;
        _isHidden = isHidden;
    }

    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public string GetWord()
    {
        return _word;
    }
    public bool GetIsHidden()
    {
        return _isHidden;
    }
}