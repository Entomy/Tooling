namespace System.Numerics

/// <summary>Represents a percentage.</summary>
type percent<'t when 't :> INumberBase<'t>> = Percent<'t>

[<AutoOpen>]
module NumbersomeFunctions =
    /// <summary>Takes the <paramref name="percentage"/> of the <paramref name="value"/>.</summary>
    let inline ( %> ) (percentage:^a percent) (value:^a) = percentage.Of(value)

    /// <summary>Takes the <paramref name="percentage"/> of the <paramref name="value"/>.</summary>
    let inline ( <% ) (value:^a) (percentage:^a percent) = percentage.Of(value)
