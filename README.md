# Specs
#### The user enters an amount of cents smaller than 5, return pennies in remainder of user input divided by 5.
eg, input : 3 cents
output: 3 pennies;

#### The user enters an amount of cents greater or equal to 5 but smaller than 10, return nickels in nearest integer smaller than user input divided by 5 and pennies in the remainder of the division.
eg, input: 8 cents
output: 1 nickels 3 pennies;

#### The user enters an amount of cents greater or equal to 10 but smaller than 25, return dimes in nearest integer smaller than user input divided by 10 and nickels in the remainder of the division divided by 5 and pennies in the remainder of the second division.
eg, input: 18 cents
output: 1 dime, 1 nickels, 3 cents;

#### The user enters an amount of cents greater or equal to 25, return quarters in closest smaller integer to input divided by 25, and return dimes in the remainder of the first division divided by 10, and return nickels in the remainder of the second division divided by 5, and return pennies in remainder of input divided by 5.
eg, input: 43 cents;
output: 1 quarter, 1 dime, 1 nickel, 3 cents;
