using System.Drawing;

namespace ShootingRange
{
	public class DrawableEntity : IEntity
	{
		public PointF Position { get; set; }
		public Image Sprite { get; set; }
		
		public void Update(float mils, float delta)
		{
			
		}

		public void Draw(Graphics g)
		{
			g.DrawImage(Sprite, Position);
		}
	}
}