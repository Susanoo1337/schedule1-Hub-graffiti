using UnityEngine;

namespace HUB.Graffiti
{
	internal class StickerData
	{
		public string Name { get; set; } = "";

		public string FilePath { get; set; } = "";

		public Texture2D Texture { get; set; }

		public Sprite Sprite { get; set; }
	}
}
