/// first let's define a module, which is similar to
/// the conventional namespace in C#.
/// the module is a sub identifier to the namespace
/// if there is no extra namespace declaration, it is included in
/// the module declaration (FSGuid).
module FSGuide.LetDeclaration

/// variables and functions are declared equally in F# using the let keyword.
/// functions are different in that they accept parameters.
/// there is no return, the last line is implicitly returned.
let someVariable = 5
let addInts x y =
    x + y

/// functions are called with the name followed by the parameters    
let addition = addInts 5 7

/// types are inferred in F#, if the compiler is not right about your types.
/// here we see parentheses for the first time,
/// they are only used for
///   * grouping (like in C#) and
///   * tuples (we will get to them later).
/// you can define types like this:
let addDoubles (x : double) (y : double) =
    x + y
    
/// Since all of this cannot be run too easily, from now on we work with tests.
/// To get more familiar with that we will be looking at nice tests in the next file.
