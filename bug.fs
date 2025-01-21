let mutable x = 10
let mutable y = 20
let add x y = x + y
printf "%d" (add x y) //This will print 30
x <- 15
y <- 25
printf "%d" (add x y) //This will also print 30, not 40 as expected. 
//The problem is that F# functions do not capture variables by default in the way that some other languages do, such as C# or Javascript.
//The function "add" has captured the initial values of x and y, 10 and 20. It does not capture the mutable variables x and y.
//To fix this, we can use a closure to make sure the function captures the latest values of the variables.
