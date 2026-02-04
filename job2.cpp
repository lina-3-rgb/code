

#include <iostream>
#include <cmath>
using namespace std;

int main()
{
	setlocale(LC_ALL, "Russian");
	double x;
	cout << "Введите х";
	cin >> x;

	double y;
	cout << "Введиде у";
	cin >> y;

	double c = pow(y * pow(x, 2) - 1, 2) / (2) * (pow(cos(y), 2)) * y - sin(pow(x, 2));
	cout << "Ответ" << c;
}

