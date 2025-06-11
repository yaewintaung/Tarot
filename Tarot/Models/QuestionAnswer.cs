using System;

namespace Tarot.Models;

public class QuestionAnswer
{
    public List<Questions> Questions { get; set; } = new List<Questions>();
    public List<Answer> Answers { get; set; } = new List<Answer>();
}
