using HealthyMe.Enums;

namespace HealthyMe
{
    public class HealthProfile
    {
        public string name;
        public int age;
        public Gender gender;
        public BodyFatPercent bodyFatPercent;

        public HealthProfile()
        {
            
        }

        public HealthProfile(string name, int age, Gender gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
}
