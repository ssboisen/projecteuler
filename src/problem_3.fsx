#light
#load "ProjectEuler.fs"
open System

let largestPrimeFactorOf x =
    let max = x
    let upperBound = int64(Math.Sqrt(float(x)))
    let rec findLargestPrimeFactor x =
        match x with
            | x when max % x <> 0L -> findLargestPrimeFactor (x-1L)
            | x ->  let isPrime = ProjectEuler.isPrime x
                    match isPrime with
                        | true when max % x = 0L -> x
                        | _ -> findLargestPrimeFactor (x-1L)

    findLargestPrimeFactor upperBound

let answer = largestPrimeFactorOf 600851475143L


