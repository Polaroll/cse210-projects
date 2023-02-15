public class Entry
    {
        private string _prompt;
        private string _answer;
        private string _date;

        public void Display() 
        {
            Console.Write("Date: " + _date);
            Console.WriteLine(" Prompt: " + _prompt);
            Console.WriteLine(_answer);
        }

        public void GeneratePrompt()
        {
            _prompt = new Prompt().RandomPrompt();
        }
        public void UpdatePrompt(string prompt)
        {
            _prompt = prompt;
        }
        public string ReturnPrompt()
        {
            return _prompt;
        }

        public void UpdateAnswer(string answer)
        {
            _answer = answer;
        }
        public string ReturnAnswer()
        {
            return _answer;
        }

        public void GenerateDate()
        {
            _date = DateTime.Now.ToShortDateString();
        }
        public void UpdateDate(string date)
        {
            _date = date;
        }
        public string ReturnDate()
        {
            return _date;
        }
    }