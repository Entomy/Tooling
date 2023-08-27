namespace System.Collections.Generic;

using System.Runtime.Serialization;

/// <summary>
/// Represents a collection of keys and values.
/// </summary>
/// <typeparam name="TValue">The type of the values in the dictionary.</typeparam>
/// <remarks>
/// This is fundamentally a <see cref="Dictionary{TKey, TValue}"/> which is keyed by textual elements.
/// </remarks>
public sealed class Dictionary<TValue> : Dictionary<String, TValue> {
	#region Constructors
	/// <summary>
	/// Initializes a new instance of the <see cref="Dictionary{TValue}"/> class that is empty, has the default initial capacity, and uses the default equality comparer for the <see cref="String"/> type.
	/// </summary>
	public Dictionary() : base() { }

	/// <summary>
	/// Initializes a new instance of the <see cref="Dictionary{TValue}"/> class that contains elements copied from the specified <see cref="IDictionary{TKey, TValue}"/> and uses the default equality comparer for the key type.
	/// </summary>
	/// <param name="dictionary">The <see cref="IDictionary{TKey, TValue}"/> whose elements are copied to the new <see cref="Dictionary{TValue}"/>.</param>
	/// <exception cref="ArgumentNullException"><paramref name="dictionary"/> is <see langword="null"/>.</exception>
	/// <exception cref="ArgumentException"><paramref name="dictionary"/> contains one or more duplicate keys.</exception>
	public Dictionary(IDictionary<String, TValue> dictionary) : base(dictionary) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="Dictionary{TValue}"/> class that contains elements copied from the specified <see cref="IEnumerable{T}"/>.
	/// </summary>
	/// <param name="collection">The <see cref="IEnumerable{T}"/> whose elements are copied to the new <see cref="Dictionary{TValue}"/>.</param>
	/// <exception cref="ArgumentNullException"><paramref name="collection"/> is <see langword="null"/>.</exception>
	/// <exception cref="ArgumentException"><paramref name="collection"/> contains one or more duplicate keys.</exception>
	public Dictionary(IEnumerable<KeyValuePair<String, TValue>> collection) : base(collection) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="Dictionary{TValue}"/> class that is empty, has the default initial capacity, and uses the specified <see cref="IEqualityComparer{T}"/>.
	/// </summary>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing keys, or <see langword="null"/> to use the default <see cref="EqualityComparer{T}"/> for the type of the key.</param>
	public Dictionary(IEqualityComparer<String>? comparer) : base(comparer) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="Dictionary{TValue}"/> class that is empty, has the specified initial capacity, and uses the default equality comparer for the key type.
	/// </summary>
	/// <param name="capacity">The initial number of elements that the <see cref="Dictionary{TValue}"/> can contain.</param>
	/// <exception cref="ArgumentOutOfRangeException"><paramref name="capacity"/> is less than 0.</exception>
	public Dictionary(Int32 capacity) : base(capacity) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="Dictionary{TValue}"/> class that contains elements copied from the specified <see cref="IDictionary{TKey, TValue}"/> and uses the specified <see cref="IEqualityComparer{T}"/>.
	/// </summary>
	/// <param name="dictionary">The <see cref="IDictionary{TKey, TValue}"/> whose elements are copied to the new <see cref="Dictionary{TValue}"/>.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing keys, or <see langword="null"/> to use the default <see cref="EqualityComparer{T}"/> for the type of the key.</param>
	/// <exception cref="ArgumentNullException"><paramref name="dictionary"/> is <see langword="null"/>.</exception>
	/// <exception cref="ArgumentException"><paramref name="dictionary"/> contains one or more duplicate keys.</exception>
	public Dictionary(IDictionary<String, TValue> dictionary, IEqualityComparer<String>? comparer) : base(dictionary, comparer) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="Dictionary{TValue}"/> class that contains elements copied from the specified <see cref="IEnumerable{T}"/> and uses the specified <see cref="IEqualityComparer{T}"/>.
	/// </summary>
	/// <param name="collection">The <see cref="IEnumerable{T}"/> whose elements are copied to the new <see cref="Dictionary{TValue}"/>.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing keys, or <see langword="null"/> to use the default <see cref="EqualityComparer{T}"/> for the type of the key.</param>
	/// <exception cref="ArgumentNullException"><paramref name="collection"/> is <see langword="null"/>.</exception>
	/// <exception cref="ArgumentException"><paramref name="collection"/> contains one or more duplicate keys.</exception>
	public Dictionary(IEnumerable<KeyValuePair<String, TValue>> collection, IEqualityComparer<String>? comparer) : base(collection, comparer) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="Dictionary{TValue}"/> class that is empty, has the specified initial capacity, and uses the specified <see cref="IEqualityComparer{T}"/>.
	/// </summary>
	/// <param name="capacity">The initial number of elements that the <see cref="Dictionary{TValue}"/> can contain.</param>
	/// <param name="comparer">The <see cref="IEqualityComparer{T}"/> implementation to use when comparing keys, or <see langword="null"/> to use the default <see cref="EqualityComparer{T}"/> for the type of the key.</param>
	/// <exception cref="ArgumentOutOfRangeException"><paramref name="capacity"/> is less than 0.</exception>
	public Dictionary(Int32 capacity, IEqualityComparer<String>? comparer) : base(capacity, comparer) { }

