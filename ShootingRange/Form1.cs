using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using PointF=System.Drawing.PointF;

namespace ShootingRange
{
	public partial class Form1 : Form
	{
		public Graphics g;
		public List<IEntity> Entities = new List<IEntity>();

		public Form1()
		{
			InitializeComponent();
			g = CanvasPanel.CreateGraphics();
			g.SmoothingMode = SmoothingMode.AntiAlias;
			Entities.Add(new DrawableEntity()
			{
				Position = new PointF(150f, 150f),
				Sprite = Image.FromFile("square.png")
			});
		}

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
		}

		protected override void OnShown(EventArgs e)
		{
			base.OnShown(e);
			g.Clear(Color.White);
			Entities.ForEach(ent => ent.Draw(g));
		}
	}
}