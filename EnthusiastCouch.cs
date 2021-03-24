using Terraria.ModLoader;

namespace EnthusiastCouch
{
	public class EnthusiastCouch : Mod
	{
		public static EnthusiastCouch Instance;

		public EnthusiastCouch()
		{
			Instance = this;
		}

		public override void Load()
		{
			if (Instance == null || Instance != this)
			{
				Instance = this;
			}
		}
	}
}