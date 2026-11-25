using System;

namespace Discrete {
    public class Matrel
    {
        //O(N)
        static bool antireflexiva(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            for (int i = 0; i < tamanho; i++)
            {
                if (matriz[i, i] == 1)
                {
                    return false;
                }
            }
            return true;
        }
// SEPARAÇÃO ----------------------
          // O(N^2)
        static bool antisimetrica(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (matriz[i, j] == 1 && matriz[j, i] == 1 && i != j)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
// SEPARAÇÃO ----------------------
          // O(N)
        static bool reflexiva(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            for (int i = 0; i < tamanho; i++)
            {
                if (matriz[i, i] != 1)
                {
                    return false;
                }
            }
            return true;
        }
// SEPARAÇÃO ----------------------
        //  // O(N^2)
              static bool relacaototal(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (i != j && matriz[i, j] == 0 && matriz[j, i] == 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // SEPARAÇÃO ----------------------
        // O(N^2)
        static bool simetrica(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    if (matriz[i, j] != matriz[j, i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
            
// SEPARAÇÃO ----------------------
        //  // O(N^3)
            static bool transitiva(int[,] matriz)
        {
            int tamanho = matriz.GetLength(0);
            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    for (int k = 0; k < tamanho; k++)
                    {
                        if (matriz[i, j] == 1 && matriz[j, k] == 1 && matriz[i, k] != 1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }
// TENTATIVA DE REDUZIR O TEMPO DESSA BOMBA (O(N^3) VSF COMO TU PROGRAMOU ALGO TAO BURRO MLKKKKKKJJJ) 
   static bool transitiva(int[,] matriz){
  int tamanho = matriz.GetLength(0);
  List<(int X, int Y)> pontos_true = new List<(int, int)>;

         for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                { 
                    if (matriz[i,j] == 1){
                        pontos_true.Add((i,j));
                    }
                }
         }

       for (int i=0, i<pontos_true.count; i++){
        if ( (pontos_true.X==1 && pontos_true.Y==1) &&  //ver como terminar essa verificaçao   
            ){
            return false;
       }
           return true;
        }
// SEPARAÇÃO ----------------------
        static bool relacaoequivalente(int[,] matriz)
        {
            return simetrica(matriz) && reflexiva(matriz) && transitiva(matriz);
        }
// SEPARAÇÃO ----------------------
        static bool relacaoequivalenteparcial(int[,] matriz)
        {
            return relacaoequivalente(matriz) && relacaoparcial(matriz);
        }
// SEPARAÇÃO ----------------------
        static bool relacaoequivalenteparcialtotal(int[,] matriz)
        {
            return relacaoequivalente(matriz) && relacaoparcial(matriz) && relacaototal(matriz);
        }
// SEPARAÇÃO ----------------------
        static bool relacaoequivalentetotal(int[,] matriz)
        {
            return relacaoequivalente(matriz) && relacaototal(matriz);
        }
// SEPARAÇÃO ----------------------
        static bool relacaoparcial(int[,] matriz)
        {
            return reflexiva(matriz) && antisimetrica(matriz) && transitiva(matriz);
        }
// SEPARAÇÃO ----------------------
        static bool relacaoparcialtotal(int[,] matriz)
        {
            return relacaoparcial(matriz) && relacaototal(matriz);
        }
// SEPARAÇÃO ----------------------
        static bool relacaoparcialtotalequivalente(int[,] matriz)
        {
            return relacaoparcial(matriz) && relacaototal(matriz) && relacaoequivalente(matriz);
        }

  
    }

}
