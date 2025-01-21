# Unexpected Behavior with Mutable Variables in F# Functions
This repository demonstrates a common pitfall in F#: the unexpected behavior of mutable variables within functions.  In F#, functions don't automatically capture the current values of mutable variables unless explicitly handled using closures. This example showcases the problem and provides a solution.

## Problem
The initial example shows a function `add` which appears to use mutable variables `x` and `y`. However, the output is not what one would intuitively expect.  The function uses the initial values and doesn't reflect changes made to `x` and `y` after the function is defined.

## Solution
The solution utilizes a closure to properly capture the current values of the mutable variables at each call, thus producing the desired output.