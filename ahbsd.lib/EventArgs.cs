using System;
namespace ahbsd.lib
{
    /// <summary>
    /// Class for generic EventArgs.
    /// </summary>
    /// <typeparam name="T">Type of Value.</typeparam>
    /// <remarks>Implements <see cref="IEventArgs{T}"/>.</remarks>
    public class EventArgs<T> : EventArgs, IEventArgs<T>
    {
        /// <summary>
        /// Constructor without parameters.
        /// </summary>
        public EventArgs()
            : base()
        {
            Value = default;
        }

        /// <summary>
        /// Constructor with a given value.
        /// </summary>
        /// <param name="value">The value.</param>
        public EventArgs(T value)
            : base()
        {
            Value = value;
        }


        #region implementation of IEventArgs<T>
        /// <summary>
        /// Returns the value.
        /// </summary>
        /// <value>The value.</value>
        public T Value { get; private set; }
        #endregion
    }
}
