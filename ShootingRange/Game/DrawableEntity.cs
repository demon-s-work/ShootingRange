using System.Drawing;
using ShootingRange.Engine;
using ShootingRange.Engine.Models;

namespace ShootingRange.Game
{
	public abstract class DrawableEntity : IEntity
	{
		public Vector2F Position { get; set; }
		private Image Sprite { get; set; }
		protected abstract string SpritePath { get; set; }

		public virtual void Initialize()
		{
			Sprite = ContentManager.GetSprite(SpritePath);
		}

		public abstract void Update(float deltaMills);
		
		public virtual void Draw(Graphics g)
		{
			g.DrawImage(Sprite, Position.ToPointF);
		}
	}
}