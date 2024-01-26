using System.Drawing;
using ShootingRange.Engine;

namespace ShootingRange.Game
{
	public abstract class SpriteEntity : DrawableEntity
	{
		private Image Sprite { get; set; }
		protected abstract string SpritePath { get; set; }
		public override void Initialize()
		{
			Sprite = ContentManager.GetSprite(SpritePath);
		}

		public override void Draw(Graphics g)
		{
			g.DrawImage(Sprite, Position.ToPointF);
		}
	}
}