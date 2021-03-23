
namespace adv-java-animals.src.us.mattgreen{
    public class GatherZoo {
        public Talkable newAnimal(){
            Console.WriteLine("What kind of animal would you like to add?\n1) Cat\n2) Dog\n3) Teacher\n4) Done Adding");
            string choice=Console.ReadLine();
            switch(choice){
                case "1":
                    Console.WriteLine("How many mice has your cat killed?");
                    int mice = Int32.Parse(Console.ReadLine);
                    Console.WriteLine("What's your cat's name?");
                    string name=Console.ReadLine();
                    return new Cat(mice,name);
                break;
                case "2":
                    Console.WriteLine("Is your dog friendly? y/n");
                    string friendlyStr=Console.ReadLine();
                    boolean friendly;
                    if(friendlyStr=="y"){
                        friendly=true;
                    }
                    else if(friendlyStr=="n"){
                        friendly=false;
                    }
                    Console.WriteLine("What's your dog's name?");
                    string name=Console.ReadLine();
                    return new Dog(friendly,name);
                break;
                case "3":
                    Console.WriteLine("How old is your teacher?");
                    int age = Int32.Parse(Console.ReadLine);
                    Console.WriteLine("What's your teacher's name?");
                    string name=Console.ReadLine();
                    return new Teacher(age,name);
                break;
                case "4":
                    return null;
                break;
            }
            return null;
        }
    }
}