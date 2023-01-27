using System;
public class Prompt
{
    string _prompt;
    List<string> questions = new List<string>()
  {
    "Who was the most interesting person I interacted with today?",
    "What was the best part of my day?",
    "How did I see the hand of the Lord in my life today?",
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?",
    "Describe a place where you felt happiest.",
    "Write a letter to someone that you always want to thank but have never had the chance to do so.",
    "What was the most peaceful moment during the day?",
    "Describe something you learned today that you didn't know before.",
    "What steps did you take today towards a goal you're working on?",
    "What is something that made you laugh today?"
  };

    public string GetPrompt()
    {
        Random randomNum = new Random();
        int listSize = questions.Count;
        int rndIndex = randomNum.Next(0, listSize);
        _prompt = questions[rndIndex];
        return _prompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(_prompt);
        Console.Write("> ");

    }

}