# TableSort
A sorting algorithm which describes determines the correct position by comparing the values of a imaginary table

##Describtion
Compare the value of each cell with each other:
*If a < b then the position of of a is incremented, else the position b is incremented
*You only have to check (Length - 1 + Length - 2 + Length - n) == ((Length - 1)^2 + (Length - 1)) / 2 cells, because table[x,y] == |table[y,x] - 1|

##Example
<table>
    <tr>
      <th></th>
      <th> 9</th>
      <th>28</th>
      <th> 7</th>
      <th> 3</th>
      <th>10</th>
    </tr>
    <tr>
      <th>9</th>
      <td>0</td>
      <td>1</td>
      <td>0</td>
      <td>0</td>
      <td>1</td>
    </tr>
    <tr>
      <th>28</th>
      <td>0</td>
      <td>0</td>
      <td>0</td>
      <td>0</td>
      <td>0</td>
    </tr>
    <tr>
      <th>7</th>
      <td>1</td>
      <td>1</td>
      <td>0</td>
      <td>0</td>
      <td>1</td>
    </tr>
    <tr>
      <th>3</th>
      <td>1</td>
      <td>1</td>
      <td>1</td>
      <td>0</td>
      <td>1</td>
    </tr>
    <tr>
      <th>10</th>
      <td>0</td>
      <td>1</td>
      <td>0</td>
      <td>0</td>
      <td>0</td>
    </tr>
    <tr>
      <td></td>
      <th>2</th>
      <th>4</th>
      <th>1</th>
      <th>0</th>
      <th>3</th>
    </tr>
</table>
