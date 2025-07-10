public class Solution {
    public bool IsPalindrome(int x) {
        int orgnl = x;
        int reverserd = 0;
        if(x < 0){return false;}
        while(true)
        {
            int t = x % 10;
            reverserd = (reverserd * 10) + t;
            x = x / 10;

            if(x==0){
                break;
            }
        }
        return (reverserd==orgnl) ? true : false;
    }
}