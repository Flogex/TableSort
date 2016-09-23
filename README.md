# TableSort
A sorting algorithm which describes determines the correct position by comparing the values of a imaginary table

##Describtion
Compare the value of each cell with each other:
*If a < b then the position of of a is incremented, else the position b is incremented
*You only have to check (Length - 1 + Length - 2 + Length - n) == ((Length - 1)^2 + (Length - 1)) / 2 cells, because table[x,y] == |table[y,x] - 1|

##Example
![Control Overview](SampleSort.PNG "Example")
