# asterisk-tree
This program will print out a tree (made up of asterisk characters) to the console

This is the desired output:
    *
   ***
  *****
 *******
*********

After a bit of playing around with the code, I got it to work. However, after checking the author's solution (I got the problem from The C# Player's Guide by RB Whitaker) I realized how inefficient my solution was. The author used the row number as n and created two formulas: 5 - n - 1 for the number of spaces and n * 2 + 1 for the number of asterisks. This is a better solution because both for loops used start indexing at 0 and increment, rather than my solution which is much less readable.
