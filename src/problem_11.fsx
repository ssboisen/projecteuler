open System;
let data = "column1;column2;column3;column4;column5;column6" + Environment.NewLine + "1;2;3;4;5;6" + Environment.NewLine + "7;8;9;10;11;12";

let dataParser data =
    let split (dl : string) (value: string) = value.Split([|dl|],StringSplitOptions.RemoveEmptyEntries) |> Array.toList
    data |> (split Environment.NewLine) |> List.map (split ";")

let tableCreator rowDelimiter columnDelimiter passedData =
    let maxRowWidth = passedData |> List.map (List.sumBy String.length) |> List.max
    let maxColumnWidth = passedData |> List.collect (List.map String.length) |> List.max 
    let makeColumns row = row |> List.rev |> List.fold (fun s (i : string) -> sprintf "%s%s%s" columnDelimiter (i.PadLeft(maxColumnWidth)) s) columnDelimiter
    let makeRowDelimiter = (String.replicate ((maxRowWidth) + passedData.Head.Length + 1) rowDelimiter) + Environment.NewLine
    let makeRow row = sprintf "%s%s%s" (makeColumns row) Environment.NewLine makeRowDelimiter
    
    makeRowDelimiter :: (passedData |> List.map makeRow)

data |> dataParser |> tableCreator "-" "|" |> List.reduce (+) |> printf "%s"

open System;
let isbetween rl rub v = 
        //let split (dl : string) (value: string) = value.Split([|dl|],StringSplitOptions.RemoveEmptyEntries) |> Array.toList
        //let range = r |> split "-" |> List.map int
        //range.Head <= v && v <= range.Tail.Head 
        rl <= v && v <= rub
let isLessThan rub v = v < rub
let isLargerThan rlb v = v > rlb
let equals x v = x.Equals(v)

//let AND a b = a && b
let OR a b = a || b

25 |> isbetween 20 30 && 58 |> isbetween 40 50 || 10 |> isbetween 8 11 && 25 |> equals 25

let from = ()
let is = ()
let score from_key x is func = x |> func
let between a b x = a <= x && x <= b;
let below a x = x < a
let above a x = x > a

let upartiskNeutral = 25
let hovsa = 40

(score from upartiskNeutral is (between 20 30) |> OR (score from hovsa is (below 30))) && score from upartiskNeutral is (above 40)



seq { 1..30} |> Seq.map string |> Seq.reduce (+) |> printfn "%s"