/*Exercício 2) C++
Leia 2 valores inteiros (A e B). Após, o
programa deve mostrar uma mensagem
"Sao Multiplos" ou "Nao sao Multiplos",
indicando se os valores lidos são múltiplos
entre si. Atenção: os números podem ser
digitados em ordem crescente ou
decrescente. */

#include <iostream>

using namespace std;

int main() {
    cout << "Insira um valor inteiro para 'A': ";
    int A;
    cin >> A;
    cout << "Insira um valor inteiro para 'B': ";
    int B;
    cin >> B;

    if ((A % B == 0) || (B % A == 0)) {
        cout << "Os números " << A << " e " << B << " são múltiplos entre si." << endl;
    } else {
        cout << "Os números " << A << " e " << B << " não são múltiplos entre si." << endl;
    }
      
}