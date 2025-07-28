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