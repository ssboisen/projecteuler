#r "FSharp.PowerPack.Parallel.Seq.dll"
#time;;
open Microsoft.FSharp.Collections
open System

let isPrime number =
    let bound = int64(Math.Sqrt(float(number)))
    seq { 2L .. bound }
    |> Seq.exists (fun x -> number % x = 0L) |> not

//Using PSeq cuts the real time in half
let answer = {1L..2000000L} |> PSeq.filter isPrime |> PSeq.sum
