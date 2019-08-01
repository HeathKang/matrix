## Overview
A matrix terminal interface. 

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
## Example


```
$ ./matrix (or matrix.exe)
Welcome to matrix interface, Please enter dimension of matrix:

3
Please input matrix:

1
2
3
4
5
6
7
8
9
Your matrix input is:

1 2 3 
4 5 6 
7 8 9 

Your matrix transpose output is:

1 4 7 
2 5 8 
3 6 9 

Your matrix multiply matrix transpose output is: 

14 32 50 
32 77 122 
50 122 194 
```


