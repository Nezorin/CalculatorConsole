# CalculatorConsole
_Simple console calculator made with C#_

## 1. Architecture
There are 3 classes in the project:
1. Program - class that responsible for the workflow of the program and console user interface. The class asks the user to input the first number, second number and operation to perform(addition, subtract, multiply or divide), then it asks CalculatorService to evaluate the result. If errors or exceptions occur during the execution of a mathematical operation, the program will inform the user about it. Next, the program shows the result of the operation and gives the user a choice of what to do next: continue working with the result, enter new numbers or finish the execution.
2. CalculatorService - class that contains basic calculator logic. Also, calculator stores the last result of the operation.
3. ParseService - static class that works with user input. It checks whether the input data is a normal number or a valid operation.
## 2. User Guide
#### Installation
You can manually download the project as ZIP archive: Code -> Download ZIP. Or, if you have git installed, you can use this command:
```git clone https://github.com/Nezorin/CalculatorConsole.git ```

To run the project you can use your IDE or dotnet CLI. If you use Visual Studio: open the solution file, build the solution(Ctrl+B) and run the code(Ctrl+F5). Or open Command Prompt(Console) and use these commands:
```
cd "PATH TO PROJECT FOLDER" 
dotnet build
dotnet run
```
#### Usage
Enter the first value, enter the second value, type an operation(add, sub, mul, div). If you entered not valid data, the program will inform you. Then the program will show you the result. Then type "n" if u want to enter another data, "e" to exit or any character or enter to continue to work with the result.

Example of usage:

![image](https://user-images.githubusercontent.com/47496652/131644366-891cb1d9-5887-4fc5-9710-47a2853dc861.png)




