#include <iostream>
#include <map>
#include <algorithm> // Para std::max_element e std::min_element
using namespace std;

int main()
{
    map<string, int> cidades;
    int n;
    cout << "Quantas cidades deseja inserir? ";
    cin >> n;

    for (int i = 0; i < n; ++i) {
        string cidade;
        int populacao;
        cout << "Digite o nome da cidade: ";
        cin >> cidade;
        cout << "Digite a população da cidade: ";
        cin >> populacao;
        cidades[cidade] = populacao;
    }

    int totalPopulacao = 0;
    for (const auto& par : cidades) {
        totalPopulacao += par.second;
    }

    double mediaPopulacao = static_cast<double>(totalPopulacao) / cidades.size();
    cout << "A média de população é: " << mediaPopulacao << endl;

    cout << "Cidades com população acima da média:\n";
    for (const auto& par : cidades) {
        if (par.second > mediaPopulacao) {
            cout << par.first << " com população de " << par.second << endl;
        }
    }

    auto maxPopulacao = max_element(cidades.begin(), cidades.end(),
        [](const pair<string, int>& a, const pair<string, int>& b) {
            return a.second < b.second;
        });
    auto minPopulacao = min_element(cidades.begin(), cidades.end(),
        [](const pair<string, int>& a, const pair<string, int>& b) {
            return a.second < b.second;
        });

    cout << "Cidade mais populosa: " << maxPopulacao->first << " com população de " << maxPopulacao->second << endl;
    cout << "Cidade menos populosa: " << minPopulacao->first << " com população de " << minPopulacao->second << endl;

    int y;
    cout << "Digite o valor Y para remover cidades com população igual: ";
    cin >> y;

    // Remover cidades com população igual a Y
    for (auto it = cidades.begin(); it != cidades.end();) {
        if (it->second == y) {
            it = cidades.erase(it); // Remove e avança o iterador
        } else {
            ++it; // Apenas avança o iterador
        }
    }

    // Imprimir o dicionário atualizado
    cout << "Dicionário atualizado:\n";
    for (const auto& par : cidades) {
        cout << par.first << " com população de " << par.second << endl;
    }

    return 0;
}
