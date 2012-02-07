//See: http://en.wikipedia.org/wiki/Least_common_multiple and http://en.wikipedia.org/wiki/Greatest_common_divisor
let smallestEvenlyDivisableBy seq = 
        let rec gcd a b = if b = 0L then a else gcd b (a - b * (a / b))
        let lcm a b = (a * b) / gcd a b
        seq |> Seq.fold lcm 1L

let answer = smallestEvenlyDivisableBy (seq { 1L..20L })





