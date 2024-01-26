using System.Collections.Generic;
using System.Drawing;
using ShootingRange.Engine.Models;

namespace ShootingRange.Game
{
	public class Level : IEntity
	{
		private readonly List<IEntity> _entities = new List<IEntity>();

		public void Initialize()
		{
			_entities.Add(new BallEntity
			{
				Position = new Vector2F(0,0),
				DirectionAngle = 45,
				Speed = 10
			});
			_entities.Add(new CannonEntity
			{
				Position = new Vector2F(100f,100f)
			});
			_entities.ForEach(e => e.Initialize());
		}

		public void Update(float deltaMills)
		{
			_entities.ForEach(e => e.Update(deltaMills));
		}

		public void Draw(Graphics g)
		{
			_entities.ForEach(e => e.Draw(g));
		}
	}
}