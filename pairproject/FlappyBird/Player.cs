using System;

using Sce.PlayStation.Core;
using Sce.PlayStation.Core.Graphics;

using Sce.PlayStation.HighLevel.GameEngine2D;
using Sce.PlayStation.HighLevel.GameEngine2D.Base;

namespace FlappyBird
{
	public class Player
	{
		//Private variables.
		private static SpriteUV 	sprite;
		private static TextureInfo	textureInfo;
		private static int			pushAmount = 100;
		private static float		yPositionBeforePush;
		private static bool			rise;
		private static float		angle;
		private static bool			alive;
		private static float 		speed = 3.0f;
		
		public bool Alive { get{return alive;} set{alive = value;} }
		
		//Accessors.
		//public SpriteUV Sprite { get{return sprite;} }
		
		//Public functions.
		public Player (Scene scene)
		{
			textureInfo  = new TextureInfo("/Application/textures/bird.png");
			
			sprite	 		= new SpriteUV();
			sprite 			= new SpriteUV(textureInfo);	
			sprite.Quad.S 	= textureInfo.TextureSizef*0.5f;
			sprite.Position = new Vector2(100,100);
			//sprite.Pivot 	= new Vector2(0.5f,0.5f);
			angle = 0.0f;
			rise  = false;
			alive = true;
			
			//Add to the current scene.
			scene.AddChild(sprite);
		}
		
		public void Dispose()
		{
			textureInfo.Dispose();
		}
		
		public void Update(float deltaTime)
		{			
			//adjust the push
			if(rise)
			{
				//sprite.Rotate(0.008f);
				if( (sprite.Position.Y-yPositionBeforePush) < pushAmount)
					sprite.Position = new Vector2(sprite.Position.X + 3f, sprite.Position.Y + 3f);
				else
					rise = false;
			}
			else
			{
				//sprite.Rotate(-0.005f);
				//sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y - 3);
			}
		}	
		
		public void Update(bool n, bool e, bool s, bool w)
		{
			if (n == true)
			{
				sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y + speed);
			}
			else
			{
				sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y);
			}
			if (s == true)	
			{
				sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y - speed);
			}
			else
			{
				sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y);
			}
			if (w == true)
			{
				sprite.Position = new Vector2(sprite.Position.X - speed, sprite.Position.Y);
			}
			else
			{
				sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y);
			}
			if (e == true)
			{
				sprite.Position = new Vector2(sprite.Position.X + speed, sprite.Position.Y);
			}
			else
			{
				sprite.Position = new Vector2(sprite.Position.X, sprite.Position.Y);
			}
		}
		
		public Vector2 GetPos()
		{
			return sprite.Position;
		}
		
		public void Tapped()
		{
			if(!rise)
			{
				rise = true;
				yPositionBeforePush = sprite.Position.Y;
			}
		}
	}
}

