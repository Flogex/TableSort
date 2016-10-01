# TableSort
A sorting algorithm which describes determines the correct position by comparing the values of a imaginary table

##Describtion
<p>Compare the value of each cell with each other:
If a < b then the position of of a is incremented, else the position b is incremented.</p>
<p>If all comparisons are completed, sum the entries of each column.
The new position is the sum of a column.</p>

##Number of comparisons
<p>table[x,y] = |table[y,x] - 1|</p>
<p>So you only have to check</p>
![alt-tag](GithubResources/formula.PNG "TriangularNumber_formula")
<p>cells, which equals the number of comparisons.</p>
![Control Overview](GithubResources/TriangularNumeric_Table.PNG "TriangularNumber")

##Example
![Control Overview](GithubResources/SampleSort.PNG "Example")</br>
