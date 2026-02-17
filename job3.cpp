#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	double x;
	cout << "введите х";
	cin >> x;
    for (double i = -3; i < 3; i += 0.25) {
        if (x > 2) {
            x =pow(2.72, 2);
        }
        else if (i >= -2 && i <= 2) {
            x = x + 4;
        }
        else {
            x = 0;
        }
        cout << "Ответ: " << x;
    }