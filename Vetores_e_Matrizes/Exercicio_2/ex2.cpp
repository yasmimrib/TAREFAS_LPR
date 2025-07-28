/*Exercício 2) VETOR: Construa um algoritmo
que leia 10 números inteiros. Depois
solicite para o usuário um número que ele
gostaria de pesquisar no vetor. Caso o
número exista no vetor, mostre em qual
posição (ou quais) ele aparece e quantas
ocorrências foram detectadas. 
*/

#include <iostream>
#include <vector>
        
using namespace std;

int main(){

    vector <int> numeros(10);
    int numeroPesquisa, ocorrencias = 0;
    cout << "Digite 10 numeros inteiros:" << endl;
    for(int i = 0; i < 10; i++){
        cin >> numeros[i];
    }
    cout << "Digite o numero que deseja pesquisar: ";
    cin >> numeroPesquisa;
    cout << "O numero " << numeroPesquisa << " aparece nas posicoes: ";
    for(int i = 0; i < 10; i++){
        if(numeros[i] == numeroPesquisa){
            cout << i << " ";
            ocorrencias++;
        }
    }
    if(ocorrencias > 0){
        cout << "\nTotal de ocorrencias: " << ocorrencias << endl;
    } else {
        cout << "\nNumero nao encontrado." << endl;
    }
    return 0;
}