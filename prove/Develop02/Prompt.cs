public class Prompt
    {
        private List<string> _prompts = new List<string>()
            {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                "How did I see the hand of the Lord in my life today?",
                "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?",
                "What things did I accomplish today?",
                "Am I proud of my actions today? Why or why not?",
                "What is one new thing that I learned today?",
                "After today's events, what things do I want to accomplish tomorrow?",
                "What was the funniest event of today?"             
            };

        public string RandomPrompt()
        {
            Random rnd = new Random();
            int num = rnd.Next(_prompts.Count());
            return _prompts[num];
        }
    }