using System.Collections.Generic;
using System;
using System.Drawing;

public class CgUtils {
    
    public static float[,] mult(float[,] A, float[,] B) {
        float[,] C = new float[A.GetLength(0),B.GetLength(1)];
        for(int i=0; i<A.GetLength(0); i++) {
            for(int j=0; j<B.GetLength(1); j++) {
                for(int k=0; k<B.GetLength(0); k++) {
                    C[i,j] = C[i,j] + A[i,k] * B[k,j]; 
                }
            }
        }
        return C;
    }
    
    public static void show(float[,] A){
        for(int i=0; i<A.GetLength(0); i++) {
            Console.WriteLine();
            for(int j=0; j<A.GetLength(1); j++) {
                Console.WriteLine(A[i,j] + "  ");
            }
        }
        Console.WriteLine();
    }
    
    public static void main(String[] args){
        
        float[,] A = {
            {1, 2, 1},
            {3, 2, 4}
        };
        
        float[,] B = {
            {2, 4, 2, 1},
            {1, 5, 3, 3},
            {1, 1, 6, 2}
        };
        
        float[,] C = mult(A, B);
        
        show(C);
        
    } //A(2, 3) x B(3, 4) = C(2, 4)
}
