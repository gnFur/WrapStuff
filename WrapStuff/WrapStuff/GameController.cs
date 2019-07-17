﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Monofoxe.Engine;
using Monofoxe.Engine.Drawing;
using Monofoxe.Engine.ECS;
using Monofoxe.Engine.SceneSystem;
using Monofoxe.Engine.Cameras;
using Resources.Sprites;
using WrapStuff.Wraps;

namespace WrapStuff
{
	public class GameController : Entity
	{
		Camera cam = new Camera(800, 600);

		Panel panel;
		
		public GameController() : base(SceneMgr.GetScene("default")["default"])
		{
			GameMgr.MaxGameSpeed = 60;
			GameMgr.MinGameSpeed = 60; // Fixing framerate on 60.

			cam.BackgroundColor = new Color(38, 38, 38);

			GameMgr.WindowManager.CanvasSize = new Vector2(800, 600);
			GameMgr.WindowManager.Window.AllowUserResizing = false;
			GameMgr.WindowManager.ApplyChanges();
			GameMgr.WindowManager.CenterWindow();
			GameMgr.WindowManager.CanvasMode = CanvasMode.Fill;
			
			GraphicsMgr.Sampler = SamplerState.PointClamp;


			
			var a1 = new Panel
			{
				Position = new Vector2(0, 0),
				Size = new Vector2(8, 32),
				Side = 0
			};
			var a2 = new Panel
			{
				Position = new Vector2(0, 0),
				Size = new Vector2(8, 32),
				Side = 1
			};
			var a3 = new Panel
			{
				Position = new Vector2(0, 0),
				Size = new Vector2(8, 32),
				Side = 2
			};
			var a4 = new Panel
			{
				Position = new Vector2(0, 0),
				Size = new Vector2(8, 32),
				Side = 3
			};
			panel = new Panel
			{
				Position = new Vector2(300, 300),
				Size = new Vector2(64, 64),
				Attachments = new Panel[]{a1, a2, a3, a4}
			};

		}

		public override void Update()
		{
			
		}

		
		public override void Draw()
		{
			//Default.Monofoxe.Draw(new Vector2(400, 300), Default.Monofoxe.Origin);
			GraphicsMgr.CurrentColor = Color.White * 0.5f;
			panel.Draw();
		}

	}
}