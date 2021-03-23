

/**
 * Created by mgreen14 on 12/28/17.
 */
namespace adv-java-animals.src.us.mattgreen{
    public class Cat : Pet, Talkable {
        private int mousesKilled;

        public Cat(int mousesKilled, String name) {
            base(name);
            this.mousesKilled = mousesKilled;
        }

        public int getMousesKilled() {
            return mousesKilled;
        }

        public void addMouse() {
            mousesKilled++;
        }

        
        public override String talk() {
            return "Meow";
        }

        
        public override String toString() {
            return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
        }
    }
}
