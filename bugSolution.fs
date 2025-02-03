let x = 10
let y = 20

let swap x y =
    (y, x) //Return a tuple with swapped values

let x', y' = swap x y

printf "%d %d" x' y' // This will print 20 10

//Alternative approach to avoid modifying original variables:
let x = 10
let y = 20

let swap x y =
    let temp = x
    let x = y
    let y = temp
    (x,y)

let x', y' = swap x y
printf "%d %d" x' y'