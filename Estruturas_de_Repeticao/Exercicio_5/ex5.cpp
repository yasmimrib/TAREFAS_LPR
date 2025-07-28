/*Exercício 5)
ESCOLHA A MELHOR ESTRUTURA DE
REPETIÇÃO: Crie um programa que simula
o treinamento de um Jedi. O usuário deve
inserir o número de horas de treinamento
por dia. O programa deve calcular o total
de horas de treinamento em uma semana,
desconsiderando sábados e domingos, e
informar quantos dias, semanas e meses
seriam necessários para alcançar o total de
1000 horas de treinamento. Considere 1
mês = 4,5 semanas.
*/ 

#include <iostream>
#include <locale>
using namespace std;

int main(){
    setlocale(LC_ALL, "Portuguese");

    int horasPorDia;
    cout << "Insira o número de horas de treinamento por dia: ";
    cin >> horasPorDia;

    int horasPorSemana = horasPorDia * 5;
    int semanas = (1000 + horasPorSemana - 1) / horasPorSemana; 
    int diasUteis = semanas * 5;
    double meses = semanas / 4.5;

    cout << "Serão necessários:\n";
    cout << diasUteis << " dias úteis\n";
    cout << semanas << " semanas\n";
    cout << meses << " meses\n";

    return 0;
}