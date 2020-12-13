namespace ahbsd.lib
{
    /// <summary>
    /// Interface for generic EventArgs.
    /// </summary>
    /// <typeparam name="T">Type of Value.</typeparam>
    public interface IEventArgs<T>
    {
        /// <summary>
        /// Returns the value.
        /// </summary>
        /// <value>The value.</value>
        T Value { get; }
    }
}