using System.Drawing;

namespace ShootingRange.Game
{
	public class CannonEntity : DrawableEntity
	{
		protected override string SpritePath { get; set; } = "cannon.png";

		public override void Initialize()
		{
		}

		public override void Update(float deltaMills)
		{
		}
	}
}