using System;

namespace QuestionFour
{
    public class AccessControl : IPrototype
    {
        public string Access { get; set; }
        public string ControlLevel { get; set; }

        object ICloneable.Clone()
        {
            return Clone();
        }

        public AccessControl(string controlLevel, string access)
        {
            ControlLevel = controlLevel;
            Access = access;
        }
        public AccessControl Clone()
        {
            return (AccessControl) MemberwiseClone();
        }
    }
}