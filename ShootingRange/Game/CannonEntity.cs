using System.Drawing;
using ShootingRange.Engine.Models;

namespace ShootingRange.Game
{
	public class CannonEntity : DrawableEntity
	{
		public Vector2F Destination { get; set; }
		public override void Update(float deltaMills)
		{
		}

		public override void Draw(Graphics g)
		{
			g.DrawLine(Pens.Black, Position.X, Position.Y, Destination.X, Destination.Y);
		}
	}
}