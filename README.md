# Unexpected Behavior with Mutable Variables in F#

This example demonstrates a common issue with mutable variables in F#: they are passed by reference, not by value.  This can lead to unexpected behavior when used within functions.

The `swap` function intends to exchange the values of `x` and `y`, but because the variables are passed by reference, modifications within the function directly affect the original variables outside the function's scope.

The solution shows how to correctly swap values using tuples or creating a new variable to hold the swapped values to avoid modifying original variable.