# Grading Students



HackerLand University has the following grading policy:

- Every student receives a grade in the inclusive range from  0 to 100.

Any grade less than 40 is a failing grade. 

Sam is a professor at the university and likes to round each student's grade according to these rules:

- If the difference between the grade and the next multiple of 5  is less 3 than , round grade up to the next multiple of 5.
- If the value of grade is less than 38, no rounding occurs as the result will still be a failing grade.



**Function Description**  

Complete the function *gradingStudents* in the editor below.  

gradingStudents has the following parameter(s):  

- *int grades[n]*:  the grades before rounding  

**Returns**

- *int[n]*: the grades after rounding as appropriate

**Input Format**

The first line contains a single integer, n,, the number of students. 
 Each line, i of the, n subsequent lines contains a single integer, grades[i]. 

**Sample Input 0**

```
4
73
67
38
33
```

**Sample Output 0**

```
75
67
40
33
```