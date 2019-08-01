## Overview
A matrix terminal interface. 

## Requirments
This project depends on .Net Core. So you should install .Net core runtime and SDK first.
1. Win:
- 1.1 install [dotnet-sdk](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.401-windows-x64-installer)
- 1.2 install [dotnet-runtime](https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.108-windows-x64-installer)
2. Linux:
- 2.1 Arch Linux
    ```
    sudo pacman -S dotnet-runtime dotnet-sdk
    ```
- 2.2 Ubuntu CentOS REHL please check [this](https://dotnet.microsoft.com/download)

## RUN
```
cd ./src/matrix
dotnet run
```

## Build
1.Linux:
```
cd ./src/matrix
dotnet publish -r linux-x64
```
2.Win:
```
cd ./src/matrix
dotnet publish -c Realese -r win-x64
```
## Usage
1. Input the dimension of matrix, like `d`;
2. Input `dxd` number as matrixA;
3. Input `dxd` number as matrixB;
4. Finally program calculate the transpose of matrixB and the result of ```matrixA x matrixB_transpose```
## Example


```
$ dotnet run // or use compiled file ./matrix.exe
Welcome to matrix interface, Please enter dimension of matrix:

3
Please input matrixA:

1
2
3
4
5
6
7
8
9
Please input matrixB:

9 
8
7
6
5
4
3
2
1
Your matrixA input is:

1 2 3 
4 5 6 
7 8 9 

Your matrixB input is:

9 8 7 
6 5 4 
3 2 1 

Your matrixB transpose output is:

9 6 3 
8 5 2 
7 4 1 

Your matrix multiply matrix transpose output is: 

46 28 10 
118 73 28 
190 118 46  
```


