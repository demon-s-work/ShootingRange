using System.Collections.Generic;
using System.Drawing;

namespace ShootingRange.Engine
{
	public static class ContentManager
	{
		public static string Root = "";
		private static Dictionary<string, Image> _sprites = new Dictionary<string, Image>();

		public static Image GetSprite(string path)
		{
			var exist = _sprites.TryGetValue(path, out var sprite);
			if (!exist)
			{
				sprite = Image.FromFile(path);//TODO: add error cathing
				_sprites[path] = sprite;
				return sprite;
			}
			return sprite;
		}
	}
}