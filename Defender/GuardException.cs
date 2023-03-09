namespace Defender;

/// <summary>
/// Thrown when a guard fails.
/// </summary>
public sealed class GuardException : Exception {
	/// <inheritdoc/>
	public GuardException(String message) : base(message) { }

	/// <inheritdoc/>
	public GuardException(String message, Exception inner) : base(message, inner) { }
}
