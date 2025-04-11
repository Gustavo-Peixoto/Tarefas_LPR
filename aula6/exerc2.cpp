#include <iostream>

using namespace std;

int soma_num_quadrados(int numero)
{
    int quadrado = numero * numero;
    int somaDigitos = 0;

    while (quadrado > 0) {
        somaDigitos += quadrado % 10; 
        quadrado /= 10; 
    }

    return somaDigitos;
}

void num_imp_mult3_50a500()
{   
    int soma = 0;

    for (int i = 50; i <= 500; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }

    cout << "A soma dos números ímpares múltiplos de 3 de 50 a 500 é: " << soma << endl;
}

double media_num(int quantidade)
{
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
        return media;
    } else {
        return false;
    }
}

int main()
{
    cout << "||             Escolha uma opção                       ||" << endl;
    cout << "||1- Ver a media das somas de numeros impares          ||" << endl;
    cout << "||2- Ver os numeros impares multiplos de 3 de 50 a 500 ||" << endl;
    cout << "||3- Ver as somas dos digitos de um numero ao quadrado ||" << endl;
    cout << "|| ";
    
    int menu_choice;
    cin >> menu_choice;

    if(menu_choice > 3 || menu_choice < 1)
    {
        cout << "Não existe essa opção." << endl;
    }
    else
    {
        switch (menu_choice)
        {
            case 1:
            {
                cout << "Digite a quantidade de numeros a serem somados: ";
                int quantidade;
                cin >> quantidade;
                double media = media_num(quantidade);
                if(media)
                {
                    cout << "A media dos numeros pares é : " << media << endl;
                }
                else
                {
                    cout << "Nao tinha numeros pares na sua entrada" << endl;
                }
                break;
            }
            case 2:
            {
                num_imp_mult3_50a500();
                break;
            }
            case 3:
            {
                cout << "Digite um numero para somarmos os digitos do seu quadrado: ";
                int num;
                cin >> num;
                int soma = soma_num_quadrados(num);
                cout << "A soma dos digitos é " << soma << endl; 
                break;
            }
        }
    }
}