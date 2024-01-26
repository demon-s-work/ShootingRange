using System;
using MathFloat;

namespace ShootingRange.Extensions
{
	public static class MathExtension
	{
		public static float DegreeToRadian(float deg)
		{
			return (float)Math.PI / 180 * deg;
		}
	}
}