	/// <summary>
	/// Initializes a new instance of the <see cref="Dictionary{TValue}"/> class with serialized data.
	/// </summary>
	/// <param name="info">A <see cref="SerializationInfo"/> object containing the information required to serialize the <see cref="Dictionary{TValue}"/>.</param>
	/// <param name="context">A <see cref="StreamingContext"/> structure containing the source and destination of the serialized stream associated with the <see cref="Dictionary{TValue}"/>.</param>
	private Dictionary(SerializationInfo info, StreamingContext context) : base(info, context) { }
	#endregion

	#region Indexer
	/// <summary>
	/// Gets or sets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get or set.</param>
	/// <returns>The value associated with the specified key. If the specified key is not found, a get operation throws a <see cref="KeyNotFoundException"/>, and a set operation creates a new element with the specified key.</returns>
	public TValue this[Char[] key] {
		get => this[new String(key)];
		set => this[new String(key)] = value;
	}

	/// <summary>
	/// Gets or sets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get or set.</param>
	/// <returns>The value associated with the specified key. If the specified key is not found, a get operation throws a <see cref="KeyNotFoundException"/>, and a set operation creates a new element with the specified key.</returns>
	public TValue this[Memory<Char> key] {
		get => this[key.ToString()];
		set => this[key.ToString()] = value;
	}

	/// <summary>
	/// Gets or sets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get or set.</param>
	/// <returns>The value associated with the specified key. If the specified key is not found, a get operation throws a <see cref="KeyNotFoundException"/>, and a set operation creates a new element with the specified key.</returns>
	public TValue this[ReadOnlyMemory<Char> key] {
		get => this[key.ToString()];
		set => this[key.ToString()] = value;
	}

	/// <summary>
	/// Gets or sets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get or set.</param>
	/// <returns>The value associated with the specified key. If the specified key is not found, a get operation throws a <see cref="KeyNotFoundException"/>, and a set operation creates a new element with the specified key.</returns>
	public TValue this[Span<Char> key] {
		get => this[key.ToString()];
		set => this[key.ToString()] = value;
	}

	/// <summary>
	/// Gets or sets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get or set.</param>
	/// <returns>The value associated with the specified key. If the specified key is not found, a get operation throws a <see cref="KeyNotFoundException"/>, and a set operation creates a new element with the specified key.</returns>
	public TValue this[ReadOnlySpan<Char> key] {
		get => this[key.ToString()];
		set => this[key.ToString()] = value;
	}

