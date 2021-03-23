
/**
 * Created by mgreen14 on 12/27/17.
 */
namespace adv-java-animals.src.us.mattgreen{
    public class Teacher : Person, Talkable {
        private int age;

        public Teacher(int age, String name) {
            super(name);
            this.age = age;
        }

        public int getAge() {
            return age;
        }

        public void setAge(int age) {
            this.age = age;
        }

        
        public override String talk() {
            return "Don't forget to do the assigned reading!";
        }
    }
}
