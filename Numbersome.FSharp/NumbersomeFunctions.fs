namespace System

open System.Numerics

/// <summary>
/// Provides F# functions for the Numbersome library.
/// </summary>
[<AutoOpen>]
module public NumbersomeFunctions =

    /// <summary>Computes the absolute of a value.</summary>
    let inline abs (value) = NumbersomeExtensions.Abs(value)

    /// <summary>omputes the arc-cosine of a value.</summary>
    let inline acos (value) = NumbersomeExtensions.Acos(value)

    /// <summary>Computes the hyperbolic arc-cosine of a value.</summary>
    let inline acosh (value) = NumbersomeExtensions.Acosh(value)

    /// <summary>Computes the arc-sine of a value.</summary>
    let inline asin (value) = NumbersomeExtensions.Asin(value)

    /// <summary>Computes the hyperbolic arc-sine of a value.</summary>
    let inline asinh (value) = NumbersomeExtensions.Asinh(value)

    /// <summary>Computes the arc-tangent of a value.</summary>
    let inline atan (value:^a):^a = NumbersomeExtensions.Atan(value)

    /// <summary>Computes the hyperbolic arc-tangent of a value.</summary>
    let inline atanh (value) = NumbersomeExtensions.Atanh(value)

    /// <summary>Decrements a value to the smallest value that compares less than a given value.</summary>
    let inline bitDecrement (value) = NumbersomeExtensions.BitDecrement(value)

    /// <summary>Increments a value to the smallest value that compares greater than a given value.</summary>
    let inline bitIncrement (value) = NumbersomeExtensions.BitIncrement(value)

    /// <summary>Computes the cube-root of a value.</summary>
    let inline cbrt (value) = NumbersomeExtensions.Cbrt(value)

    /// <summary>Computes the ceiling of a value.</summary>
    let inline ceiling (value) = NumbersomeExtensions.Ceiling(value)

    /// <summary>Clamps a value to an inclusive minimum and maximum value.</summary>
    let inline clamp (min) (max) (value) = NumbersomeExtensions.Clamp(value, min, max)

    /// <summary>Computes the compliment of a value.</summary>
    let inline co (value) = NumbersomeExtensions.Co(value)

    /// <summary>Computes the hyperbolic compliment of a value.</summary>
    let inline coh (value) = NumbersomeExtensions.Coh(value)

    /// <summary>Copies the sign of a value to the sign of another value.</summary>
    let inline copySign (sign) (magnitude) = NumbersomeExtensions.CopySign(magnitude, sign)

    /// <summary>Computes the cosine of a value.</summary>
    let inline cos (value) = NumbersomeExtensions.Cos(value)

    /// <summary>Computes the hyperbolic cosine of a value.</summary>
    let inline cosh (value) = NumbersomeExtensions.Cosh(value)

    /// <summary>Computes the tangent complement of a value.</summary>
    let inline cot (value) = NumbersomeExtensions.Cot(value)

    /// <summary>Computes the hyperbolic tangent complement of a value.</summary>
    let inline coth (value) = NumbersomeExtensions.Coth(value)

    /// <summary>Computes the chord of a value.</summary>
    let inline crd (value) = NumbersomeExtensions.Crd(value)

    /// <summary>Computes the hyperbolic chord of a value.</summary>
    let inline crdh (value) = NumbersomeExtensions.Crdh(value)

    /// <summary>Computes the secant compliment of a value.</summary>
    let inline csc (value) = NumbersomeExtensions.Csc(value)

    /// <summary>Computes the hyperbolic secant compliment of a value.</summary>
    let inline csch (value) = NumbersomeExtensions.Csch(value)

    /// <summary>Computes the versed compliment sine compliment of a value.</summary>
    let inline cvc (value)= NumbersomeExtensions.Cvc(value)

    /// <summary>Computes the hyperbolic versed compliment sine compliment of a value.</summary>
    let inline cvch (value) = NumbersomeExtensions.Cvch(value)

    /// <summary>Computes the versed sine compliment of a value.</summary>
    let inline cvs (value) = NumbersomeExtensions.Cvs(value)

    /// <summary>Computes the hyperbolic versed sine compliment of a value.</summary>
    let inline cvsh (value) = NumbersomeExtensions.Cvsh(value)

    /// <summary>Computes the quotient and remainder of two values.</summary>
    let inline ( /% ) (dividend) (divisor) =
        let struct(quotient, remainder) = NumbersomeExtensions.DivRem(dividend, divisor)
        (quotient, remainder)

    /// <summary>Computes the exterior secant compliment of a value.</summary>
    let inline exc (value) = NumbersomeExtensions.Exc(value)

    /// <summary>Computes the hyperbolic exterior secant compliment of a value.</summary>
    let inline exch (value) = NumbersomeExtensions.Exch(value)

    /// <summary>Computes <see cref="IFloatingPointConstants{TSelf}.E"/> raised to a given power.</summary>
    let inline exp (power) = NumbersomeExtensions.Exp(power)

    /// <summary>Computes <c>10</c> raised to a given power.</summary>
    let inline exp10 (power) = NumbersomeExtensions.Exp10(power)

    /// <summary>Computes <c>2</c> raised to a given power.</summary>
    let inline exp2 (power) = NumbersomeExtensions.Exp2(power)

    /// <summary>Computes the exterior secant of a value.</summary>
    let inline exs (value) = NumbersomeExtensions.Exs(value)

    /// <summary>Computes the hyperbolic exterior secant of a value.</summary>
    let inline exsh (value) = NumbersomeExtensions.Exsh(value)

    /// <summary>Computes the floor of a value.</summary>
    let inline floor (value) = NumbersomeExtensions.Floor(value)

    /// <summary>Computes the fused multiply-add of three values.</summary>
    let inline ( *+ ) (multiplicands:^a * ^a) (addend:^a) = NumbersomeExtensions.FusedMultiplyAdd(multiplicands.ToValueTuple(), addend)

    /// <summary>Computes the halved versed sine of a value.</summary>
    let inline hav (value) = NumbersomeExtensions.Hav(value)
    
    /// <summary>Computes the hyperbolic halved versed sine of a value.</summary>
    let inline havh (value) = NumbersomeExtensions.Havh(value)

    /// <summary>Computes the remainder of two values as specified by IEEE 754.</summary>
    let inline ieee754Remainder (value) = NumbersomeExtensions.Ieee754Remainder(value)

    /// <summary>Computes the integer logarithm of a value.</summary>
    let inline iLogB (value) = NumbersomeExtensions.ILogB(value)

    /// <summary>Determines if a value is in its canonical representation.</summary>
    let inline isCanonical (value) = NumbersomeExtensions.IsCanonical(value)

    /// <summary>Determines if a value represents a complex number.</summary>
    let inline isComplex (value) = NumbersomeExtensions.IsComplexNumber(value)

    /// <summary>Determines if a value represents an even integral number.</summary>
    let inline isEven (value) = NumbersomeExtensions.IsEvenInteger(value)

    /// <summary>Determines if a value is finite.</summary>
    let inline isFinite (value) = NumbersomeExtensions.IsFinite(value)

    /// <summary>Determines if a value represents an imaginary number.</summary>
    let inline isImaginary (value) = NumbersomeExtensions.IsImaginaryNumber(value)

    /// <summary>Determines if a value is infinite.</summary>
    let inline isInfinity (value) = NumbersomeExtensions.IsInfinity(value)

    /// <summary>Determines if a value represents an integral number.</summary>
    let inline isInteger (value) = NumbersomeExtensions.IsInteger(value)

    /// <summary>Determines if a value is <see cref="IFloatingPointIeee754{TSelf}.NaN"/>.</summary>
    let inline isNaN (value) = NumbersomeExtensions.IsNaN(value)

    /// <summary>Computes the natural (base-<see cref="IFloatingPointConstants{TSelf}.E"/>) logarithm of a value.</summary>
    let inline log (value) = NumbersomeExtensions.Log(value)

    /// <summary>Computes the base-10 logarithm of a value.</summary>
    let inline log10 (value) = NumbersomeExtensions.Log10(value)

    /// <summary>Computes the log2 of a value.</summary>
    let inline log2 (value) = NumbersomeExtensions.Log2(value)

    /// <summary>Computes the number of bits that are set in a value.</summary>
    let inline popCount (value) = NumbersomeExtensions.PopCount(value)

    /// <summary>Computes a value raised to a given power.</summary>
    let inline pow (power) (value) = NumbersomeExtensions.Pow(value, power)

    /// <summary>Computes an estimate of the reciprocal of a value.</summary>
    let inline reciprocalEstimate (value) = NumbersomeExtensions.ReciprocalEstimate(value)

    /// <summary>Computes an estimate of the reciprocal square root of a value.</summary>
    let inline reciprocalSqrtEstimate (value) = NumbersomeExtensions.ReciprocalSqrtEstimate(value)

    /// <summary>Computes the n-th root of a value.</summary>
    let inline root (value) = NumbersomeExtensions.Root(value)

    /// <summary>Rounds a value to the nearest integer using the default rounding mode (<see cref="MidpointRounding.ToEven"/>).</summary>
    let inline round (value) = NumbersomeExtensions.Round(value)

    /// <summary>Computes the product of a value and its base-radix raised to the specified power.</summary>
    let inline scaleB (power) (value) = NumbersomeExtensions.ScaleB(value, power)

    /// <summary>Computes the secant of a value.</summary>
    let inline sec (value) = NumbersomeExtensions.Sec(value)

    /// <summary>Computes the hyperbolic secant of a value.</summary>
    let inline sech (value) = NumbersomeExtensions.Sech(value)

    /// <summary>Computes the sign of a value.</summary>
    let inline sign (value) = NumbersomeExtensions.Sign(value)

    /// <summary>Computes the sine of a value.</summary>
    let inline sin (value) = NumbersomeExtensions.Sin(value)

    /// <summary>Computes the sine and cosine of a value.</summary>
    let inline sinCos (value) = NumbersomeExtensions.SinCos(value)

    /// <summary>Computes the hyperbolic sine of a value.</summary>
    let inline sinh (value) = NumbersomeExtensions.Sinh(value)

    /// <summary>Computes the square-root of a value.</summary>
    let inline sqrt (value) = NumbersomeExtensions.Sqrt(value)

    /// <summary>Computes the tangent of a value.</summary>
    let inline tan (value) = NumbersomeExtensions.Tan(value)

    /// <summary>Computes the hyperbolic tangent of a value.</summary>
    let inline tanh (value) = NumbersomeExtensions.Tanh(value)

    /// <summary>Computes the number of trailing zeros in a value.</summary>
    let inline trailingZeroCount (value) = NumbersomeExtensions.TrailingZeroCount(value)

    /// <summary>Truncates a value.</summary>
    let inline truncate (value) = NumbersomeExtensions.Truncate(value)

    /// <summary>Computes the versed sine compliment of a value.</summary>
    let inline vcs (value) = NumbersomeExtensions.Vcs(value)

    /// <summary>Computes the hyperbolic versed sine compliment of a value.</summary>
    let inline vcsh (value) = NumbersomeExtensions.Vcsh(value)

    /// <summary>Computes the versed sine of a value.</summary>
    let inline ver (value) = NumbersomeExtensions.Ver(value)

    /// <summary>Computes the hyperbolic versed sine of a value.</summary>
    let inline verh (value) = NumbersomeExtensions.Verh(value)

    /// <summary>Gets a value that represents <c>NaN</c>.</summary>
    let inline NaN< ^a when ^a :> IFloatingPointIeee754< ^a>> = NumbersomeExtensions.NaN< ^a>()

    /// <summary>Gets the mathematical constant <c>e</c>.</summary>
    let inline e< ^a when ^a :> IFloatingPointConstants< ^a>> = NumbersomeExtensions.e< ^a>()

    /// <summary>Gets the smallest value such that can be added to <see cref="INumberBase{TSelf}.Zero"/> that does not result in <see cref="INumberBase{TSelf}.Zero"/>.</summary>
    let inline ε< ^a when ^a :> IFloatingPointIeee754< ^a>> = NumbersomeExtensions.ε< ^a>()
    
    /// <summary>Gets the mathematical constant <c>π</c>.</summary>
    let inline π< ^a when ^a :> IFloatingPointConstants< ^a>> = NumbersomeExtensions.π< ^a>()

    /// <summary>Gets the mathematical constant <c>τ</c>.</summary>
    let inline τ< ^a when ^a :> IFloatingPointConstants< ^a>> = NumbersomeExtensions.τ< ^a>()

    /// <summary>Gets the additive identity of the current type.</summary>
    let inline additiveIdentity< ^a when ^a :> IAdditiveIdentity< ^a, ^a>> = NumbersomeExtensions.AdditiveIdentity< ^a>()

    /// <summary>Gets the maximum value of the current type.</summary>
    let inline maxValue< ^a when ^a :> IMinMaxValue< ^a>> = NumbersomeExtensions.MaxValue< ^a>()

    /// <summary>Gets the minimum value of the current type.</summary>
    let inline minValue< ^a when ^a :> IMinMaxValue< ^a>> = NumbersomeExtensions.MinValue< ^a>()

    /// <summary>Gets the multiplicative identity of the current type.</summary>
    let inline multiplicativeIdentity< ^a when ^a :> IMultiplicativeIdentity< ^a, ^a>> = NumbersomeExtensions.MultiplicativeIdentity< ^a>()

    /// <summary>Gets the value <c>1</c> for the type.</summary>
    let inline one< ^a when ^a :> INumberBase< ^a>> = NumbersomeExtensions.One< ^a>()

    /// <summary>Gets the radix, or base, for the type.</summary>
    let inline radix< ^a when ^a :> INumberBase< ^a>> = NumbersomeExtensions.Radix< ^a>()

    /// <summary>Gets the value <c>0</c> for the type.</summary>
    let inline zero< ^a when ^a :> INumberBase< ^a>> = NumbersomeExtensions.Zero< ^a>()

    /// <summary>Multiplies the <paramref name="values"/>.</summary>
    let inline product (values:^a seq) =
        let mutable p = multiplicativeIdentity< ^a>
        for value in values do
            p <- p * value
        p

    /// <summary>Sumates the <paramref name="values"/>.</summary>
    let inline sum (values:^a seq) =
        let mutable s = additiveIdentity< ^a>
        for value in values do
            s <- s + value
        s

    /// <summary>Averages the <paramref name="values"/>, by arithmetic mean.</summary>
    let inline arithmeticMean (values:^a seq):^a =
        let mutable sum = additiveIdentity< ^a>
        let mutable count = zero< ^a>
        for value in values do
            sum <- sum + value
            count <- count + one< ^a>
        sum / count

    /// <summary>Averages the <paramref name="values"/>, by geometric mean.</summary>
    let inline geometricMean (values:^a seq) =
        let mutable prod = multiplicativeIdentity< ^a>
        let mutable count = zero< ^a>
        for value in values do
            prod <- prod * value
            count <- count + one< ^a>
        prod |> pow (one< ^a> / count)

    /// <summary>Averages the <paramref name="values"/>, by harmonic mean.</summary>
    let inline harmonicMean (values:^a seq):^a =
        let mutable sum = additiveIdentity< ^a>
        let mutable count = zero< ^a>
        for value in values do
            sum <- one< ^a> / value
            count <- count + one< ^a>
        count / sum
