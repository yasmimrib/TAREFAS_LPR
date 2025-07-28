/*Exercício 2) RESOLVA EM C++
Defina uma struct Livro com os seguintes
campos: Titulo, Autor, AnoPublicacao,
NumeroPaginas e Preco. Crie um
programa que permita ao usuário inserir
dados de 3 livros e, em seguida, calcule e
exiba o preço total dos livros cadastrados
e a média de páginas dos livros.*/

#include <iostream>
#include <array>
#include <string>
using namespace std;

struct Livro {
    string Titulo;
    string Autor;
    int AnoPublicacao;
    int NumeroPaginas;
    double Preco;
};

int main(){
    array<Livro, 3> livros;
    for (int i = 0; i < livros.size(); ++i) {
        cout << "Insira os dados do livro " << (i + 1) << ":\n";
        cout << "Titulo: ";
        cin.ignore();
        getline(cin, livros[i].Titulo);
        cout << "Autor: ";
        getline(cin, livros[i].Autor);
        cout << "Ano de Publicacao: ";
        cin >> livros[i].AnoPublicacao;
        cout << "Numero de Paginas: ";
        cin >> livros[i].NumeroPaginas;
        cout << "Preco: ";
        cin >> livros[i].Preco;
    }

    double precoTotal = 0;
    int totalPaginas = 0;
    for (int i = 0; i < 3; i++) {
        precoTotal += livros[i].Preco;
        totalPaginas += livros[i].NumeroPaginas;
    }

    cout << "O preco total dos livros equivale a R$" << precoTotal << endl;
    
    double mediaPaginas = totalPaginas / 3.0;
    
    cout << "A media de paginas dos livros equivale a " << mediaPaginas << endl;

    return 0;

}