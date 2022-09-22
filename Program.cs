using System;  
public class calculator
{  
    public static void Main() 
   {

   
   double num1;
   double num2;
   int menu;
   
   while(true){
   
           Console.Write("\n\n");
           Console.Write("A menu driven program for a calculator:\n");
           Console.Write("------------------------------------------------");
           Console.Write("\n\n");


  

  
    Console.Write("\nHere are the options :\n");
    Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
    Console.Write("\nInput your choice :");
    menu = Convert.ToInt32(Console.ReadLine());
    

    switch(menu) {

      case 1:
       GetInputFromUser(out num1, out num2);
       Console.Write("The Addition of {0}  and {1} is : {2}\n",num1,num2, Addition( num1,num2 ));
       
        //Addition
       
        
        break;
        
      case 2:

       GetInputFromUser(out num1, out num2);
       //Substraction
       Console.Write("The Substraction of {0} and {1} is: {2}\n",num1,num2,Substraction(num1, num2 ));
      
        
        break;
        
      case 3:

        GetInputFromUser(out num1, out num2);
        //Multiplication
        Console.Write("The Multiplication of {0} and {1} is: {2}\n",num1,num2,Multiplication(num1,num2));
        
        
        break;  
      
       case 4:
        GetInputFromUser(out num1, out num2);
        //Division
        Division(num1,num2 );
       
        
          
        Console.Write("\n");
        
        break;
        
      case 5: 
       Console.Write("Exiting program" );
       System.Environment.Exit(0);
         
      
        break; 
        
      default:
        Console.Write( "Input correct option\n"+ menu );
       
        
        break; 
    }
    Console.WriteLine("Any key return to the menu\n"  );
    Console.ReadKey();
  }
} 

// user input
public static void GetInputFromUser(out double num1, out double num2){
   Console.WriteLine("Enter the first integer number:");
       num1 = Convert.ToDouble(Console.ReadLine());
       Console.Write("Enter the second integer number:");
       num2 = Convert.ToDouble(Console.ReadLine());
}
  public static double Addition(double num1,double num2 ) { 
      
       return num1 + num2 ; 
      
 } 
 public static double Substraction(double num1,double num2 ) { 
          

       return num1 - num2 ; 
   } 
  public static double Multiplication(double num1,double num2 ) { 
          

       return num1*num2 ; 

   } 
   public static double Division(double num1,double num2 ){ 
      
        
      
       if( num2==0) {
          Console.Write( "You are not allowed divide by 0 " );
             
       } else {

        Console.Write("The Division of {0}  and {1} is : {2}\n",num1,num2, num1/num2);
              
     } 
        return num1/num2;
       
    }  
     

} 
