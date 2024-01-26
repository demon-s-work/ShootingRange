namespace ShootingRange.Engine.Models
{
	public class Vector2I
	{
		public int X { get; set; }
		public int Y { get; set; }

		public Vector2I(int x, int y)
		{
			X = x;
			Y = y;
		}
		
		public static Vector2I Zero => new Vector2I(0,0);
	}
}