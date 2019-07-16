﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FluentFTP.Exceptions {
	/// <summary>
	/// This exception is thrown by FtpListParser.
	/// </summary>
	public class FtpListParseException : Exception {
		/// <summary>
		/// Creates a new FtpListParseException.
		/// </summary>
		public FtpListParseException()
			: base("Cannot parse file listing!") {
		}
	}
}