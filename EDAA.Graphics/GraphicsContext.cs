using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics;

namespace EDAA.Graphics
{
	public class GraphicsContext : IDisposable{
		private OpenTK.Graphics.GraphicsContext _context;

		protected Window owner;

		public GraphicsContext(Window window){
			owner = window;
			_context = new OpenTK.Graphics.GraphicsContext(GraphicsMode.Default, window.Handle.WindowInfo);
		}

		public void BindToCurrentThread(){
			_context.MakeCurrent(owner.Handle.WindowInfo);
		}

		public void UnbindFromCurrentThread(){
			_context.MakeCurrent(null);
		}
	}
}
