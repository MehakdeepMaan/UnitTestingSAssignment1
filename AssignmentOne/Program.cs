using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AssignmentOne
{
    class Program
    {
      
        public static int ValidateMenuSelection()
        {
            // declare and initializing variable
            string inputString="";
            int input = 0;
            bool validMenuSelect = false;
            // using while for selecting an option from displying optons
            while(!validMenuSelect)
            {
                Console.WriteLine("1 =Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle length");
                Console.WriteLine("3 = Get Rectangle width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Perimeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit");

                Console.WriteLine("Please select an option, by entering a value");
                inputString = Console.ReadLine();
                int.TryParse(inputString, out input);

                 if(!(input >=1 && input <= 7))
                {
                    Console.WriteLine("That is not a valid menu option, please try again to select a valid option ");
                }else
                {
                    validMenuSelect = true;
                }

            }
            return input;
        }
        // using method with parameters
        public static int ValidateUserInput(string rectside)
        {
            int value = 0;
            bool isValid = false;
            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {rectside} of your rectangle: ");
                string inputString = Console.ReadLine();
                Console.WriteLine();

                bool result = int.TryParse(inputString, out value);
                if (result == false)
                {
                    Console.WriteLine("It is not a valid input, please try again with valid value");

                }
                else if (value < 0)
                {
                    Console.WriteLine("Value cannot be less than 0 , please try again with valid value ");

                }else
                {
                    isValid = true;
                    Console.WriteLine($"The {rectside} of your rectangle is now {value}\n");
                }
                
            }
            return value;
        }
        static void Main(string[] args)
        {
            //creating an object of recatngle class
            Rectangle r = new Rectangle();
            bool validRectangleSelect = false;
            
            int selection;
            //using while for checking that is user selecting the correct option or not
            while (!validRectangleSelect)
            {
             
                int length;
                int width;
                length = ValidateUserInput("length");
                if (length==0) {
                    validRectangleSelect = false;
                    continue;
                }
                width = ValidateUserInput("width");
                if (width == 0)
                {
                    validRectangleSelect = false;
                    continue;
                }
                validRectangleSelect = true;

                // displying the length and the width of rectangle
                Console.WriteLine("The length and width of Rectangle are {0} and {1}.",length,width);
                Rectangle customRectangle = new Rectangle(length, width);
                r = customRectangle;

                    
                

            }
            selection = ValidateMenuSelection();
            
            while (selection !=7)
            {
                int result =0;
                //using switch  for performing the unique task with each case
                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"length of Rectangle is:=> {r.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("length");
                        r.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"width of Rectangle is :=> {r.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("setwidth");
                        r.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The result of  {r.GetLength() *2} + {r.GetWidth() *2} is:=> {r.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The result of {r.GetLength()} * {r.GetWidth()} is:=> {r.GetArea()}\n");
                        break;
                    case 7:                 
                        break;
                    default:
                        break;

                }

                selection = ValidateMenuSelection();
            }
        }
    }
}
