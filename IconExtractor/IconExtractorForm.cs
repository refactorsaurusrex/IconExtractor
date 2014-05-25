using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace IconExtractor
{
	public partial class IconExtractorForm : Form
	{
		IconExtractor iconExtractor;
		List<PictureBox> pictureBoxes = new List<PictureBox>();
		System.Timers.Timer timer;

		public IconExtractorForm()
		{
			InitializeComponent();

			// Timer clears any user messages after a 7 second delay.
			timer = new System.Timers.Timer(7000D);
			timer.AutoReset = false;
			timer.SynchronizingObject = this;
			timer.Elapsed += (s, e) => labelInfo.Text = "";

			RefreshIcons(@"C:\Windows\system32\imageres.dll");
		}

		/// <summary>
		/// Refreshes the icons displayed on the form, use the icons extracted from the indicated file.
		/// </summary>
		/// <param name="filePath">The full path to the file containing icons.</param>
		void RefreshIcons(string filePath)
		{
			labelInfo.Text = "Loading icons...";
			this.Refresh();
			textBoxFilePath.Text = filePath;
			iconExtractor = new IconExtractor(filePath, IconSize.Large);

			flowLayoutPanel.Controls.Clear();
			pictureBoxes.ForEach(p => p.Dispose());
			pictureBoxes.Clear();

			if (iconExtractor.Count == 0)
			{
				labelInfo.Text = "No icons found in that file...";
				timer.Interval = 7000D;
				timer.Start();
				return;
			}

			foreach (Icon icon in iconExtractor.GetAll())
			{
				pictureBoxes.Add(new PictureBox() { Image = icon.ToBitmap() });
			}

			int index = 0;
			foreach (var pictureBox in pictureBoxes)
			{
				pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
				toolTip.SetToolTip(pictureBox, index++.ToString());
				pictureBox.DoubleClick += new EventHandler(pictureBox_DoubleClick);
				flowLayoutPanel.Controls.Add(pictureBox);
			}

			this.Icon = iconExtractor[new Random().Next(iconExtractor.Count)];
			labelInfo.Text = "";
		}

		/// <summary>
		/// Saves the clicked icon on the desktop as a bitmap file.
		/// </summary>
		void pictureBox_DoubleClick(object sender, EventArgs e)
		{
			string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string filePath = Path.Combine(desktopPath, "icon.bmp");

			int i = 0;
			while (File.Exists(filePath))
			{
				string fileName = String.Format("icon({0}).bmp", i++);
				filePath = Path.Combine(desktopPath, fileName);
			} 

			((PictureBox)sender).Image.Save(filePath);
			labelInfo.Text = String.Format("File saved as ''{0}'' on your desktop", Path.GetFileName(filePath));
			timer.Interval = 7000D;
			timer.Start();
		}

		/// <summary>
		/// Prompts user to select a different file from which to extract icons.
		/// </summary>
		void buttonOpen_Click(object sender, EventArgs e)
		{
			openFileDialog.InitialDirectory = Path.GetDirectoryName(textBoxFilePath.Text);
			openFileDialog.FileName = ""; 
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				textBoxFilePath.Text = openFileDialog.FileName;
				RefreshIcons(textBoxFilePath.Text);
			}
		}

		void IconExtractorForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			iconExtractor.Dispose();
		}
	}
}
