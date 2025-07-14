#include <iostream>
#include <algorithm>
#include <list>
#include <ctime>

using namespace std;

int main(){
    list<int>nums;
    list<int>repetidos;
    srand(time(0));
    for(int i = 0; i < 100; i++) nums.push_back(rand() % 51);

    nums.sort();

    for(auto x : nums) cout << x << " ";

    for(auto it = nums.begin(); it != nums.end();){
        if(*it%2 == 0) it = nums.erase(it);
        else ++it;
    }

    cout << endl;

    int maior = 0;
    for(auto x : nums){
        cout << x << " ";
        if(x > maior) maior = x;
    }

    cout << endl;

    for(int i = 0; i <= maior; i++){
        int cont = 0;
        for(auto it = nums.begin(); it != nums.end();){
            if(*it == i){
               cont++;
               if(cont == 2){
                    cout << *it << " ";
               } 
            } 
            ++it;
        }
    }
}