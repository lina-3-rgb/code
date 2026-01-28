#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    setlocale(LC_ALL, "Russian");
    double x;
    cout << "Введите x: ";
    cin >> x;

    double y;
    cout << "Введите y: ";
    cin >> y;

    double a;
    cout << "Введите a: ";
    cin >> a;

    double b;
    cout << "Введите b: ";
    cin >> b;

    double z;

    if (x > 0 && y > 0) {
        double maxEl = (a / x, b / x);
        maxEl = (maxEl, sqrt(y));
        z = maxEl;
    }
    else if (x < 0 && y > 0) {
        double minEl = (a * pow(x, 3), b * pow(y, 2));
        z = minEl;
    }
    else {
        z = pow(2, x + y);
    }

    cout << "Ответ: " << z;
}