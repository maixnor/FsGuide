
/// for more on FsUnit check out: http://fsprojects.github.io/FsUnit/

/// Modules can have fancy names, even with spaces in them.
module ``Testing fundamentals``
    
/// here we will explore testing with FsUnit for Xunit
/// (you should be familiar with Xunit already)
/// let's meet our test subject here 
let add x y =
    x + y
        
// open is the F#'s using
open Xunit
open FsUnit.Xunit

/// Attributes are to be placed in `<>` within the brackets.
/// you can also define methods like this. especially great for test methods.
/// They can also be accessed, but you need the ``x`` in the call as well
/// which does not look and feel to good, also there is a lot of clutter then.
/// 
[<Fact>]
let ``Add two numbers, the Xunit way`` () =
    // standard asserting
    Assert.Equal(12, add 5 7)
    Assert.NotEqual(14, add 5 7)

    
/// in the following example notice the spoken syntax
/// don't get confused by the `|>` this is a pipe operator,
/// more on that in the next file
[<Fact>]
let ``Add two numbers, the FsUnit way`` () =
    add 5 7 |> should equal 12
    add 5 7 |> should not' (equal 14)
    
