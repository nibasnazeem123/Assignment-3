using System; 
  
class Cs
{ 
    
public static void Main() 
{ 
    string s="Hello Welcome to Nest Digital"; 
    int count = 0; 

    for (int i = 0; i < s.Length; i++) 
        {
            if (s[i] == ' ') 
                count++; 
        } 
       
    
    Console.Write("Number of spaces = "+count); 

} 
} 
  
