using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace FlappyBird
{
	public class Background
	{	
		//Private variables.
		private SpriteUV 	sprites;
		private TextureInfo	textureInfo;
		private float		width;
		private float 		height;
		
		//Public functions.
		public Background (Scene scene)
		{
			sprites	= new SpriteUV();
			
			textureInfo  		= new TextureInfo("/Application/textures/background.png");
			//Left
			sprites 			= new SpriteUV(textureInfo);
			sprites.Quad.S 		= textureInfo.TextureSizef/0.01f;
									
			//Position pipes.
			sprites.Position = new Vector2(-1000.0f, -1000.0f);
						
			//Add to the current scene.
			//foreach(SpriteUV sprite in sprites)
				scene.AddChild(sprites);
		}	
		
		public void Dispose()
		{
			textureInfo.Dispose();
		}
		
		public void Update(float deltaTime)
		{			
//			sprites[0].Position = new Vector2(sprites[0].Position.X - 0.5f, sprites[0].Position.Y);
//			sprites[1].Position = new Vector2(sprites[1].Position.X - 0.5f, sprites[1].Position.Y);
//			sprites[2].Position = new Vector2(sprites[2].Position.X - 0.5f, sprites[2].Position.Y);
//			
//			//Move the background.
//			//Left
//			if(sprites[0].Position.X < -width)
//				sprites[0].Position = new Vector2(sprites[2].Position.X+width, 0.0f);
//			else
//				sprites[0].Position = new Vector2(sprites[0].Position.X-1, 0.0f);	
//			
//			//Middle
//			if(sprites[1].Position.X < -width)
//				sprites[1].Position = new Vector2(sprites[0].Position.X+width, 0.0f);
//			else
//				sprites[1].Position = new Vector2(sprites[1].Position.X-1, 0.0f);	
//			
//			//Right
//			if(sprites[2].Position.X < -width)
//				sprites[2].Position = new Vector2(sprites[1].Position.X+width, 0.0f);
//			else
//				sprites[2].Position = new Vector2(sprites[2].Position.X-1, 0.0f);	
		}
	}
}

