using System.Drawing;

namespace ShootingRange
{
	public interface IEntity
	{
		void Update(float mils, float delta);
		void Draw(Graphics g);
	}
}