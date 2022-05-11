#include <iostream>  //Main Library
using namespace std; // Allows Naming

int main() // Main allows things to run
{
    int Integer = 10;
    double Decimal = 10.9;
    string Text = "This is text";
    char Character = '$';
    bool TrueFalse = false;

    if (Integer == 10 && Decimal > 10.9)
    {
        Text = "This is an If / Else Statement";
    }
    else
    {
        Text = "Variables can be updates";
    }

    while (Integer == 10)
    {
        Text = "While Statements repeat as long as the condition is true";
    }

    cout << "This outputs text";
}