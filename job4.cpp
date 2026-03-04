#include <iostream>
#include <cmath>

double Name(double a, double b, double c)
{
    return std::sqrt(b * c * std::pow(b + c, 2) - std::pow(a, 2)) / (b + c);
}

int main()
{
    double a = 4;
    double b = 6;
    double c = 5;

    double result = Name(a, b, c);

    std::cout << "Ответ: " << result << std::endl;

    return 0;
}