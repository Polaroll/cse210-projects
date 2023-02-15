public class Journal
    {
        private List<Entry> _entry = new List<Entry>();
        private string _file;

        public void Write() 
        {
            Entry entry1 = new Entry();
            entry1.GeneratePrompt();
            entry1.GenerateDate();
            Console.WriteLine("");
            Console.WriteLine(entry1.ReturnPrompt());
            Console.WriteLine("");
            entry1.UpdateAnswer(Console.ReadLine());
            _entry.Add(entry1);
        }

        public void Display() 
        {
            foreach (Entry entry in _entry)
            {
                entry.Display();
                Console.WriteLine("");
            }
        }

        public void SaveToFile(string fileName) 
        {
            _file = fileName;
            foreach (Entry entry in _entry)
            {
                string date = entry.ReturnDate();
                string prompt = entry.ReturnPrompt();
                string answer = entry.ReturnAnswer();
                List<string> lines = new List<string> {date, prompt, answer};
                File.AppendAllLines(_file, lines);
            }
        }

        public void LoadFromFile(string fileName) 
        {
            _file = fileName;
            string[] lines = File.ReadAllLines(fileName);
            Console.WriteLine(lines.Count());
            for (int i = 0; i < lines.Count(); i = i + 3)
            {
                Entry entry1 = new Entry();
                entry1.UpdateDate(lines[i]);
                entry1.UpdatePrompt(lines[i+1]);
                entry1.UpdateAnswer(lines[i+2]);
                _entry.Add(entry1);
            }
        }
    }