namespace Tests

open System
open System.Numerics
open Xunit

module System =
    
    [<Fact>]
    let ``+`` () =
        Assert.Equal(2, 1 + 1)
        Assert.Equal(2.0, 1.0 + 1.0)
        Assert.Equal("hello!", "hello" + "!")
        Assert.Equal(2y, 1y + 1y)
        Assert.Equal(2us, 1us + 1us)
        Assert.Equal(2L, 1L + 1L)
        
    [<Fact>]
    let ``&&&`` () = Assert.Equal(0, 0 &&& 1)

    [<Fact>]
    let ``arithmeticMean`` () = Assert.Equal(3.0, arithmeticMean [1.0; 2.0; 3.0; 4.0; 5.0])

    [<Fact>]
    let ``~+`` () = Assert.Equal(1.0, +1.0)

    [<Fact>]
    let ``/`` () = Assert.Equal(1.0, 2.0 / 2.0)

    [<Fact>]
    let ``/%`` () = Assert.Equal((2, 1), 5 /% 2)

    [<Fact>]
    let ``*+`` () = Assert.Equal(5.0, (2.0, 2.0) *+ 1.0)

    [<Fact>]
    let ``geometricMean`` () = Assert.Equal(2.605171084697352, geometricMean [1.0; 2.0; 3.0; 4.0; 5.0])

    [<Fact>]
    let ``harmonicMean`` () = Assert.Equal(2.18978102189781, harmonicMean [1.0; 2.0; 3.0; 4.0; 5.0])

    [<Fact>]
    let ``%`` () = Assert.Equal(1.0, 5.0 % 2.0)

    [<Fact>]
    let ``*`` () = Assert.Equal(4.0, 2.0 * 2.0)

    [<Fact>]
    let ``~-`` () = Assert.Equal(1.0, -(-1.0))

    [<Fact>]
    let ``~~~`` () = Assert.Equal(-2, ~~~1)

    [<Fact>]
    let ``|||`` () = Assert.Equal(1, 0 ||| 1)

    [<Fact>]
    let ``product`` () = Assert.Equal(120.0, product [1.0; 2.0; 3.0; 4.0; 5.0])

    [<Fact>]
    let ``sum`` () = Assert.Equal(15.0, sum [1.0; 2.0; 3.0; 4.0; 5.0])

module SystemNumerics =
    [<Fact>]
    let ``+`` () = Assert.Equal(12.5, 10.0 + percent(25.0))

    [<Fact>]
    let ``%>`` () = Assert.Equal(2.5, percent(25.0) %> 10.0)

    [<Fact>]
    let ``<%`` () = Assert.Equal(2.5, 10.0 <% percent(25.0))
