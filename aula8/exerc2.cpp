#include <iostream>
#include <vector>

using namespace std;

struct Livro
{
    string titulo;
    string autor;
    string anoPublicacao;
    int numeroPaginas;
    int preco;
};

int main(){
    vector<Livro>livros(3);
    for(int i = 0; i < 3; i++){
        cout << "Digite o titulo do "<< i  <<" livro:"<<endl;
        cin >> livros[i].titulo;
        cout << "Digite o autor do "<< i  <<" livro:"<<endl;
        cin >> livros[i].autor;
        cout << "Digite o ano de publicaçao do "<< i  <<" livro:"<<endl;
        cin >> livros[i].anoPublicacao;
        cout << "Digite o numer de paginas do "<< i  <<" livro:"<<endl;
        cin >> livros[i].numeroPaginas;
        cout << "Digite o preço do "<< i  <<" livro:"<<endl;
        cin >> livros[i].preco;        
    }
    int somaPreco = 0;
    int MediaPag = 0;
    for(Livro x : livros){
        somaPreco += x.preco;
        MediaPag += x.numeroPaginas;
    }
    cout << "media: " << MediaPag/3 << "." << "preço" << somaPreco << endl;
}