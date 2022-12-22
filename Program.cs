// See https://aka.ms/new-console-template for more information
using System; 
namespace tictacproject 
{
    class program{

        static void Main(string[] args)
        {
            //local strings 
            String playerInput, userInput, computerPlayer,x;
            x = "X";
            Console.WriteLine("Welcome to the tik tac toe simulator!"); 
            Console.WriteLine("Would you like to be X or O?"); 
              playerInput = Console.ReadLine(); 
             Console.WriteLine("\n"); 

             //verify user is playing with correct pieaces 
              userInput = checkInput(playerInput); 
              //operator to msee if computer will be X or O 
             computerPlayer = userInput.Equals(x, StringComparison.OrdinalIgnoreCase) ? computerPlayer = "O" : computerPlayer = "X"; 
             Console.WriteLine("You will be playing as " + userInput + "and I as " + computerPlayer); 
             
        }




    //function to print board
       static void printBoard(){
            
           Console.WriteLine("___|__|___");
           Console.WriteLine("___|__|___");
           Console.WriteLine("   |  |   "); 
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