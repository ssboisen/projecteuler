//The prime factors of 13195 are 5, 7, 13 and 29.
//
//What is the largest prime factor of the number 600851475143 ?
open System

let isPrime number =
    let bound = int64(Math.Sqrt(float(number)))
    seq { 2L .. bound }
    |> Seq.exists (fun x -> if (number % x = 0L) then true else false)
    |> not

let largestPrimeFactor x =
    let max = x
    let upperBound = int64(Math.Sqrt(float(x)))
    let rec findLargestPrimeFactor x =
        match x with
            | x when x % 2L = 0L || max % x <> 0L -> findLargestPrimeFactor (x-1L)
            | x ->  let isPrime = isPrime x
                    match isPrime with
                        | true when max % x = 0L -> x
                        | _ -> findLargestPrimeFactor (x-1L)

    findLargestPrimeFactor upperBound

largestPrimeFactor 600851475143L


