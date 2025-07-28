/*Exercício 1)
Construa uma função em C++ que retorne
o reverso de um número inteiro.*/

#include <iostream>
#include <locale>

using namespace std;

int reverso = 0;
int numero;

void funcaoInverso(){

    while (numero != 0) {
        int digito = numero % 10;
        reverso = reverso * 10 + digito;
        numero /= 10;
    }
}
int main(){
    setlocale(LC_ALL, "Portuguese");
    
    cout << "Digite um número inteiro: ";
    cin >> numero;

    funcaoInverso();

    cout << "O reverso do número é: " << reverso << endl;

    return 0;
}