printfn "The calculator program"
printf "Type a first value: "
let first = System.Console.ReadLine()
printf "Type the second value: "
let second = System.Console.ReadLine()

printfn $"first= {first}, second= {second}"

let sum a b = a + b
printf $"Sum = {sum (int first) (int second)}"