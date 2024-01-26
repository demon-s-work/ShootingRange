using System.Drawing;

namespace ShootingRange.Game
{
	public interface IEntity
	{
		void Initialize();
		void Update(float deltaMills);
		void Draw(Graphics g);
	}
}