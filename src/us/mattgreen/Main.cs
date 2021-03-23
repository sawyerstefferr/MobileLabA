using System.Collections;
namespace adv-java-animals.src.us.mattgreen{
    public class Main {

        public static void main(string[] args) {
            ArrayList zoo = new ArrayList();
            GatherZoo gz=new GatherZoo();
            // Lines to Replace Begin Here
            boolean adding=true;
            while(adding){
                Talkable thing=gz.newAnimal();
                if(thing==null){
                    adding=false;
                }
                else{
                    zoo.add(thing);
                }
            }
            // End Lines to Replace

            for (Talkable thing : zoo) {
                printOut(thing);
            }

            String line;
            while ((line = indata.fileReadLine()) != null) {
                Console.WriteLine(line);
            }
        }

        public static void printOut(Talkable p) {
            Console.WriteLine(p.getName() + " says=" + p.talk());
        }
    }
}
