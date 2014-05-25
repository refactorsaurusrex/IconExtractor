using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace IconExtractor
{
	/// <summary>
	/// Determines the size of extracted icons.
	/// </summary>
	public enum IconSize
	{
		/// <summary>
		/// 32 x 32
		/// </summary>
		Large,
		/// <summary>
		/// 16 x 16
		/// </summary>
		Small
	}

	/// <summary>
	/// Creates a new instance of the IconExtractor class.
	/// </summary>
	public sealed class IconExtractor : IDisposable
	{
		[DllImport("Shell32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern int ExtractIconEx(string fileName, int iconStartingIndex, IntPtr[] largeIcons, IntPtr[] smallIcons, int iconCount);

		[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern int DestroyIcon(IntPtr icon);

		List<Icon> icons;

		/// <summary>
		/// Initializes a new instance of the IconExtractor class.
		/// </summary>
		/// <param name="source">The full path to the file containing icons.</param>
		/// <param name="size">An IconSize value indicating whether to retreive 16x16 or 32x32 icons.</param>
		public IconExtractor(string source, IconSize size)
		{
			IconSource = source;
			IntPtr[] nullPtr = null;
			Count = ExtractIconEx(source, -1, nullPtr, nullPtr, 1);
			icons = new List<Icon>(Count);

			IntPtr[] largeIcons = size == IconSize.Large ? new IntPtr[Count] : null;
			IntPtr[] smallIcons = size == IconSize.Small ? new IntPtr[Count] : null;

			ExtractIconEx(source, 0, largeIcons, smallIcons, Count);
			IntPtr[] extractedIcons = largeIcons ?? smallIcons;

			foreach (IntPtr handle in extractedIcons)
			{
				if (handle != IntPtr.Zero)
				{
					icons.Add((Icon)Icon.FromHandle(handle).Clone());
					DestroyIcon(handle);
				}
			}
		}

		/// <summary>
		/// Returns all icons contained in the current IconExtractor.
		/// </summary>
		/// <returns>A collection of icons.</returns>
		public IEnumerable<Icon> GetAll()
		{
			return icons.AsEnumerable();
		}

		/// <summary>
		/// Releases all resources used by this IconExtractor.
		/// </summary>
		public void Dispose()
		{
			icons.ForEach(icon => icon.Dispose());
		}

		/// <summary>
		/// Gets the full path to the file containing the icons in the current IconExtractor.
		/// </summary>
		public string IconSource { get; private set; }

		/// <summary>
		/// Gets the total number of icons contained in the current IconExtractor.
		/// </summary>
		public int Count { get; private set; }

		/// <summary>
		/// Gets the icon at the specified index.
		/// </summary>
		/// <param name="index">The zero-based index of the icon to get.</param>
		public Icon this[int index]
		{
			get { return icons[index]; }	
		}
	}
}
