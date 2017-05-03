using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E.Deezer;
using NAudio.Wave;

namespace BlindTest
{
	public partial class Form1 : Form
	{
		//private static String url = "http://e-cdn-preview-5.deezer.com/stream/5e7c927a8c3c8773105f0f2a7461db9e-5.mp3";
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void text_Click(object sender, EventArgs e)
		{

		}

		private void button_Click(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private async void button1_ClickAsync(object sender, EventArgs e)
		{

			var mydeezer = DeezerSession.CreateNew();

			String result = "";

			var search = await mydeezer.Search.Playlists("Rock", 1);
			foreach (var value in search)
			{
				//result += value.Title + " | ";
				//result = await value.GetTracks;
				foreach (var v in await value.GetTracks())
				{
					result += v.Preview + " ";
				}
			}
			//MessageBox.Show(result);
			String url = "http://e-cdn-preview-5.deezer.com/stream/5e7c927a8c3c8773105f0f2a7461db9e-5.mp3";
			using (Stream memory = new MemoryStream())
			{


				using (Stream stream = WebRequest.Create(url).GetResponse().GetResponseStream())
				{
					byte[] buffer = new byte[256];
					int read;
					while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
					{

						memory.Write(buffer, 0, read);
						//MessageBox.Show(read.ToString());
					}
				}

				memory.Position = 0;
				using (WaveStream blockAlignedStream = new BlockAlignReductionStream(WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(memory))))
				{
					using (WaveOut waveOut = new WaveOut(WaveCallbackInfo.FunctionCallback()))
					{
						waveOut.Init(blockAlignedStream);
						waveOut.Play();
						while (waveOut.PlaybackState == PlaybackState.Playing) {

							System.Threading.Thread.Sleep(500);
						}
					}

				}
				memory.Dispose();
			}


		} 

		public void PlayMusic()
		{
			String url = "http://e-cdn-preview-5.deezer.com/stream/5e7c927a8c3c8773105f0f2a7461db9e-5.mp3";
			using (Stream memory = new MemoryStream())
			{


				using (Stream stream = WebRequest.Create(url).GetResponse().GetResponseStream())
				{
					byte[] buffer = new byte[256];
					int read;
					while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
					{

						memory.Write(buffer, 0, read);
						MessageBox.Show(read.ToString());
					}
				}
			}
		}
	}
}