	/// <summary>
	/// Gets or sets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get or set.</param>
	/// <param name="length">The length of the <paramref name="key"/>.</param>
	/// <returns>The value associated with the specified key. If the specified key is not found, a get operation throws a <see cref="KeyNotFoundException"/>, and a set operation creates a new element with the specified key.</returns>
	[CLSCompliant(false)]
	public unsafe TValue this[Char* key, Int32 length] {
		get => this[new String(key, 0, length)];
		set => this[new String(key, 0, length)] = value;
	}
	#endregion

	#region Add
	/// <summary>
	/// Adds the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. The value can be <see langword="null"/> for reference types.</param>
	public void Add(Char[] key, TValue value) => Add(new String(key), value);

	/// <summary>
	/// Adds the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. The value can be <see langword="null"/> for reference types.</param>
	public void Add(Memory<Char> key, TValue value) => Add(key.ToString(), value);

	/// <summary>
	/// Adds the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. The value can be <see langword="null"/> for reference types.</param>
	public void Add(ReadOnlyMemory<Char> key, TValue value) => Add(key.ToString(), value);

	/// <summary>
	/// Adds the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. The value can be <see langword="null"/> for reference types.</param>
	public void Add(Span<Char> key, TValue value) => Add(key.ToString(), value);

	/// <summary>
	/// Adds the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. The value can be <see langword="null"/> for reference types.</param>
	public void Add(ReadOnlySpan<Char> key, TValue value) => Add(key.ToString(), value);

	/// <summary>
	/// Adds the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="length">The length of the <paramref name="key"/>.</param>
	/// <param name="value">The value of the element to add. The value can be <see langword="null"/> for reference types.</param>
	[CLSCompliant(false)]
	public unsafe void Add(Char* key, Int32 length, TValue value) => Add(new String(key, 0, length), value);
	#endregion

	#region ContainsKey
	/// <summary>
	/// Determines whether the <see cref="Dictionary{TValue}"/> contains the specified key.
	/// </summary>
	/// <param name="key">The key to locate in the <see cref="Dictionary{TValue}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified <paramref name="key"/>; otherwise, <see langword="false"/>.</returns>
	public Boolean ContainsKey(Char[] key) => ContainsKey(new String(key));

	/// <summary>
	/// Determines whether the <see cref="Dictionary{TValue}"/> contains the specified key.
	/// </summary>
	/// <param name="key">The key to locate in the <see cref="Dictionary{TValue}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified <paramref name="key"/>; otherwise, <see langword="false"/>.</returns>
	public Boolean ContainsKey(Memory<Char> key) => ContainsKey(key.ToString());

	/// <summary>
	/// Determines whether the <see cref="Dictionary{TValue}"/> contains the specified key.
	/// </summary>
	/// <param name="key">The key to locate in the <see cref="Dictionary{TValue}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified <paramref name="key"/>; otherwise, <see langword="false"/>.</returns>
	public Boolean ContainsKey(ReadOnlyMemory<Char> key) => ContainsKey(key.ToString());

	/// <summary>
	/// Determines whether the <see cref="Dictionary{TValue}"/> contains the specified key.
	/// </summary>
	/// <param name="key">The key to locate in the <see cref="Dictionary{TValue}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified <paramref name="key"/>; otherwise, <see langword="false"/>.</returns>
	public Boolean ContainsKey(Span<Char> key) => ContainsKey(key.ToString());

	/// <summary>
	/// Determines whether the <see cref="Dictionary{TValue}"/> contains the specified key.
	/// </summary>
	/// <param name="key">The key to locate in the <see cref="Dictionary{TValue}"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified <paramref name="key"/>; otherwise, <see langword="false"/>.</returns>
	public Boolean ContainsKey(ReadOnlySpan<Char> key) => ContainsKey(key.ToString());

	/// <summary>
	/// Determines whether the <see cref="Dictionary{TValue}"/> contains the specified key.
	/// </summary>
	/// <param name="key">The key to locate in the <see cref="Dictionary{TValue}"/>.</param>
	/// <param name="length">The length of the <paramref name="key"/>.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified <paramref name="key"/>; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	public unsafe Boolean ContainsKey(Char* key, Int32 length) => ContainsKey(new String(key, 0, length));
	#endregion

