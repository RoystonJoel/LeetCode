public class Solution {
    public int RomanToInt(string s) {
        char[] c = s.ToCharArray();
        int num = 0;
        for(int i=0; i < s.Length; i++)
        {
            char nxt_c = (i+1 < s.Length) ? c[i+1] : ' ';
            if((c[i] == 'I') && (nxt_c == 'V' || nxt_c == 'X')){
            num += subtract(nxt_c,c[i]);
            i++;
            }else if((c[i] == 'X') && (nxt_c == 'L' || nxt_c == 'C')){
            num += subtract(nxt_c,c[i]);
            i++;
            }else if((c[i] == 'C') && (nxt_c == 'D' || nxt_c == 'M')){
            num += subtract(nxt_c,c[i]);
            i++;    
            } else {
                num += SymbolToValue(c[i]);
            }
        }
        return num;
    }

    public int subtract(char i, char j){
        return SymbolToValue(i)-SymbolToValue(j);
    }

    public int SymbolToValue(char s){
        switch (s) 
        {
        case 'I':
            return 1;
            break;
        case 'V':
            return 5;
            break;
        case 'X':
            return 10;
            break;
        case 'L':
            return 50;
            break;
        case 'C':
            return 100;
            break;
        case 'D':
            return 500;
            break;
        case 'M':
            return 1000;
            break;
        }
        return 0;
    }
}