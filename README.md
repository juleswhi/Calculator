# Calculator
A Fun Project For 4am in the morning


## How Does This Work?
Its all about tokens fr
<br>
A List of Tokens ( or a stack ) are used to keep track of the operations

There are two types of Tokens, **NumberToken**\<T\> and **OperatorToken**\<T\>
Both of these tokens have restraints on their generics, NumberToken only accepts structs, and OperationToken Enums

When the user clicks on a number, it is placed into a 'Holding' variable until the user enters a Operator

When the user has entered an operator, we push the holding number to the stack and then push the operator

When the user clicks equals, then we push the second number to the stack.

With the right precautions, we can assume the last three Tokens on the stack will be in the order: Number, Operation, Number.

We then parse the tokens through the Evaluate() function, which dereferences the output pointer and sets it to the result 


Because the stack only gets added to, it can be used as a history.



### ***Evaluate(\*double output, int index)***
The Evaluate function takes in a pointer to an output variable, and an index of where to start the calculations

The index will be the index of the first NumberToken that is in the Equation ( Left Token )
We can redo sums from the history if we have the index.
A index of -1 means the most recent 3 Tokens