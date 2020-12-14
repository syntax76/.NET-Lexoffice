namespace ahbsd.lib
{
    /// <summary>
    /// Delegate for events with generic API-Keys.
    /// </summary>
    /// <typeparam name="T">The Type of the API-Key.</typeparam>
    /// <param name="sender">The sending object.</param>
    /// <param name="e">The event arguments with a generic API-Key.</param>
    public delegate void ApiKeyEventHandler<T>(object sender, EventArgs<T> e);
}
