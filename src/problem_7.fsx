//Naive implementation
#time;;
open System

let isPrime number =
    let bound = int64(Math.Sqrt(float(number)))
    seq { 2L .. bound }
    |> Seq.exists (fun x -> if (number % x = 0L) then true else false)
    |> not

let result = Seq.initInfinite (fun index -> int64 index + 1L) |> Seq.filter isPrime |> Seq.nth 10000


//Super fast sieve!
//See http://fsharpnews.blogspot.com/2010/02/sieve-of-eratosthenes.html
#time;;
let primes =
    let a = ResizeArray[2]
    let grow() =
      let p0 = a.[a.Count-1]+1
      let b = Array.create p0 true
      for di in a do
        let rec loop i =
          if i<b.Length then
            b.[i] <- false
            loop(i+di)
        let i0 = p0/di*di
        loop(if i0<p0 then i0+di-p0 else i0-p0)
      for i=0 to b.Length-1 do
        if b.[i] then a.Add(p0+i)
    fun n ->
      while n >= a.Count do
        grow()
      a.[n];;

let answer = primes 10000