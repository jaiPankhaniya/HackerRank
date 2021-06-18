#include <cmath>
#include <cstdio>
#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

void Review(int N);
int main() 
{
    /* Enter your code here. Read input from STDIN. Print output to STDOUT */   
    int N;
    cin >> N;
    Review(N);
    return 0;
}
void Review(int N)
{
    for (int i = 0; i < N; i++) 
    {
        string str;
        cin >> str;

        for (int j = 0; j < str.length(); j++) 
        {
            if (j % 2 == 0)
            {
                cout << str[j];
            }
        }
        cout << " ";
        for (int j = 0; j < str.length(); j++) 
        {
            if (j % 2 != 0)
            {
                cout << str[j];
            }
        }
        cout << endl;
    }
}
