public class Solution {
    /*public int Fib(int n) {
        
        if(n==0)
            return 0;
        if(n==1)
            return 1;
        return(Fib(n-1)+Fib(n-2));
         
    }*/
     public int Fib(int N) {
        if(N <= 0){
            return 0;
        }
        
        int a = 0, b = 1, c = 1;
        for(int i = 1; i < N; i++){
            c = a + b;
            a = b;
            b = c;
        }
        
        return c;
    }
}