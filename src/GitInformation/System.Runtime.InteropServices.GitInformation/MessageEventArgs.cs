// Copyright (c) 2019, AraHaan.
// https://github.com/AraHaan/
// All rights reserved.
// license: MIT, see LICENSE for more details.

namespace System.Messaging
{
    using System;

    /// <summary>
    /// Event that holds the message text and the caption.
    /// </summary>
    public class MessageEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MessageEventArgs"/> class.
        /// </summary>
        /// <param name="text">The text for the message.</param>
        /// <param name="caption">The title (caption) for the message.</param>
        public MessageEventArgs(string text, string caption)
        {
            this.Text = text;
            this.Caption = caption;
        }

        /// <summary>
        /// Gets or sets the text for the message.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the caption (title) for the message.
        /// </summary>
        public string Caption { get; set; }
    }
}
