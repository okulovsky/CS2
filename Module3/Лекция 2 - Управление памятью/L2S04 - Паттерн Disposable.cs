using System;
namespace L2S04
{
	class DisposableClass : IDisposable
	{ 
  	private bool isDisposed = false;

  	~DisposableClass()
  	{ 
	    Dispose(false); 
  	}  

  	public void Dispose()
  	{
	    Dispose(true);
	    GC.SuppressFinalize(this);
  	} 

  	protected virtual void 
        Dispose(bool isDisposing)
  	{
	    if (!isDisposed)
	    {
      		if (isDisposing)
      		{
        	// clean up managed resources;
      		}
        	// clean up unmanaged resources
        	isDisposed = false;
        	// base.Dispose(isDisposing); // если унаследован от Disposable класса
		}
	}
	}
}
//!Что такое неуправляемые ресурсы
//!Паттерн Disposable - для удаления ссылок на неуправляемые ресурсы