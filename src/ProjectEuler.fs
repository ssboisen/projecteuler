// Learn more about F# at http://fsharp.net
module ProjectEuler
open System

let isPrime number =
    match number with
        | number when number = 2L -> true
        | number when number <= 1L || number % 2L = 0L -> false
        | _ ->
                let bound = int64(Math.Sqrt(float(number)))
                seq { 3L .. 2L .. bound }
                |> Seq.exists (fun x -> number % x = 0L) |> not