#include <iostream>
using namespace std;

int main(){
    int mA[3][3], mB[3][3], mC[3][3];

    cout << "Digite os elementos da matriz A (3x3):" << endl;
    for(int i = 0; i < 3; i++){
        for(int j = 0; j < 3; j++){
            cin >> mA[i][j];
        }
    }

    cout << "Digite os elementos da matriz B (3x3):" << endl;
    for(int i = 0; i < 3; i++){
        for(int j = 0; j < 3; j++){
            cin >> mB[i][j];
        }
    }

    for(int i = 0; i < 3; i++){
        for(int j = 0; j < 3; j++){
            mC[i][j] = 0;
            for(int k = 0; k < 3; k++){
                mC[i][j] += mA[i][k] * mB[k][j];
            }
        }
    }

    cout << "Matriz resultado (A * B):" << endl;
    for(int i = 0; i < 3; i++){
        for(int j = 0; j < 3; j++){
            cout << mC[i][j] << " ";
        }
        cout << endl;
    }

    return 0;
}