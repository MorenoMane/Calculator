// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

let checkYear givenYear =
    if (givenYear % 4 = 0 && givenYear % 100 <> 0) then
        printfn "This is a leap year"
    elif(givenYear % 400 = 0) then
        printfn "This is a leapyear"
    else
        printfn "This is not a leap year"

checkYear 2023

///USING MATCH


let leapMatch givenYear =
    match givenYear % 4, givenYear % 100,givenYear % 400 with
    | 0,_,_ when givenYear % 100 <> 0 ->true
    | 0,0,0 -> true
    | _-> false

let result1 = leapMatch 2023
let result2 = leapMatch 2018

if result1 = true then
    printfn "Is a leap year"
else 
    printfn "not a leap year"

if result2 = true then
    printfn "Is a leap year"
else 
    printfn "not a leap year"
