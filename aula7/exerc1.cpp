#include <vector>
#include <iostream>

using namespace std;

int main(){
    int quantNum = 10;
    int numPar = 0;
    int numImpar = 0;
    vector<int> pares(quantNum);
    vector<int> impares(quantNum);

    for(int i = 0; i < quantNum; i++){
    cout << "Insira o " << i+1 << " Numero" << endl;
    int numTemporario;
    cin >> numTemporario;
    if(numTemporario%2 == 0){
    pares[numPar] = numTemporario;
    numPar++;
    }
    else{
        impares[numImpar] = numTemporario;
        numImpar++;
    }
    }

    cout << "PAR: ";
    for(int i = 0; i < numPar; i++){
    cout << pares[i] << " ";
    }

    cout << endl;

    cout << "IMPAR: ";
    for(int i = 0; i < numImpar; i++){
    cout << impares[i] << " ";
    }
}