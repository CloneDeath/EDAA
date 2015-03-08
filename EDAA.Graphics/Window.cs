using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using System.Drawing;

namespace EDAA.Graphics
{
    public class Window : IDisposable {
	    protected internal NativeWindow Handle { get; private set; }

	    public Window(){
			Handle = new NativeWindow();
	    }

	    public void Dispose(){
		    Dispose(true);
		    GC.SuppressFinalize(this);
	    }

	    protected virtual void Dispose(bool disposing){
			Handle.Dispose();
	    }

	    public Size Size{
			get { return Handle.Size; }
			set { Handle.Size = value; }
	    }

	    public void Show(){
			Handle.Visible = true;
	    }
    }
}
