#include <iostream>
#include <map>
using namespace std;

int main(){
    map<string, int> Cidades;
    int x;
    cout << "Digite quantas cidades deseja registrar: ";
    cin >> x;

    for(auto i = 0; i < x; i++){
        string nomeCidade;
        int populacaoCidade;
        cout << "Digite o nome da cidade: ";
        cin >> nomeCidade;
        cout << "Digite a populacao da cidade: ";
        cin >> populacaoCidade;
        Cidades.insert({nomeCidade, populacaoCidade});
    }

    int soma = 0;
    for(auto j : Cidades){
        soma += j.second;
    }
    float media = soma/Cidades.size();

    for(auto j : Cidades){
        if(j.second > media) cout << "A cidade" << j.first << " esta acima da media" << endl;
    }

    long Maior = 0;
    long Menor = 7000000; 
    string nomeMaior, nomeMenor;

    for(auto j : Cidades){
        if(j.second > Maior){
            Maior = j.second;
            nomeMaior = j.first;
        }
        if(j.second < Menor){
            Menor = j.second;
            nomeMenor = j.first;
        }
    }

    cout << "A maior cidade é: " << nomeMaior << " e a menor é: " << nomeMenor << endl;

    cout << "Digite o numero de populacao que deseja remover: ";
    int y;
    cin >> y;

    for(auto it = Cidades.begin(); it != Cidades.end();){
        if(it->second == y) it = Cidades.erase(it);
        else it++;
    }

    for(auto j : Cidades){
        cout << "Nome: " << j.first << ", Populacao: " << j.second << endl;
    }
}