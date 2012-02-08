#r "FSharp.PowerPack.Parallel.Seq.dll"
open Microsoft.FSharp.Collections
open System

let isPrime number =
    match number with
        | number when number = 2L -> true
        | number when number <= 1L || number % 2L = 0L -> false
        | _ ->
                let bound = int64(Math.Sqrt(float(number)))
                seq { 3L .. 2L .. bound }
                |> Seq.exists (fun x -> number % x = 0L) |> not

//Using PSeq cuts the real time in half
#time;;
let answer = {1L..2000000L} |> PSeq.filter isPrime |> PSeq.sum