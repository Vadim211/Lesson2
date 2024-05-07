namespace HomeWork2
{
    public class User
    {
        public enum Gender
        {
            Male, Female, Unknown
        }

        public Gender UserGender { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }

        public override string ToString()
        {
            string ageInfo = Age < 10 ? "I am a baby" : $"I am {Age} years old";
            return $"Hi, my name is {FirstName} {LastName}. {ageInfo}. I am {UserGender}.";
        }

        public User()
        {
            Age = 0;
        }
        public User(int age)
        {
            Age = age;
        }
    }
}
