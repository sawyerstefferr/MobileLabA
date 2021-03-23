
/**
 * Created by mgreen14 on 12/27/17.
 */
namespace adv-java-animals.src.us.mattgreen{
    public abstract class Pet {
        protected String name;

        public Pet(String name) {
            this.name = name;
        }

        public String getName() {
            return name;
        }
    }
 }