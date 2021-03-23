

/**
 * Created by mgreen14 on 12/27/17.
 */
namespace adv-java-animals.src.us.mattgreen{
    public class Dog : Pet, Talkable {
        private boolean friendly;
        public Dog(boolean friendly, String name) {
            base(name);
            this.friendly = friendly;
        }
        public boolean isFriendly() {
            return friendly;
        }        
        public override String talk() {
            return "Bark";
        }

        public override String toString() {
            return "Dog: " + "name=" + name + " friendly=" + friendly;
        }
    }
}