using MathFloat;
using ShootingRange.Extensions;

namespace ShootingRange.Game
{
	public class BallEntity : SpriteEntity
	{
		public float DirectionAngle { get; set; }
		public float Speed { get; set; }

		protected override string SpritePath { get; set; } = "ball.png";

		public override void Update(float deltaMills)
		{
			var x = MathF.Round(Position.X + Speed * MathF.Cos(MathExtension.DegreeToRadian(DirectionAngle)));//TODO: may not speedy
			var y = MathF.Round(Position.Y + Speed * MathF.Sin(MathExtension.DegreeToRadian(DirectionAngle)));
			Position.X = x;
			Position.Y = y;
		}
	}
}