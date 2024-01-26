using System.Drawing;
using ShootingRange.Engine.Models;

namespace ShootingRange.Game
{
	public abstract class DrawableEntity : IEntity
	{
		public Vector2F Position { get; set; }

		public virtual void Initialize()
		{
			
		}

		public abstract void Update(float deltaMills);

		public abstract void Draw(Graphics g);
	}
}