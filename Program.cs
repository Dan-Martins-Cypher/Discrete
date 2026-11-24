using System;

namespace Discrete {
    public class Matrel
    {
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

        static bool relacaoequivalente(int[,] matriz)
        {
            return simetrica(matriz) && reflexiva(matriz) && transitiva(matriz);
        }

        static bool relacaoequivalenteparcial(int[,] matriz)
        {
            return relacaoequivalente(matriz) && relacaoparcial(matriz);
        }

        static bool relacaoequivalenteparcialtotal(int[,] matriz)
        {
            return relacaoequivalente(matriz) && relacaoparcial(matriz) && relacaototal(matriz);
        }

        static bool relacaoequivalentetotal(int[,] matriz)
        {
            return relacaoequivalente(matriz) && relacaototal(matriz);
        }

        static bool relacaoparcial(int[,] matriz)
        {
            return reflexiva(matriz) && antisimetrica(matriz) && transitiva(matriz);
        }

        static bool relacaoparcialtotal(int[,] matriz)
        {
            return relacaoparcial(matriz) && relacaototal(matriz);
        }

        static bool relacaoparcialtotalequivalente(int[,] matriz)
        {
            return relacaoparcial(matriz) && relacaototal(matriz) && relacaoequivalente(matriz);
        }

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
    }

}
