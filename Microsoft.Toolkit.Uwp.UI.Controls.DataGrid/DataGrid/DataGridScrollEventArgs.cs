using System;

namespace Microsoft.Toolkit.Uwp.UI.Controls
{
    /// <summary>
    /// Provides data for DataGrid Scroll event
    /// </summary>
    public class DataGridScrollEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridScrollEventArgs"/> class.
        /// </summary>
        /// <param name="offsetDelta">Offset delta for manipulation</param>
        /// <param name="isForHorizontalScroll">Indicates if horizontal</param>
        public DataGridScrollEventArgs(double offsetDelta, bool isForHorizontalScroll)
        {
            this.OffsetDelta = offsetDelta;
            this.IsForHorizontalScroll = isForHorizontalScroll;
        }

        /// <summary>
        /// Gets the offset delta for manipulation.
        /// </summary>
        public double OffsetDelta
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets a value indicating whether change is for horizontal scroll.
        /// </summary>
        public bool IsForHorizontalScroll
        {
            get;
            private set;
        }
    }
}
