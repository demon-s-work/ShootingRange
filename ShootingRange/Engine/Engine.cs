using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ShootingRange.Engine.Models;

namespace ShootingRange.Engine
{
	public abstract class Engine
	{
		private Vector2I _screenSize;

		public Vector2I ScreenSize
		{
			get => _screenSize;
			set => SetScreenSize(value);
		}

		private void SetScreenSize(Vector2I value)
		{
			_window.Size = new Size(value.X, value.Y);
			_screenSize = value;
		}

		private string _title;
		public string Title {
			get => _title;
			set => SetTitle(value);
		}

		private void SetTitle(string value)
		{
			_window.Text = value;
			_title = value;
		}

		private readonly Canvas _window;
		private readonly Thread _gameLoopThread;

		protected Engine(string title, Vector2I screenSize)
		{
			_title = title;
			_screenSize = screenSize;
			_window = new Canvas();
			_window.Size = new Size(screenSize.X, screenSize.Y);
			_window.Text = title;
			
			_gameLoopThread = new Thread(GameLoop);

			_window.Paint += PaintEvent;
			_window.Closing += WindowOnClosing;
			_window.Shown += WindowOnShown;
			
			Application.Run(_window);
		}

		private void WindowOnShown(object sender, EventArgs e)
		{
			_gameLoopThread.Start();
			Initialize();
		}

		private void WindowOnClosing(object sender, CancelEventArgs e)
		{
			_gameLoopThread?.Abort();
		}

		private void GameLoop()
		{
			var previousStepMills = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
			
			while (true)
			{
				_window.BeginInvoke((MethodInvoker)delegate { _window.Refresh(); });

				var currentTicks = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
				Update(currentTicks - previousStepMills);
				previousStepMills = currentTicks;
				
				Thread.Sleep(1);
			}
		}

		private void PaintEvent(object sender, PaintEventArgs e)
		{
			var g = e.Graphics;
			g.Clear(Color.White);
			Draw(g);
		}

		protected abstract void Initialize();
		protected abstract void Draw(Graphics g);
		protected abstract void Update(float deltaMills);
	}
}