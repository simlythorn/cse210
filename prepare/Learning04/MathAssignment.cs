using System;
namespace Library_demo
{
    public class MathAssignment: Assignment
    {
        private string _textbookSection = " ";
        private string _problems = " ";
        public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
            
        }
        public void SetHomeworkdList(string textbookSection, string problems) 
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }

        public string GetHomeworkList()
        {
            return $"Homework List: {_textbookSection} {_problems}";
        }
        
        
    }
}