	#region Remove
	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>. This method returns <see langword="false"/> if <paramref name="key"/> is not found in the <see cref="Dictionary{TValue}"/>.</returns>
	public Boolean Remove(Char[] key) => Remove(new String(key));

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>. This method returns <see langword="false"/> if <paramref name="key"/> is not found in the <see cref="Dictionary{TValue}"/>.</returns>
	public Boolean Remove(Memory<Char> key) => Remove(key.ToString());

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>. This method returns <see langword="false"/> if <paramref name="key"/> is not found in the <see cref="Dictionary{TValue}"/>.</returns>
	public Boolean Remove(ReadOnlyMemory<Char> key) => Remove(key.ToString());

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>. This method returns <see langword="false"/> if <paramref name="key"/> is not found in the <see cref="Dictionary{TValue}"/>.</returns>
	public Boolean Remove(Span<Char> key) => Remove(key.ToString());

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>. This method returns <see langword="false"/> if <paramref name="key"/> is not found in the <see cref="Dictionary{TValue}"/>.</returns>
	public Boolean Remove(ReadOnlySpan<Char> key) => Remove(key.ToString());

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <param name="length">The length of the <paramref name="key"/>.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>. This method returns <see langword="false"/> if <paramref name="key"/> is not found in the <see cref="Dictionary{TValue}"/>.</returns>
	[CLSCompliant(false)]
	public unsafe Boolean Remove(Char* key, Int32 length) => Remove(new String(key, 0, length));

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>, and copies the element to the <paramref name="value"/> parameter.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <param name="value">The removed element.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>.</returns>
	public Boolean Remove(Char[] key, [MaybeNull] out TValue value) => Remove(new String(key), out value);

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>, and copies the element to the <paramref name="value"/> parameter.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <param name="value">The removed element.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>.</returns>
	public Boolean Remove(Memory<Char> key, [MaybeNull] out TValue value) => Remove(key.ToString(), out value);

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>, and copies the element to the <paramref name="value"/> parameter.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <param name="value">The removed element.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>.</returns>
	public Boolean Remove(ReadOnlyMemory<Char> key, [MaybeNull] out TValue value) => Remove(key.ToString(), out value);

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>, and copies the element to the <paramref name="value"/> parameter.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <param name="value">The removed element.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>.</returns>
	public Boolean Remove(Span<Char> key, [MaybeNull] out TValue value) => Remove(key.ToString(), out value);

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>, and copies the element to the <paramref name="value"/> parameter.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <param name="value">The removed element.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>.</returns>
	public Boolean Remove(ReadOnlySpan<Char> key, [MaybeNull] out TValue value) => Remove(key.ToString(), out value);

	/// <summary>
	/// Removes the value with the specified key from the <see cref="Dictionary{TValue}"/>, and copies the element to the <paramref name="value"/> parameter.
	/// </summary>
	/// <param name="key">The key of the element to remove.</param>
	/// <param name="length">The length of the <paramref name="key"/>.</param>
	/// <param name="value">The removed element.</param>
	/// <returns><see langword="true"/> if the element is successfully found and removed; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	public unsafe Boolean Remove(Char* key, Int32 length, [MaybeNull] out TValue value) => Remove(new String(key, 0, length), out value);
	#endregion

	#region TryAdd
	/// <summary>
	/// Attempts to add the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. It can be <see langword="null"/>.</param>
	/// <returns><see langword="true"/> if the key/value pair was added to the dictionary successfully; otherwise, <see langword="false"/>.</returns>
	public Boolean TryAdd(Char[] key, TValue value) => TryAdd(new String(key), value);

	/// <summary>
	/// Attempts to add the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. It can be <see langword="null"/>.</param>
	/// <returns><see langword="true"/> if the key/value pair was added to the dictionary successfully; otherwise, <see langword="false"/>.</returns>
	public Boolean TryAdd(Memory<Char> key, TValue value) => TryAdd(key.ToString(), value);

