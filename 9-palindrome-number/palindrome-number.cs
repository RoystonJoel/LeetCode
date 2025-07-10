public class Solution {
    public bool IsPalindrome(int x) {
        int orgnl = x;
        int reverserd = 0;
        if(x < 0){return false;}
        while(true)
        {
            Console.WriteLine("x: "+x);

            int t = x % 10;
            reverserd = (reverserd * 10) + t;
            x = x / 10;

            if(x==0){
                break;
            }
        }
        Console.WriteLine("r: "+reverserd);
        return (reverserd==orgnl) ? true : false;
    }
}