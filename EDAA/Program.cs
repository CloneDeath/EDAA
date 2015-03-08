using EDAA.Graphics;
using EDAA.SceneGraph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAA
{
	class Program
	{
		static void Main(string[] args){
			Scene demoScene = new Scene();

			Window window = new Window();
			GraphicsContext context = new GraphicsContext(window);
			context.BindToCurrentThread();

			while (true){
				demoScene.Render();
			}
		}
	}
}
