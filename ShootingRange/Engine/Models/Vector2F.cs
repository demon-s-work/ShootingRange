using System.Drawing;

namespace ShootingRange.Engine.Models
{
	public class Vector2F
	{
		public float X { get; set; }
		public float Y { get; set; }

		public Vector2F(float x, float y)
		{
			X = x;
			Y = y;
		}
		
		public static Vector2F Zero => new Vector2F(0,0);
		public PointF ToPointF => new PointF(X, Y);
	}
}