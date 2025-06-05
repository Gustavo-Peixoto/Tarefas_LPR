#include<vector>
#include<iostream>

using namespace std;

int main(){
    vector<int> numeros(10);
    for(int i = 0; i < 10; i++){
        cout << "insira o " << i+1 << " numero" << endl;
        int numTemporario;
        cin >> numTemporario;
        numeros[i] = numTemporario;
    }

    cout << "Digite o valor que deseja encontrar." << endl;
    int valorBusca;
    cin >> valorBusca;

    int ocorrencias = 0;
    for(int i = 0; i < 10; i++){
        if(numeros[i] == valorBusca){
            ocorrencias++;
            cout << "Valor encontrado na posição: " << i+1 << endl;
        }
    }

    cout << "Total de ocorrencias: " << ocorrencias << endl;
}