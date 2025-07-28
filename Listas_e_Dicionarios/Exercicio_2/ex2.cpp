/*Exercício 2) RESOLVA EM C++
Construa uma lista de 100 números
aleatórios
Crie um algoritmo que coloque-os em
ordem crescente e imprima-os
A partir dessa lista ordenada, remova
todos os números pares e imprima a lista
novamente.
Por fim imprima quais números se
repetem, se existe algum número
repetido.*/

#include <iostream>
#include <list>
#include <algorithm>
#include <random>
#include <locale>
#include <thread> 
#include <chrono> 

using namespace std;

int main() {
    setlocale(LC_ALL, "Portuguese");
    random_device rd;
    uniform_int_distribution<> dist(1, 100);

    list<int> numeros;
    for (int i = 0; i < 100; ++i) {
        numeros.push_back(dist(rd));
    }

    numeros.sort();

    cout << "Lista ordenada:\n";
    for (int n : numeros) cout << n << " ";
    cout << "\n";
    system("pause"); // Pausa após exibir a lista ordenada

    numeros.remove_if([](int n){ return n % 2 == 0; });

    cout << "\nLista sem pares:\n";
    for (int n : numeros) cout << n << " ";
    cout << "\n";
    system("pause"); // Pausa após exibir a lista sem pares

    cout << "\nNúmeros repetidos:\n";
    bool temRepetido = false;
    if (!numeros.empty()) {
        auto it = numeros.begin();
        auto prev = it++;
        int count = 1;
        for (; it != numeros.end(); ++it) {
            if (*it == *prev) {
                ++count;
            } else {
                if (count > 1) {
                    cout << *prev << " aparece " << count << " vezes\n";
                    temRepetido = true;
                }
                count = 1;
            }
            prev = it;
        }
        
        if (count > 1) {
            cout << *prev << " aparece " << count << " vezes\n";
            temRepetido = true;
        }
    }
   if (!temRepetido) cout << "Nenhum número repetido.\n";

    return 0;
}