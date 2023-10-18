// For more information see https://aka.ms/fsharp-console-apps
open System

//recursion and match 
let readOperation () =
    printfn "What operation do you wish to accomplish "
    
    let input = Console.ReadLine()
    
    input

let isValidInteger (input: string) =
    match Int32.TryParse(input) with
    | (true, _) -> true  // Parsing successful
    | _ -> false        // Parsing failed

let rec readOperand () =
    let input = Console.ReadLine()

    match isValidInteger input with
    |true -> Int32.Parse(input)
    |false -> 
        printfn "Invalid input . Try again" 
        readOperand()
   

let performCalculation() =
    let operation = readOperation()

    printfn "Enter first Operand"
    let operand1 = readOperand()
    printfn "Enter Second Operand"
    let operand2 = readOperand()

    printf "Calculating %d" operand1
    printf " %s"operation 
    printfn " %d"operand2

    match operation with
    |"+" -> operand1 + operand2
    |"-" -> operand1 - operand2
    |"*" -> operand1 * operand2
    |"/" -> operand1 / operand2
    |_ -> failwith "Invalid Operation"






let result = performCalculation()

printfn "Result = %d" result

//using else if statements
let ifelseCalc () =
    let operation = readOperation()

    printfn "Enter first Operand"
    let operand1 = readOperand()
    printfn "Enter Second Operand"
    let operand2 = readOperand()

    printf "Calculating %d" operand1
    printf " %s"operation 
    printfn " %d"operand2
    

    if operation = "+" then
        operand1 + operand2
    elif operation = "-"then
        operand1 - operand2
    elif operation = "*" then
        operand1 * operand2
    elif operation = "/" then
        operand1 / operand2
    else
        failwith "Invalid Operation"


let r = ifelseCalc()
printfn "Result = %d" r 
