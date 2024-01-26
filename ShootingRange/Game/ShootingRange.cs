using System.Drawing;
using ShootingRange.Engine.Models;

namespace ShootingRange.Game
{
	public class ShootingRange : Engine.Engine
	{
		private IEntity _level = new Level();
		public ShootingRange() : base("ShootingRange", new Vector2I(1280, 720))
		{
		}

		protected override void Initialize()
		{
			_level.Initialize();
		}

		protected override void Draw(Graphics g)
		{
			_level.Draw(g);
		}

		protected override void Update(float deltaMills)
		{
			_level.Update(deltaMills);
		}
	}
}