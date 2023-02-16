public class Scripture
{
    private string _text;
    private List<Word> _words = new List<Word>{};
    private bool _isCompletelyHidden;

    public Scripture()
    {
        _isCompletelyHidden = false;
    }
    public Scripture(string text)
    {
        _text = text;
        _isCompletelyHidden = false;
    }

    public void SetText(string text)
    {
        _text = text;
    }
    public string GetText()
    {
        return _text;
    }
    public string[] SplitText()
    {
        string[] text = _text.Split(" ");
        return text;
    }
    public bool IsCompletelyHidden()
    {
        int wordsHidden = 0;
        int wordsInList = _words.Count();
        foreach (Word word in _words)
        {
            if (word.GetIsHidden())
            {
                wordsHidden = wordsHidden + 1;
            }
        }
        if (wordsHidden >= wordsInList)
        {
            _isCompletelyHidden = true;
        }
        return _isCompletelyHidden;
    }
    public void DisplayScripture(string[] reference)
    {
        string scripRef = "";
        if (reference.Count() < 5)
        {
            scripRef = reference[0] + " " + reference[1] + ":" + reference[2] + " ";
        }
        else
        {
            scripRef = reference[0] + " " + reference[1] + ":" + reference[2] + "-" + reference[3] + " ";
        }
        Console.Write(scripRef);
        foreach (Word word in _words)
        {
            if (word.GetIsHidden())
            {
                Console.Write(String.Concat(Enumerable.Repeat("_", word.GetWord().Count())));
            }
            else
            {
                Console.Write(word.GetWord());
            }
            Console.Write(" ");
        }
    }
    public void AddWords(Word word)
    {
        _words.Add(word);
    }
    public List<Word> GetWords()
    {
        return _words;
    }
    public void HideWords()
    {
        Random rnd = new Random();
        int num1 = rnd.Next(_words.Count()/6);
        int num2 = rnd.Next(_words.Count());
        int num3 = rnd.Next(_words.Count());

        int index = 0;

        foreach (Word word in _words)
        {
            if (index == num1)
            {
                if (word.GetIsHidden() == true)
                {
                    num1++;
                }
                word.Hide();
            }
            if (index == num2)
            {
                if (word.GetIsHidden() == true)
                {
                    num2++;
                }
                word.Hide();
            }
            if (index == num3)
            {
                if (word.GetIsHidden() == true)
                {
                    num3++;
                }
                word.Hide();
            }
            ++index;
        }
    }
}