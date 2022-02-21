# Looking for Bananas in the Monkeys island

```bash
Given a Jungle in the middle of an island of n * m dimensions. Each field in this jungle contains a
positive integer which is the amount of bananas that exist in that field. Initially the monkey is at first
column but can be at any row. The monkey can move only (right->,right up /,right down\) from a given
cell. Find out the maximum amount of bananas they can collect.

Input/Output Examples:

Input : mat[][] = {{1, 3, 3},
                   {2, 1, 4},
                   {0, 6, 4}};
Output : 12
{(1,0)->(2,1)->(2,2)}

Input: mat[][] = { {1, 3, 1, 5},
                   {2, 2, 4, 1},
                   {5, 0, 2, 3},
                   {0, 6, 1, 2}};
Output: 16
(2,0) -> (1,1) -> (1,2) -> (0,3) OR (2,0) -> (3,1) -> (2,2) -> (2,3)

Input: mat[][] = {{10, 33, 13, 15},
                  {22, 21, 04, 1},
                  {5, 0, 2, 3},
                  {0, 6, 14, 2}};
Output: 83
```

**Tecnologias utilizadas:**
```bash
✓ .NET 5 (C#)
✓ Console Application
✓ MSTest (UnitTest)
```

**Sobre o desenvolvimento:**
```bash
* Primeiro eu pesquisei sobre notação Big O e as complexidades. 
Foi bacana para entender e conhecer as complexidades do tempo e como isso nos permite criar algoritmos melhores. 
Levando em consideração isso, essa solução é O(m*n).
* Depois peguei uma matriz de exemplo e fiz um exercício de contagem "na mão" 
para entender como chegava no valor final do dado de saída (output).
No caso eu usei a matriz: 
```
![image](https://user-images.githubusercontent.com/13911223/154876804-e85c5d21-a824-45a0-8d52-dff2d1b2531a.png)
```bash
Então entendi o "fluxo" do melhor caminho até chegar no total de 12 bananas.

O vídeo abaixo me ajudou a entender como funciona essa programação dinâmica:
https://www.youtube.com/watch?v=6rqcqUyyXvM

* E por fim, adicionei alguns testes de unidade para confirmar que o algoritmo estava funcionando.
``` 
