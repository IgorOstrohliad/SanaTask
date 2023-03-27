namespace SanaTask1.Models
{
    public class User
    {
        protected string name;
        public string Name {
            get { return name; }
            set { name = "Hello, " + value; }
        }
    }
}
