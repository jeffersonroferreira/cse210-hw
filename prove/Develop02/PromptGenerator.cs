public class PromptGenerator
{
   public List<string> _prompts = new List<string>(){
      "What was the best part of your day?",
      "Write about an experience where you felt the spirit with you today:",
      "Who was the most interesting person you interacted with today?",
      "Write about something that happened for which you are grateful today:",
      "If you had one thing you could do over today, what would it be?",
      "What was the strongest emotion you felt today?",
   };

   public Random rng = new Random();

   public string GetRandomPrompt()
   {
      int index = rng.Next(_prompts.Count);
      return _prompts[index];
   }
}