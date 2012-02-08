#light
#r "FSharp.PowerPack.Parallel.Seq.dll"
#load "ProjectEuler.fs"
open Microsoft.FSharp.Collections
open System

//Using PSeq cuts the real time in half
#time
let answer = {1L..2000000L} |> PSeq.filter ProjectEuler.isPrime |> PSeq.sum