	/// <summary>
	/// Attempts to add the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. It can be <see langword="null"/>.</param>
	/// <returns><see langword="true"/> if the key/value pair was added to the dictionary successfully; otherwise, <see langword="false"/>.</returns>
	public Boolean TryAdd(ReadOnlyMemory<Char> key, TValue value) => TryAdd(key.ToString(), value);

	/// <summary>
	/// Attempts to add the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. It can be <see langword="null"/>.</param>
	/// <returns><see langword="true"/> if the key/value pair was added to the dictionary successfully; otherwise, <see langword="false"/>.</returns>
	public Boolean TryAdd(Span<Char> key, TValue value) => TryAdd(key.ToString(), value);

	/// <summary>
	/// Attempts to add the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="value">The value of the element to add. It can be <see langword="null"/>.</param>
	/// <returns><see langword="true"/> if the key/value pair was added to the dictionary successfully; otherwise, <see langword="false"/>.</returns>
	public Boolean TryAdd(ReadOnlySpan<Char> key, TValue value) => TryAdd(key.ToString(), value);

	/// <summary>
	/// Attempts to add the specified key and value to the dictionary.
	/// </summary>
	/// <param name="key">The key of the element to add.</param>
	/// <param name="length">The length of the <paramref name="key"/>.</param>
	/// <param name="value">The value of the element to add. It can be <see langword="null"/>.</param>
	/// <returns><see langword="true"/> if the key/value pair was added to the dictionary successfully; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	public unsafe Boolean TryAdd(Char* key, Int32 length, TValue value) => TryAdd(new String(key, 0, length), value);
	#endregion

	#region TryGetValue
	/// <summary>
	/// Gets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get.</param>
	/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value"/> parameter. This parameter is passed uninitialized.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified key; otherwise, <see langword="false"/>.</returns>
	public Boolean TryGetValue(Char[] key, [MaybeNull] out TValue value) => TryGetValue(new String(key), out value);

	/// <summary>
	/// Gets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get.</param>
	/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value"/> parameter. This parameter is passed uninitialized.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified key; otherwise, <see langword="false"/>.</returns>
	public Boolean TryGetValue(Memory<Char> key, [MaybeNull] out TValue value) => TryGetValue(key.ToString(), out value);

	/// <summary>
	/// Gets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get.</param>
	/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value"/> parameter. This parameter is passed uninitialized.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified key; otherwise, <see langword="false"/>.</returns>
	public Boolean TryGetValue(ReadOnlyMemory<Char> key, [MaybeNull] out TValue value) => TryGetValue(key.ToString(), out value);

	/// <summary>
	/// Gets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get.</param>
	/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value"/> parameter. This parameter is passed uninitialized.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified key; otherwise, <see langword="false"/>.</returns>
	public Boolean TryGetValue(Span<Char> key, [MaybeNull] out TValue value) => TryGetValue(key.ToString(), out value);

	/// <summary>
	/// Gets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get.</param>
	/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value"/> parameter. This parameter is passed uninitialized.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified key; otherwise, <see langword="false"/>.</returns>
	public Boolean TryGetValue(ReadOnlySpan<Char> key, [MaybeNull] out TValue value) => TryGetValue(key.ToString(), out value);

	/// <summary>
	/// Gets the value associated with the specified key.
	/// </summary>
	/// <param name="key">The key of the value to get.</param>
	/// <param name="length">The length of the <paramref name="key"/>.</param>
	/// <param name="value">When this method returns, contains the value associated with the specified key, if the key is found; otherwise, the default value for the type of the <paramref name="value"/> parameter. This parameter is passed uninitialized.</param>
	/// <returns><see langword="true"/> if the <see cref="Dictionary{TValue}"/> contains an element with the specified key; otherwise, <see langword="false"/>.</returns>
	[CLSCompliant(false)]
	public unsafe Boolean TryGetValue(Char* key, Int32 length, [MaybeNull] out TValue value) => TryGetValue(new String(key, 0, length), out value);
	#endregion
}
