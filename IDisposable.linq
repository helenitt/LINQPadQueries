<Query Kind="Program" />

int Main()
{
	using (var foo = new Foo(5))
	{
		foo.Dump();
		return 1;
	}
	
//	using (var bar = new Bar())
//	{
//		bar.Dump();
//	}
//	return 1;
}

public class Foo : IDisposable
{
	public int SomeInt { get; set; }
	
	public Foo(int x) {
		SomeInt = x;
	}

	public void Dispose() {
		"Disposing of Foo".Dump();
	}
}

// Define other methods and classes here
public class Bar
{
	
}