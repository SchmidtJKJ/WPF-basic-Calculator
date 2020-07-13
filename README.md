# WPF-basic-Calculator
This calculator provides the basic calculation (add, substact, multply and divide) of reals
it also have a square. square root and logarith (base 10) functions. Works with parenthesis.
save the last result to perfom ONLY the next operation
provides a clear method to clear everything up, a Del to delete the last character entered
Display is in a non-traditional calculator way (on purpose)
I use a stack based infix calculation for when = is pressed upon calculations
The entered values are being saved after each input both as a whole string (for infix calcul)
and as operand for calcul that do not need infix stuff (log, sqr and sqrt)
Obviously noth all errors are handled but I caught some like unmatch parentheses, division by 0, 
entering more than one decimal point in a single operand
...
