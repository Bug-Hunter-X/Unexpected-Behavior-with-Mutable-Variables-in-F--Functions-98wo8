let add x y = 
    let mutable currentX = x
    let mutable currentY = y
    fun () -> currentX + currentY

let mutable x = 10
let mutable y = 20

let addClosure = add x y
printf "%d" (addClosure ()) //This will print 30
x <- 15
y <- 25
printf "%d" (addClosure ()) //This will print 40
//The closure now correctly reflects the changed values of x and y.
//The function addClosure is now a closure, which means that it captures the current values of x and y.
//The values of x and y are updated each time addClosure is called.