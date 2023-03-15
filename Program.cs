// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System; 
namespace tictacproject 
{
    class Point
    {
        public int x{get; set; }
        public int y {get; set;}
        public Point(int x, int y){
            this.x = x;  
            this.y = y; 
        }
    }
    class program{

        static void Main(string[] args)
        {
            //local strings 
            String playerInput, userInput, computerPlayer,x, gameChoice;
            x = "X";
            //array for answers 
            String[] fillOutBoard = new String[9]; 
            Console.WriteLine("Welcome to the tik tac toe simulator!"); 
            Console.WriteLine("Would you like to be X or O?"); 
              playerInput = Console.ReadLine(); 
             Console.WriteLine("\n"); 

             //verify user is playing with correct pieaces 
              userInput = checkInput(playerInput); 
              //operator to msee if computer will be X or O 
             computerPlayer = userInput.Equals(x, StringComparison.OrdinalIgnoreCase) ? computerPlayer = "O" : computerPlayer = "X"; 
             Console.WriteLine("You will be playing as " + userInput + " and I as " + computerPlayer); 
             //printBoard(); 

             Console.WriteLine("Lets start!"); 

             Random rnd = new Random();
             int randomInt = rnd.Next(1, 3);
            if (randomInt == 1) {
                Console.WriteLine("Computer goes first.");
            } else {
                Console.WriteLine("Player goes first.");
               Point firstMove =  playerTurn();
            }
            
            int counter = 0;
            while(counter != 9){
                
            }


        }





    static Point playerTurn(){
         while (true) {
        Console.Write("Enter a point in the format of x,y (between 1 and 3): ");
        string gameChoice = Console.ReadLine();
        string[] coordinates = gameChoice.Split(',');
        int x = int.Parse(coordinates[0]);
        int y = int.Parse(coordinates[1]);

        if (x >= 1 && x <= 3 && y >= 1 && y <= 3) {
            Point point = new Point(x, y);
            return point;
        }

        Console.WriteLine("Invalid input. Please enter values between 1 and 3.");
    }
    }

    //function to print board
       static void printBoard(){
           Console.WriteLine("___|__|___");
           Console.WriteLine("___|__|___");
           Console.WriteLine("   |  |   "); 
        }

        
        static Point checkMove(){
             while (true) {
        Console.Write("Enter a point in the format of x,y (between 1 and 3): ");
        string gameChoice = Console.ReadLine();
        string[] coordinates = gameChoice.Split(',');
        int x = int.Parse(coordinates[0]);
        int y = int.Parse(coordinates[1]);

        if (x >= 1 && x <= 3 && y >= 1 && y <= 3) {
            Point point = new Point(x, y);
            Console.WriteLine("Point created: ({0}, {1})", point.x, point.y);
            return point;
        }

        Console.WriteLine("Invalid input. Please enter values between 1 and 3.");
    }
        }


    //Function to verify user input 
        static String checkInput(String argument){
            //local variables
            String test = argument; 
            String x = "X"; 
            String o = "O"; 
            //seeing if user input is null 
            if(String.IsNullOrEmpty(test)){
                while(String.IsNullOrEmpty(test)){
                Console.WriteLine("Enter a Value to play the game!");
                test = Console.ReadLine(); 
                }
            }
            //testing that user inpout is correct length
            if(test.Length > 1){
                while(test.Length > 1){
                    Console.WriteLine("Player cant play with " + test); 
                    Console.WriteLine("Please try again"); 
                    test = Console.ReadLine(); 
                } 
            }

            if(test.Equals(x, StringComparison.OrdinalIgnoreCase)){
                return test; 
            }
            else if(test.Equals(o, StringComparison.OrdinalIgnoreCase)){
                return test; 
            }
            else{
                    Console.WriteLine("Tic Tac Toe is played with X and O"); 
                    test = Console.ReadLine(); 
                //recursion to validate 
                test = checkInput(test); 
            
            }           
            //return the real value to the user
            return test; 
        }
    }
}
