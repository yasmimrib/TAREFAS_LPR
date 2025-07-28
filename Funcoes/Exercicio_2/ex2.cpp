/*Exercício 2)
Construa um algoritmo em C++ que agrupe
em funções os exercícios 1, 3 e 4 da tarefa
de estruturas de repetições. Cada exercício
deve estar contido em uma função
separada. Defina os parâmetros de modo
eficiente e generalista. Construa um menu
na função main. Reuse os códigos das suas
respostas da tarefa no GitHub ou a
resposta do professor postada no AVA*/


#include <iostream>
#include <locale>
#include <random>
using namespace std;

void funcaoex1(){
    setlocale(LC_ALL, "pt_BR.utf8"); //Para usar acentuaçãO
    
    int quantidade;
    cout << "Digite a quantidade de números a serem inseridos: ";
    cin >> quantidade;

    int soma = 0;
    int contador = 0;
    
    while (quantidade > 0) {
        int numero;
        cout << "Digite um número: ";
        cin >> numero;

        if (numero % 2 == 0) {
            soma += numero;
            contador++;
        }

        quantidade--;
    }

    if (contador > 0) {
        double media = static_cast<double>(soma) / contador;
        cout << "A média dos números pares é: " << media << endl;
    } else {
        cout << "Nenhum número par foi digitado." << endl;
    }
    }

    void funcaoex3(){
        setlocale(LC_ALL, "pt_BR.utf8"); // Para usar acentuação
     
        int soma = 0;
    
        // Utilizando um loop for para iterar de 50 a 500
        for (int i = 50; i <= 500; i++) {
            // Verificando se o número é ímpar e múltiplo de 3
            if (i % 2 != 0 && i % 3 == 0) {
                soma += i; // Adicionando o número à soma
            }
        }
    
        // Exibindo o resultado
        cout << "A soma dos números ímpares múltiplos de 3 de 50 a 500 é: " << soma << endl;
    }

    void funcaoex4(){
        setlocale(LC_ALL, "pt_BR.utf8"); // Para usar acentuação
     cout << "Digite um número: ";
     int numero;
     cin >> numero;
 
     int quadrado = numero * numero;
     int somaDigitos = 0;
 
     // Usando um loop while para iterar sobre os dígitos do quadrado do número
     while (quadrado > 0) {
         somaDigitos += quadrado % 10; // Adicionando o último dígito à soma
         quadrado /= 10; // Removendo o último dígito
     }
 
     cout << "A soma dos dígitos do quadrado de " << numero << " é: " << somaDigitos << endl;
    }

    int main() {
        int escolha;
        do {
            cout << "Menu:\n";
            cout << "0 - Sair\n";
            cout << "1 - Executar exercício: Média dos Números Pares\n";
            cout << "2 - Executar exercício: Múltiplos de 3 - de 50 a 500\n";
            cout << "3 - Executar exercício: Soma dos Dígitos do Quadrado\n";
            
            cout << "Escolha uma opção: ";
            cin >> escolha;
    
            if (escolha == 0) {
                cout << "Saindo...\n";
            } else if (escolha == 1) {
                funcaoex1();
            } else if (escolha == 2) {
                funcaoex3();
            } else if (escolha == 3) {
                funcaoex4();
            } else {
                cout << "Opção inválida!\n";
            }
        } while (escolha != 0);
    
        return 0;
    }
