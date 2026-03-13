#include<iostream>
using namespace std;

int main()
{
	double height, weight; // height: 키, weight: 몸무게

	cout << "체중(kg) : ";
	cin >> weight;

	cout << "키(cm) : ";
	cin >> height;

	double bmi = weight / ((height / 100) * (height / 100)); // BMI 계산

	cout << "당신의 BMI는 " << bmi << "입니다." << endl;
}