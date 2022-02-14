module ``Pipes``
open Xunit
open FsUnit.Xunit

/// we have a mathematical problem for which we need to
/// apply a series of operations:
/// * add 10
/// * divide by 3
/// * raise to 2nd power (square)
/// below you can find the *very* tricky implementations
/// careful: float types ahead (add a '.' in the end)

let addTen number =
    number + 10.
let divideByThree number =
    number / 3.
let powOfTwo number =
    number ** 2. // No Math.Pow needed

/// if we go the conventional route we have to use
/// parentheses to group/order the operations like
/// we would in math.
/// But this can be confusing and is hard to read.
let operationConventional number =
    powOfTwo (divideByThree (addTen number))
    
/// now let's have a look at the piped version
/// The pipe applies the previous expression to the
/// expression after.
/// It just looks more pleasant, the result
/// does not differ to the conventional
/// conventional implementation.
/// This is exactly like piping in bash/zsh.
let operationPiped number =
    number
    |> addTen
    |> divideByThree
    |> powOfTwo
    
[<Fact>]
let ``Piped and Conventional has equal behaviour`` () =
    operationConventional 1212 |> should equal (operationPiped 1212)
    
    operationConventional 11 |> should equal 49.0
    operationPiped        11 |> should equal 49.0


