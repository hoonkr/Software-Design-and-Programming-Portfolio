namespace QuestionFour
{
    public class User
    {
        public string UserName { get; set; }
        public string Level { get; set; }
        public AccessControl AccessControl { get; set; }

        public User(string name, string level, AccessControl userAccessControl)
        {
            UserName = name;
            Level = level;
            AccessControl = userAccessControl;
        }

        public override string ToString()
        {
            return "Name: " + UserName + ", Level" + Level + ", Access Control Level:" + AccessControl.ControlLevel +
                   ", Access: " + AccessControl.Access;
        }
    }
}