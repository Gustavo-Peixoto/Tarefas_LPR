#include <iostream>
#include <string.h>

using namespace std;
void revert();
void Revert(char num[])
{
    int len = strlen(num) - 1;
    string num_revert = "";
    for (int i = 0; i <= len; i++)
    {
        num_revert += num[len-i];
    }
    cout<<num_revert;
}

int main()
{
    char num[] = "";
    cout << "Insire o numero para ser invertido." << endl;
    cin >> num;
    Revert(num);
}
